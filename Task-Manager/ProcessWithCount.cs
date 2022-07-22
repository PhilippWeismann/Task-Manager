using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    #region classes to compare
    public class SortByMemorySize : IComparer<ProcessWithCount>
    {
        public int Compare(ProcessWithCount x, ProcessWithCount y)
        {
            return x.MemoryUsageMB.CompareTo(y.MemoryUsageMB);
        }
    }

    public class SortByProcessCount : IComparer<ProcessWithCount>
    {
        public int Compare(ProcessWithCount x, ProcessWithCount y)
        {
            return x.Count.CompareTo(y.Count);
        }
    }

    public class SortByThreads : IComparer<ProcessWithCount>
    {
        public int Compare(ProcessWithCount x, ProcessWithCount y)
        {
            return x.ThreadsOfAll.CompareTo(y.ThreadsOfAll);
        }
    }
    #endregion

    public class ProcessWithCount
    {
        double _memoryUsage;
        private List<Process> _allProcesses = new List<Process>();

        #region properties
        public Process Process { get; set; }
        public int Count { get { return _allProcesses.Count; } }
        public double MemoryUsageMB
        {
            get { return Math.Round(_memoryUsage,2); }
            set { _memoryUsage = value; }
        }
        public string MemoryUseageOfAllMB { get; set; }
        public string IdOfAll { get; set; }
        public int ThreadsOfAll { get; set; }
        #endregion

        public ProcessWithCount(Process p)  //constructor
        {
            _allProcesses.Add(p);
            Process = p;

            double memoryUseageMB = p.PagedMemorySize64 / 1000000.0;
            MemoryUsageMB = memoryUseageMB;
            MemoryUseageOfAllMB = Math.Round(memoryUseageMB, 2).ToString();
            IdOfAll = p.Id.ToString();
            ThreadsOfAll = p.Threads.Count;
        }

        public void AddProcess(Process p) //if a processname is twice use this method to increase the counter and sum the data
        {
            _allProcesses.Add(p);
            double memoryUseageMB = p.PagedMemorySize64 / 1000000.0;
            MemoryUsageMB += memoryUseageMB;
            MemoryUseageOfAllMB += " ; " + Math.Round(memoryUseageMB, 2).ToString();
            IdOfAll += "; " + p.Id.ToString();
            ThreadsOfAll += p.Threads.Count;
        }
    }
}
