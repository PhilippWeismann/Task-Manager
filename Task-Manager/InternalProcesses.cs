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
        //private Task _updateProcessesTask;
        //public event EventHandler<List<string[]>> ModelUpdated;

        #endregion

        #region Properties
        public List<Process> Processes
        {
            get { return _processes; }
            private set { _processes = value; }
        }
        #endregion


        #region Construktor
        public InternalProcesses()
        {
            _processes = Process.GetProcesses().ToList();
            //_updateProcessesTask = Task.CompletedTask;
        }
        #endregion


        #region Methods

        //public List<Process> GetCurrentProcesses()
        //{
        //    Processes = Process.GetProcesses().ToList();
        //    return Processes;
        //}

        public List<ProcessWithCount> GetCurrentProcessesWithCount()
        {
            List<ProcessWithCount> list = new List<ProcessWithCount>();
            List<Process> processes = Process.GetProcesses().ToList();

            foreach (Process item in processes)
            {
                if (ProcessNameAlreadyExist(item.ProcessName,list, out int i))
                {
                    list[i].IncreaseCounter();
                    list[i].SumMemory(item);
                }
                else
                {
                    list.Add(new ProcessWithCount(item));
                }
            }          

            return list;
        }

        //public static string[] ProcessToStringArrray(Process p)
        //{
            
        //    string[] s = new string[] { p.ProcessName, p.WorkingSet64.ToString(), p.BasePriority.ToString() };
        //    return s;
        //}

        public static string[] ProcessWithCountToStringArrray(ProcessWithCount p)
        {
            string[] s = new string[] { p.Process.ProcessName + " (" + p.Count.ToString() + ")", p.MemoryUseage.ToString(), p.Process.BasePriority.ToString(), p.Process.Threads.Count.ToString()};
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

        //public void RunProcessLoop(int refreshmentRate)
        //{

        //    _updateProcessesTask = Task.Factory.StartNew(() => {
        //        while (true)
        //        {
        //            List<string[]> processtrings = new List<string[]>();

        //            Processes = Process.GetProcesses().ToList();
        //            foreach (Process p in Processes)
        //            {
        //                processtrings.Add(ProcessToString(p));
        //            }

        //            ModelUpdated?.Invoke(this, processtrings);
        //            Thread.Sleep(refreshmentRate);
        //        }


        //    });


        //}
        #endregion

    }
}
