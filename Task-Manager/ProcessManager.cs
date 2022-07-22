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

            _mainView.UpdateTasksRequested += new EventHandler(OnUpdateTasksRequested);
            _mainView.UpdatePieChartRequested+= new EventHandler<int>(OnUpdatePieChartRequested);
            _mainView.UpdateCpuRamRequested += new EventHandler(OnUpdateCpuRamRequested);
            _mainView.ShowDetail += new EventHandler<ProcessWithCount>(OnShowDetailRequested);
        }

        #region without Count //didn't use because we need the count the same Tasks
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
            _updatedProcesses = _processes.GetCurrentProcessesWithCount();  //get the current processes
            _mainView.UpdateListView(_updatedProcesses);    //update Listview with the current processes
        }

        private void OnUpdatePieChartRequested(object sender, int numberOfSlices)
        {
            _updatedProcesses = _processes.GetCurrentProcessesWithCount();  //get the current processes
            _mainView.UpdatePiechart(_updatedProcesses,numberOfSlices);    //update piechart with the current processes
        }
        #endregion

        private void OnUpdateCpuRamRequested(object sender, EventArgs e)
        {
            if (_cpuHistory.Count > 20)     //if the history is larger than 20 -> remove the first value
            {
                _cpuHistory.RemoveAt(0);
                _ramHistory.RemoveAt(0);
            }

            _cpuHistory.Add(InternalProcesses.GetCurrentCPUPercentage()); //Add the current CPU value
            _ramHistory.Add(InternalProcesses.GetCurrentRAMPercentage()); //Add the current RAM value

            List<List<int>> chartlist = new List<List<int>>();  //create a list with the two lists (cpuHistory and ramHistory)
            chartlist.Add(_cpuHistory);
            chartlist.Add(_ramHistory);

            string[] labels = new string[] { "CPU usage [%]", "RAM usage [%]" };    

            _mainView.UpdateLineChart(chartlist, labels); //update the linechart with the two lists and the label
        }

        private void OnShowDetailRequested(object sender, ProcessWithCount itemToShow)
        {
            var detailView = new DetailView(itemToShow);    //View
            detailView.Show();
        }
    }
}
