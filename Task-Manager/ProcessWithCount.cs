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
        public string MemoryUseageOfAll { get; set; }
        public string IdOfAll { get; set; }

        public ProcessWithCount(Process p)
        {
            allProcesses.Add(p);
            Process = p;
            MemoryUseage = p.PagedMemorySize64;
            MemoryUseageOfAll = p.PagedMemorySize64.ToString();
            IdOfAll = p.Id.ToString();
        }

        public void AddProcess(Process p)
        {
            allProcesses.Add(p);
            MemoryUseage += p.PagedMemorySize64;
            MemoryUseageOfAll += ", " + p.PagedMemorySize64.ToString();
            IdOfAll += ", " + p.Id.ToString();
        }        
    }
}
