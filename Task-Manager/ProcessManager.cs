using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    internal class ProcessManager
    {
        InternalProcesses _processes;
        MainView _mainView;

        public ProcessManager(MainView mainView, InternalProcesses processes)
        {
            _processes = processes;
            _mainView = mainView;

            
            _processes.ModelUpdated += new EventHandler<List<string[]>>(_mainView.UpdateListView);

        }

        private void OnUpdateTasksRequested(object sender, EventArgs e)
        {
            _processes.GetCurrentProcesses();
        }

    }
}
