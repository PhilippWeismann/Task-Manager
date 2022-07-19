﻿using System;
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

        public event EventHandler<List<string[]>> OnShowProcessesRequested;

        public ProcessManager(MainView mainView, InternalProcesses processes)
        {
            _processes = processes;
            _mainView = mainView;

            _mainView.OnUpdateTasksRequested += new EventHandler(OnUpdateTasksRequested);
            //_processes.ModelUpdated += new EventHandler<List<string[]>>(_mainView.UpdateListView);
            OnShowProcessesRequested+= new EventHandler<List<string[]>>(_mainView.UpdateListView);

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
            List<ProcessWithCount> updatedProcesses = _processes.GetCurrentProcessesWithCount();
            List<string[]> updatedProcessStings = new List<string[]>();

            foreach (ProcessWithCount p in updatedProcesses)
            {
                updatedProcessStings.Add(InternalProcesses.ProcessWithCountToStringArrray(p));
            }

            OnShowProcessesRequested?.Invoke(this, updatedProcessStings);
        }
        #endregion
    }
}
