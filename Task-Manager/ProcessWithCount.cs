using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
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

    public class ProcessWithCount
    {
        double _memoryUsage;
        private List<Process> _allProcesses = new List<Process>();

        #region properties
        public Process Process { get; set; }
        public int Count { get { return _allProcesses.Count; } }
        public double MemoryUsageMB
        {
            get { return Math.Round(_memoryUsage,3); }
            set { _memoryUsage = value; }
        }
        public string MemoryUseageOfAllMB { get; set; }
        public string IdOfAll { get; set; }
        public int ThreadsOfAll { get; set; }
        #endregion

        public ProcessWithCount(Process p)
        {
            _allProcesses.Add(p);
            Process = p;

            double memoryUseageMB = p.PagedMemorySize64 / 1000000.0;
            MemoryUsageMB = memoryUseageMB;
            MemoryUseageOfAllMB = memoryUseageMB.ToString();
            IdOfAll = p.Id.ToString();
            ThreadsOfAll = p.Threads.Count;
        }

        public void AddProcess(Process p)
        {
            _allProcesses.Add(p);
            double memoryUseageMB = p.PagedMemorySize64 / 1000000.0;
            MemoryUsageMB += memoryUseageMB;
            MemoryUseageOfAllMB += "; " + memoryUseageMB.ToString();
            IdOfAll += "; " + p.Id.ToString();
            ThreadsOfAll += p.Threads.Count;
        }
    }
}
