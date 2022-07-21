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
using System.Windows;

namespace Task_Manager
{
    public partial class MainView : Form
    {
        public event EventHandler OnUpdateTasksRequested;
        public event EventHandler OnUpdateCpuRamRequested;
        public event EventHandler<ProcessWithCount> OnShowDetail;

        int reversecount = 0;
        bool reverse = false;

        public MainView()
        {
            InitializeComponent();
            refreshCpuRamTimer.Start();

            OnUpdateTasksRequested?.Invoke(this, new EventArgs());

            btnUpdate.Visible = true;

            #region linechart
            lncCpuRamHistory.DisableAnimations = true;
            lncCpuRamHistory.AxisY.Clear();
            lncCpuRamHistory.AxisY.Add(
            new Axis
            {
                MinValue = 0,
                MaxValue = 100,
                Title = "Percentage [%]"
            });

            lncCpuRamHistory.AxisX.Clear();
            lncCpuRamHistory.AxisX.Add(
            new Axis
            {
                MinValue = 0,
                MaxValue = 20,
                Title = "Time [s]"
            });

            lncCpuRamHistory.LegendLocation = LegendLocation.Right;
            lncCpuRamHistory.DefaultLegend.Visibility = Visibility.Visible;
            #endregion

            pieChart.LegendLocation = LegendLocation.Right;
            pieChart.DefaultLegend.Visibility = Visibility.Visible;

        }

        #region public methods
        public void UpdatePiechart(List<ProcessWithCount> processes)
        {
            SeriesCollection series = new SeriesCollection();
            double memoryOfOther = 0;

            SortByMemorySize smem = new SortByMemorySize();     //sort the processes by memory size, from largest to smallest
            processes.Sort(smem);
            processes.Reverse();

            double memSizeOfFifthProcess = processes[5].MemoryUsageMB;  //get memory size from the 6th largest

            #region largest 5 Tasks
            foreach (var process in processes)   
            {
                if (process.MemoryUsageMB > memSizeOfFifthProcess)  //if memory size is smaller than the 6th largest -> new PieSeries
                {

                    PieSeries chart = new PieSeries
                    {
                        Title = process.Process.ProcessName + " (" + process.MemoryUsageMB + " MB)",
                        Values = new ChartValues<double> { process.MemoryUsageMB },
                        PushOut = 10,
                        DataLabels = true,
                        LabelPosition = PieLabelPosition.InsideSlice,
                        LabelPoint = chartPoint => string.Format("{0} ({1:P})", process.Process.ProcessName, chartPoint.Participation)
                    };
                    series.Add(chart);
                }
                else    //if not -> sum the memory useage
                {
                    memoryOfOther += process.MemoryUsageMB;
                }
            }
            #endregion
            #region sum of other tasks
            PieSeries chartOfOther = new PieSeries      //new PieSeries with all processes from the 6th largest
            {
                Title = "other",
                Values = new ChartValues<double> { memoryOfOther },
                PushOut = 10,
                DataLabels = true,
                LabelPosition = PieLabelPosition.InsideSlice,
                LabelPoint = chartPoint => string.Format("{0} ({1:P})", "other", chartPoint.Participation)
            };
            series.Add(chartOfOther);
            #endregion

            pieChart.Series = series;   //show PieChart
        }

        public void UpdateListView(List<ProcessWithCount> processes)
        {
            livTasks.Items.Clear();

            SortProcesses(processes);            

            foreach (ProcessWithCount process in processes) //for every process in the list -> new ListViewItem = one line in the ListView
            {
                ListViewItem item = new ListViewItem(InternalProcesses.ProcessWithCountToStringArrray(process));
                item.Tag = process;

                livTasks.Items.Add(item);
            }
        }

        public void UpdateLineChart(List<List<int>> chartlist, string[] labels)
        {
            int counter = 0;
            SeriesCollection series = new SeriesCollection();

            foreach (List<int> dataset in chartlist)    //for every dataset -> new LineSerie = Line in chart
            {
                LineSeries line = new LineSeries();
                line.Values = new ChartValues<int>(dataset);
                line.Title = labels[counter];
                series.Add(line);
                counter++;
            }
                        
            lncCpuRamHistory.Series = series;   //show lines in one charts
        }
        #endregion

        #region private methods
        private void MainView_Load(object sender, EventArgs e)  //when the MainView starts 
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }

        private void SortProcesses(List<ProcessWithCount> processes)
        {
            if (rbTaskCount.Checked)    //check the ctriertia for sorting
            {
                SortByProcessCount scount = new SortByProcessCount();
                processes.Sort(scount);
            }
            else if (rbMemory.Checked)  //check the ctriertia for sorting
            {
                SortByMemorySize smem = new SortByMemorySize();
                processes.Sort(smem);
            }
            else if (rbThreads.Checked) //check the ctriertia for sorting
            {
                SortByThreads sthreads = new SortByThreads();

                processes.Sort(sthreads);
            }

            if (reverse)
            {
                processes.Reverse();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //for manual uptdating
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }

        private void btnDetails_Click(object sender, EventArgs e)   //to open the DetailView
        {
            var selected = livTasks.SelectedItems;
            if (selected.Count == 1)    //open only if only one Item in the Listview is selected
            {
                var item = selected[0];
                ProcessWithCount selectedProcess = (ProcessWithCount)item.Tag;
                OnShowDetail?.Invoke(this, selectedProcess);
            }
            else if (selected.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Please select any task in the List to get detailed Information", "No Task selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void refreshtimer_Tick(object sender, EventArgs e)  //if the refresher fires an event, fire OnUpdateTaskRe...
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)  //if user is in the first tab and in automatic mode -> start refresher
            {
                OnUpdateTasksRequested?.Invoke(this, e);
                if (rbAutomatic.Checked)
                {
                    refreshTasksTimer.Start();
                }
            }
            if (tabControl.SelectedIndex == 1)  //if user is in the second tab (PieChhart) -> stop refresher and update tasks ones
            {
                OnUpdateTasksRequested?.Invoke(this, e);
                refreshTasksTimer.Stop();
            }
            else if (tabControl.SelectedIndex == 2) //if user is in the third tab (lineChart) -> fire OnUpdateCpuRamRe.. 
            {
                OnUpdateCpuRamRequested?.Invoke(this, e);
            }
        }

        private void rbAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            refreshTasksTimer.Start();

            if (rbAutomatic.Checked)
            {
                btnUpdate.Visible = false;
                OnUpdateTasksRequested?.Invoke(this, e);
                refreshTasksTimer.Start();
                lblUpdateMode.Text = "Update-Mode: automatic";
            }
            else
            {
                refreshTasksTimer.Stop();
                btnUpdate.Visible = true;
                lblUpdateMode.Text = "Update-Mode: manual";
            }

        }

        private void refreshCpuRamTimer_Tick(object sender, EventArgs e)
        {
            OnUpdateCpuRamRequested?.Invoke(this, e);
        }

        private void rbTaskCount_Click(object sender, EventArgs e)  //for sorting
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }

        private void rbThreads_Click(object sender, EventArgs e)    //for sorting
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }

        private void rbMemory_Click(object sender, EventArgs e)     //for sorting
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }
        #endregion
    }
}