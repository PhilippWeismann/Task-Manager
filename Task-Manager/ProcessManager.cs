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
        List<int> _cpuHistory;
        List<int> _ramHistory;

        //public event EventHandler<List<string[]>> OnShowProcessesAsStringsRequested;
        //public event EventHandler<List<ProcessWithCount>> OnShowProcessesForChartRequested;

        List<ProcessWithCount> updatedProcesses = new List<ProcessWithCount>();

        public ProcessManager(MainView mainView, InternalProcesses processes)
        {
            _processes = processes;
            _mainView = mainView;
            _cpuHistory = new List<int>();
            _ramHistory = new List<int>();

            _mainView.OnUpdateTasksRequested += new EventHandler(OnUpdateTasksRequested);
            _mainView.OnUpdateCpuRamRequested += new EventHandler(OnUpdateCpuRamRequested);
            _mainView.OnShowDetail += new EventHandler<ProcessWithCount>(OnShowDetailRequested);
        }

        #region ohne Count
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

        #region mit Count
        private void OnUpdateTasksRequested(object sender, EventArgs e)
        {
            updatedProcesses = _processes.GetCurrentProcessesWithCount();
            List<string[]> updatedProcessStings = new List<string[]>();

            foreach (ProcessWithCount p in updatedProcesses)
            {
                updatedProcessStings.Add(InternalProcesses.ProcessWithCountToStringArrray(p));
            }


            _mainView.UpdatePiechart(updatedProcesses);
            _mainView.UpdateListView(updatedProcesses);
        }

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
        #endregion

        private void OnShowDetailRequested(object sender, ProcessWithCount itemToShow)
        {
            var detailView = new DetailView(itemToShow);
            detailView.Show();
        }
    }
}
