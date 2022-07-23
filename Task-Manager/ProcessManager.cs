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
        ProcessList _processes;   //Model
        List<int> _cpuHistory;  //Model
        List<int> _ramHistory;  //Model
        List<ProcessWithCount> _updatedProcesses;  //Model

        MainView _mainView; //View

        public ProcessManager(MainView mainView, ProcessList processes)   //Konstructor
        {
            _processes = processes; 
            _mainView = mainView; //member _mainView gets the value of parameter mainView

            //initialisation of CPU-history and RAM-history List
            _cpuHistory = new List<int>();
            _ramHistory = new List<int>();


            //event connections
            _mainView.UpdateProcessesRequested += new EventHandler(OnUpdateTasksRequested);
            _mainView.UpdatePieChartRequested+= new EventHandler<int>(OnUpdatePieChartRequested);
            _mainView.UpdateCpuRamRequested += new EventHandler(OnUpdateCpuRamRequested);
            _mainView.ShowDetail += new EventHandler<ProcessWithCount>(OnShowDetailRequested);
        }

        #region Event-Methods
        private void OnUpdateTasksRequested(object sender, EventArgs e)
        {
            _updatedProcesses = _processes.CurrentProcesses;  //get the current processes
            _mainView.UpdateListView(_updatedProcesses);    //update Listview with the current processes
        }

        private void OnUpdatePieChartRequested(object sender, int numberOfSlices)
        {
            _updatedProcesses = _processes.CurrentProcesses;  //get the current processes
            _mainView.UpdatePiechart(_updatedProcesses, numberOfSlices);    //update piechart with the current processes
        }

        private void OnUpdateCpuRamRequested(object sender, EventArgs e)
        {
            if (_cpuHistory.Count > 20)     //if the history is larger than 20 -> remove the first value
            {
                _cpuHistory.RemoveAt(0);
                _ramHistory.RemoveAt(0);
            }

            _cpuHistory.Add(CpuRamPerformance.GetCurrentCPUPercentage()); //Add the current CPU value
            _ramHistory.Add(CpuRamPerformance.GetCurrentRAMPercentage()); //Add the current RAM value

            List<List<int>> chartlist = new List<List<int>>();  //create a list with the two lists (cpuHistory and ramHistory)
            chartlist.Add(_cpuHistory);
            chartlist.Add(_ramHistory);

            string[] labels = new string[] { "CPU usage [%]", "RAM usage [%]" }; //create an array with the labels

            _mainView.UpdateLineChart(chartlist, labels); //update the linechart with the two charts (CPU-history and RAM-History) and the labels
        }

        private void OnShowDetailRequested(object sender, ProcessWithCount itemToShow) //Initializes a new DetailView-Object with the chosen Process in the ListView
        {
            var detailView = new DetailView(itemToShow);    //View
            detailView.Show(); //Shows the Detail-View
        }
        #endregion

    }
}
