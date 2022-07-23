using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class ProcessList
    {
        private List<ProcessWithCount> _currentProcesses = new List<ProcessWithCount>();

        public List<ProcessWithCount> CurrentProcesses
        { 
            get 
            {
                _currentProcesses = GetCurrentProcessListWithCount();
                return _currentProcesses;
            }

            set { }
        }

        private List<ProcessWithCount> GetCurrentProcessListWithCount()    //get the processes how run currently only ones, and with count
        {
            List<ProcessWithCount> list = new List<ProcessWithCount>();
            List<Process> processes = Process.GetProcesses().ToList();  //get the processes how currently run

            foreach (Process item in processes)     //check for every process of the list from the processes
            {
                if (ProcessNameAlreadyExist(item.ProcessName, list, out int i))  //if the process already exist -> increase ther counter of the process
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


    }

    #region classes to compare
    public class SortByMemorySize : IComparer<ProcessWithCount> //to compare the MemoryUsage of two processes
    {
        public int Compare(ProcessWithCount x, ProcessWithCount y)
        {
            return x.MemoryUsageMB.CompareTo(y.MemoryUsageMB);
        }
    }

    public class SortByProcessCount : IComparer<ProcessWithCount> //to compare the Process-Count of two processes
    {
        public int Compare(ProcessWithCount x, ProcessWithCount y)
        {
            return x.Count.CompareTo(y.Count);
        }
    }

    public class SortByThreads : IComparer<ProcessWithCount> //to compare the number of threads of two processes
    {
        public int Compare(ProcessWithCount x, ProcessWithCount y)
        {
            return x.ThreadsOfAll.CompareTo(y.ThreadsOfAll);
        }
    }
    #endregion


    public class ProcessWithCount
    {
        #region Members
        double _memoryUsage; // necsessary for individual getter at property
        private List<Process> _allProcessesWithSameName = new List<Process>();
        #endregion


        #region properties
        public Process Process { get; set; }
        public int Count { get { return _allProcessesWithSameName.Count; } }
        public double MemoryUsageMB
        {
            get { return Math.Round(_memoryUsage, 2); }
            set { _memoryUsage = value; }
        }
        public string MemoryUseageOfAllMB { get; set; }
        public string IdOfAll { get; set; }
        public int ThreadsOfAll { get; set; }
        #endregion

        public ProcessWithCount(Process p)  //constructor
        {
            _allProcessesWithSameName.Add(p);
            Process = p;

            double memoryUseageMB = p.PrivateMemorySize64 / 1048576.0;
            MemoryUsageMB = memoryUseageMB;
            MemoryUseageOfAllMB = Math.Round(memoryUseageMB, 2).ToString();
            IdOfAll = p.Id.ToString();
            ThreadsOfAll = p.Threads.Count;
        }

        public void AddProcess(Process p) //if a processname is twice -> this method is used to increase the counter and sum the data
        {
            _allProcessesWithSameName.Add(p);
            double memoryUseageMB = p.PrivateMemorySize64 / 1048576.0;
            MemoryUsageMB += memoryUseageMB;
            MemoryUseageOfAllMB += " / " + Math.Round(memoryUseageMB, 2).ToString();
            IdOfAll += " / " + p.Id.ToString();
            ThreadsOfAll += p.Threads.Count;
        }

        public static string[] ProcessWithCountToStringArrray(ProcessWithCount p)   //necessary for a listview
        {
            string[] s = new string[] { p.Process.ProcessName + " (" + p.Count.ToString() + ")", p.MemoryUsageMB.ToString(), p.Process.BasePriority.ToString(), p.ThreadsOfAll.ToString() };
            return s;
        }
    }
}
