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
        private Task _updateProcessesTask;
        public event EventHandler<List<string[]>> ModelUpdated;

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
            _updateProcessesTask = Task.CompletedTask;
        }
        #endregion


        #region Methods

        public List<Process> GetCurrentProcesses()
        {

            Processes = Process.GetProcesses().ToList();
            return Processes;
        }

        public string[] ProcessToString(Process p)
        {
            string[] s = new string[] { p.ToString(),p.WorkingSet64.ToString()};
            return s;
        }

        public void RunProcessLoop(int refreshmentRate)
        {

            _updateProcessesTask = Task.Factory.StartNew(() => {
                while (true)
                {
                    List<string[]> processtrings = new List<string[]>();

                    Processes = Process.GetProcesses().ToList();
                    foreach (Process p in Processes)
                    {
                        processtrings.Add(ProcessToString(p));
                    }

                    ModelUpdated?.Invoke(this, processtrings);
                    Thread.Sleep(refreshmentRate);
                }

                
            });
            

        }
        #endregion

    }
}
