using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class ProcessWithCount
    {
        public Process Process { get; set; }
        public int Count { get; set; }

        public ProcessWithCount(Process p)
        {
            Process = p;
            Count = 1;
        }

        public void IncreaseCounter()
        {
            Count++;
        }
    }
}
