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
        public Process Process { get; set; }
        public int Count { get; set; }
        public long MemoryUseage{ get; set; }

        public ProcessWithCount(Process p)
        {
            Process = p;
            Count = 1;
            MemoryUseage = p.PagedMemorySize64;
        }

        public void IncreaseCounter()
        {
            Count++;
        }
        public void SumMemory(Process currentProcess)
        {
            MemoryUseage += currentProcess.WorkingSet64;
        }
        
    }
}
