using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class InternalProcesses
    {

        #region Members
        List<Process> _internalProcesses;
        #endregion

        #region Properties
        public List<Process> InternalProcesses
        {
            get { return _internalProcesses; }
        }
        #endregion


        #region Construktor
        public ProcessManager()
        {
            _internalProcesses = Process.GetProcesses().ToList();
        }
        #endregion


        #region Methods

        public void RefreshProcesses()
        {
            _internalProcesses = Process.GetProcesses().ToList();
        }

        public int ReturnActualNumberOfProcesses()
        {
            RefreshProcesses();
            return _internalProcesses.Count;
        }

        #endregion

    }
}
