using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class InternalProcesses
    {
        #region Members
        List<Process> _processes;
        private static PerformanceCounter cpuCounter;
        private static PerformanceCounter ramCounter;
        #endregion

        #region Construktor
        public InternalProcesses()
        {
            _processes = Process.GetProcesses().ToList();   //get the processes how currently run
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); //to get the CPU useage
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");      //to get the RAM useage
        }
        #endregion

        #region Methods
        public List<ProcessWithCount> GetCurrentProcessesWithCount()    //get the processes how run currently only ones, and with count
        {
            List<ProcessWithCount> list = new List<ProcessWithCount>();
            List<Process> processes = Process.GetProcesses().ToList();  //get the processes how currently run

            foreach (Process item in processes)     //check for every process of the list from the processes
            {
                if (ProcessNameAlreadyExist(item.ProcessName,list, out int i))  //if the process already exist -> increase ther counter of the process
                {
                    list[i].AddProcess(item);   //increase the counter and sum the some data
                }
                else   //if the process didn't exist -> add to list
                {
                    list.Add(new ProcessWithCount(item));
                }
            }          
            return list;    //return the list with the processes and how often they occor
        }

        public static string[] ProcessWithCountToStringArrray(ProcessWithCount p)   //necessary for a listview
        {
            string[] s = new string[] { p.Process.ProcessName + " (" + p.Count.ToString() + ")", p.MemoryUsageMB.ToString(), p.Process.BasePriority.ToString(), p.ThreadsOfAll.ToString()};
            return s;
        }

        private bool ProcessNameAlreadyExist(string processName, List<ProcessWithCount> list, out int listIndex) //ckeck if the process name already exist
        {
            if (list == null)   //if the list of the processes is empty -> return false
            {
                listIndex = -1;
                return false;
            }
            else    //else compere every processname from the list with the given processname
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Process.ProcessName == processName) //if the name exist -> return true and the index where the process is in the list
                    {
                        listIndex = i;
                        return true;
                    }
                }
                listIndex = -1;
                return false;   //if the name didn't exist -> return false
            }
        }

        public static int GetCurrentCPUPercentage()     //get CPU useage in int
        {        
            return Convert.ToInt32(Math.Round(cpuCounter.NextValue()));
        }

        public static int GetCurrentRAMPercentage()     //get RAM useage in int
        {
            return Convert.ToInt32(ramCounter.NextValue());
        }
        #endregion
    }
}
