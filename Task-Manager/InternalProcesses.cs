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
            _processes = Process.GetProcesses().ToList();
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        }
        #endregion

        #region Methods
        public List<ProcessWithCount> GetCurrentProcessesWithCount()
        {
            List<ProcessWithCount> list = new List<ProcessWithCount>();
            List<Process> processes = Process.GetProcesses().ToList();

            foreach (Process item in processes)
            {
                if (ProcessNameAlreadyExist(item.ProcessName,list, out int i))
                {
                    list[i].AddProcess(item);
                }
                else
                {
                    list.Add(new ProcessWithCount(item));
                }
            }          
            return list;
        }

        public static string[] ProcessWithCountToStringArrray(ProcessWithCount p)
        {
            string[] s = new string[] { p.Process.ProcessName + " (" + p.Count.ToString() + ")", p.MemoryUsageMB.ToString(), p.Process.BasePriority.ToString(), p.ThreadsOfAll.ToString()};
            return s;
        }

        private bool ProcessNameAlreadyExist(string processName, List<ProcessWithCount> list, out int listIndex)
        {
            if (list == null)
            {
                listIndex = -1;
                return false;
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Process.ProcessName == processName)
                    {
                        listIndex = i;
                        return true;
                    }
                }
                listIndex = -1;
                return false;
            }
        }

        public static int GetCurrentCPUPercentage()
        {        
            return Convert.ToInt32(Math.Round(cpuCounter.NextValue()));
        }

        public static int GetCurrentRAMPercentage()
        {
            return Convert.ToInt32(ramCounter.NextValue());
        }
        #endregion
    }
}
