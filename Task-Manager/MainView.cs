using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.ComponentModel;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


namespace Task_Manager
{
    public partial class MainView : Form
    {
        public event EventHandler OnUpdateTasksRequested;
        public event EventHandler<ProcessWithCount> OnShowDetail;
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

        int reversecount = 0;
        bool reverse = false;



        public MainView()
        {
            InitializeComponent();
            OnUpdateTasksRequested?.Invoke(this, new EventArgs());
            gauCPU.From = 0;
            gauCPU.To = 100;

            gauRAM.From = 0;
            gauRAM.To = 100;

            btnUpdate.Visible = true;
            btnUpdate.PerformClick();
        }




        public void bwRefreshTasks_DoWork(object sender, DoWorkEventArgs e)
        {
            //OnUpdateTasksRequested?.Invoke(this, e);
        }

        public void UpdatePiechart(List<ProcessWithCount> processes)
        {
            SeriesCollection series = new SeriesCollection();
            long memoryOfOther = 0;


            SortByMemorySize smem = new SortByMemorySize();
            processes.Sort(smem);
            processes.Reverse();

            long memSizeOfFifthProcess = processes[5].MemoryUseage;

            //List

            foreach (var process in processes)
            {
                if (process.MemoryUseage > memSizeOfFifthProcess)
                {

                    PieSeries chart = new PieSeries
                    {
                        Title = process.Process.ProcessName,
                        Values = new ChartValues<long> { process.MemoryUseage },
                        PushOut = 10,
                        DataLabels = true,
                        LabelPosition = PieLabelPosition.InsideSlice,
                        LabelPoint = chartPoint => string.Format("{0} ({1:P})", process.Process.ProcessName, chartPoint.Participation)
                    };
                    series.Add(chart);
                }
                else
                {
                    memoryOfOther += process.MemoryUseage;
                }
            }

            PieSeries chartOfOther = new PieSeries
            {
                Title = "other",
                Values = new ChartValues<long> { memoryOfOther },
                PushOut = 10,
                DataLabels = true,
                LabelPosition = PieLabelPosition.InsideSlice,
                LabelPoint = chartPoint => string.Format("{0} ({1:P})", "other", chartPoint.Participation)
            };
            series.Add(chartOfOther);

            pieChart.Series = series;

        }

        public void SortProcesses (List<ProcessWithCount> processes)
        {

            if (rbTaskCount.Checked)
            {
                SortByProcessCount scount = new SortByProcessCount();
                processes.Sort(scount);
            }
            else if (rbMemory.Checked)
            {
                SortByMemorySize smem = new SortByMemorySize();
                processes.Sort(smem);
            }
            else if (rbThreads.Checked)
            {
                SortByThreads sthreads = new SortByThreads();

                processes.Sort(sthreads);
            }

            if (reverse)
            {
                processes.Reverse();
            }
        }



        public void UpdateGauges(List<ProcessWithCount> processes)
        {
            gauRAM.Value = Convert.ToInt32(ramCounter.NextValue());
            gauCPU.Value = Convert.ToInt32(Math.Round(cpuCounter.NextValue()));
        }


        public void UpdateListView(List<ProcessWithCount> processes)
        {
            livTasks.Items.Clear();

            SortProcesses(processes);

            

            foreach (ProcessWithCount process in processes)
            {
                ListViewItem item = new ListViewItem(InternalProcesses.ProcessWithCountToStringArrray(process));
                item.Tag = process;

                livTasks.Items.Add(item);
            }

            int processcounter = processes.Count;
            lblNumberOfProcesses.Text = "Number of Processes: " + processcounter.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var selected = livTasks.SelectedItems;
            if (selected.Count == 1)
            {
                var item = selected[0];
                ProcessWithCount selectedProcess = (ProcessWithCount)item.Tag;
                OnShowDetail?.Invoke(this, selectedProcess);
            }
        }

        private void btnChangeSorting_Click(object sender, EventArgs e)
        {
            if (reversecount == 0)
            {
                lblSorting.Text = "Sorting: descending";
                reverse = true;
                reversecount++;
            }
            else if (reversecount == 1)
            {
                lblSorting.Text = "Sorting: ascending";
                reverse = false;
                reversecount=0;
            }

            OnUpdateTasksRequested?.Invoke(this, e);
        }

        

        private void refreshtimer_Tick(object sender, EventArgs e)
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex!=0)
            {
                OnUpdateTasksRequested?.Invoke(this, e);
                refreshtimer.Stop();
            }
            else
            {
                refreshtimer.Start();
            }
        }

        private void rbAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            refreshtimer.Interval = 2000;
            refreshtimer.Start();

            if (rbAutomatic.Checked)
            {
                btnUpdate.Visible = false;
                OnUpdateTasksRequested?.Invoke(this, e);
                refreshtimer.Start();
            }
            else
            {
                refreshtimer.Stop();
                btnUpdate.Visible = true;
            }

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }
    }
}