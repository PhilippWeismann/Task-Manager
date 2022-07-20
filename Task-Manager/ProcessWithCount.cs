using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class ProcessWithCount
    {
        private List<Process> allProcesses = new List<Process>();
        public Process Process { get; set; }
        public int Count { get { return allProcesses.Count; } }
        public long MemoryUseage{ get; set; }

        public ProcessWithCount(Process p)
        {
            Process = p;
            MemoryUseage = p.PagedMemorySize64;
            allProcesses.Add(p);
        }

        public void AddProcess(Process p)
        {
            allProcesses.Add(p);
            MemoryUseage += p.WorkingSet64;
        }
        
    }
}
