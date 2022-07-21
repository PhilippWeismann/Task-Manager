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
            return x.MemoryUseage.CompareTo(y.MemoryUseage);
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

        private List<Process> allProcesses = new List<Process>();
        public Process Process { get; set; }
        public int Count { get { return allProcesses.Count; } }
        public double MemoryUseage
        {
            get { return Math.Round(_memoryUsage,3); }
            set { _memoryUsage = value; }
        }
        public string MemoryUseageOfAll { get; set; }
        public string IdOfAll { get; set; }
        public int ThreadsOfAll { get; set; }

        public ProcessWithCount(Process p)
        {
            allProcesses.Add(p);
            Process = p;

            double memoryUseageMB = p.PagedMemorySize64 / 1000000.0;
            MemoryUseage = memoryUseageMB;
            MemoryUseageOfAll = memoryUseageMB.ToString();
            IdOfAll = p.Id.ToString();
            ThreadsOfAll = p.Threads.Count;
        }

        public void AddProcess(Process p)
        {
            allProcesses.Add(p);
            double memoryUseageMB = p.PagedMemorySize64 / 1000000.0;
            MemoryUseage += memoryUseageMB;
            MemoryUseageOfAll += ", " + memoryUseageMB.ToString();
            IdOfAll += ", " + p.Id.ToString();
            ThreadsOfAll += p.Threads.Count;
        }

        //public ProcessWithCount(Process p)
        //{
        //    allProcesses.Add(p);
        //    Process = p;
        //    MemoryUseage = p.PagedMemorySize64;
        //    MemoryUseageOfAll = p.PagedMemorySize64.ToString();
        //    IdOfAll = p.Id.ToString();
        //    ThreadsOfAll = p.Threads.Count;
        //}

        //public void AddProcess(Process p)
        //{
        //    allProcesses.Add(p);
        //    MemoryUseage += p.PagedMemorySize64;
        //    MemoryUseageOfAll += ", " + p.PagedMemorySize64.ToString();
        //    IdOfAll += ", " + p.Id.ToString();
        //    ThreadsOfAll += p.Threads.Count;
        //}
    }
}
