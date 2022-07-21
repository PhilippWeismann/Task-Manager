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
        InternalProcesses _processes;   //Model
        List<int> _cpuHistory;  //Model
        List<int> _ramHistory;  //Model
        List<ProcessWithCount> _updatedProcesses;  //Model

        MainView _mainView; //View

        public ProcessManager(MainView mainView, InternalProcesses processes)   //Presenter
        {
            _processes = processes;
            _mainView = mainView;
            _cpuHistory = new List<int>();
            _ramHistory = new List<int>();

            _mainView.OnUpdateTasksRequested += new EventHandler(OnUpdateTasksRequested);
            _mainView.OnUpdateCpuRamRequested += new EventHandler(OnUpdateCpuRamRequested);
            _mainView.OnShowDetail += new EventHandler<ProcessWithCount>(OnShowDetailRequested);
        }

        #region without Count //didn't use because we need the count by same Tasks
        //private void OnUpdateTasksRequested(object sender, EventArgs e)
        //{
        //    List<Process> updatedProcesses = _processes.GetCurrentProcesses();
        //    List<string[]> updatedProcessStings = new List<string[]>();

        //    foreach (Process p in updatedProcesses)
        //    {
        //        updatedProcessStings.Add(InternalProcesses.ProcessToStringArrray(p));
        //    }

        //    OnShowProcessesRequested?.Invoke(this, updatedProcessStings);
        //}
        #endregion

        #region with Count
        private void OnUpdateTasksRequested(object sender, EventArgs e)
        {
            _updatedProcesses = _processes.GetCurrentProcessesWithCount();

            _mainView.UpdatePiechart(_updatedProcesses);
            _mainView.UpdateListView(_updatedProcesses);
        }
        #endregion

        private void OnUpdateCpuRamRequested(object sender, EventArgs e)
        {
            if (_cpuHistory.Count > 20)
            {
                _cpuHistory.RemoveAt(0);
                _ramHistory.RemoveAt(0);
            }

            _cpuHistory.Add(InternalProcesses.GetCurrentCPUPercentage());
            _ramHistory.Add(InternalProcesses.GetCurrentRAMPercentage());

            List<List<int>> chartlist = new List<List<int>>();
            chartlist.Add(_cpuHistory);
            chartlist.Add(_ramHistory);

            string[] labels = new string[] { "CPU usage [%]", "RAM usage [%]" };

            _mainView.UpdateLineChart(chartlist, labels);
        }

        private void OnShowDetailRequested(object sender, ProcessWithCount itemToShow)
        {
            var detailView = new DetailView(itemToShow);
            detailView.Show();
        }
    }
}
