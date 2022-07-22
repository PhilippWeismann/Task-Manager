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
        public event EventHandler UpdateProcessesRequested; //event to update Processes
        public event EventHandler<int> UpdatePieChartRequested; //event to update pie-chart
        public event EventHandler UpdateCpuRamRequested; //event to update CPU/RAM graph
        public event EventHandler<ProcessWithCount> ShowDetail; //event to show DetailView-window

        bool reverse = false; //bool flag if sorting direction is reversed

        public MainView()
        {
            InitializeComponent();

            refreshCpuRamTimer.Start(); //starts timer for CPU/RAM-Graph

            UpdateProcessesRequested?.Invoke(this, new EventArgs()); //fires event to update the Process-ListView at startup

            #region linechart
            lncCpuRamHistory.DisableAnimations = true; //disables animations
            lncCpuRamHistory.AxisY.Clear();
            lncCpuRamHistory.AxisY.Add(
            new Axis //settings om y-Axis
            {
                MinValue = 0,
                MaxValue = 100,
                Title = "Percentage [%]"
            });

            lncCpuRamHistory.AxisX.Clear();
            lncCpuRamHistory.AxisX.Add(
            new Axis //settings of x-Axis
            {
                MinValue = 0,
                MaxValue = 20,
                Title = "Time [s]"
            });

            //legend settings 
            lncCpuRamHistory.LegendLocation = LegendLocation.Right;
            lncCpuRamHistory.DefaultLegend.Visibility = Visibility.Visible;
            #endregion

            
            pieChart.DisableAnimations = true; //disables animations
            //legend settings for pie-chart 
            pieChart.LegendLocation = LegendLocation.Right;
            pieChart.DefaultLegend.Visibility = Visibility.Visible;

        }

        #region public methods
        public void UpdatePiechart(List<ProcessWithCount> processes, int numberOfSlices) //method for updating the pie-chart
        {
            SeriesCollection series = new SeriesCollection(); //new SeriesCollection-Object gets initialized
            double memoryOfOther = 0; //counter for memory of remaining Processes

            SortByMemorySize smem = new SortByMemorySize(); //sorting criteria gets initialized
            processes.Sort(smem); //sorts the processes by sorting criteria (memory size)
            processes.Reverse();

            double memSizeOfFifthProcess = processes[numberOfSlices].MemoryUsageMB;  //get memory size from the process at the index of the TrackBar

            #region largest Processes
            foreach (var process in processes) //each Process gets a new "slice" of the pie chart if it belongs to the largest processes
            {
                if (process.MemoryUsageMB > memSizeOfFifthProcess)  //if the process belongs to the largest processes
                {

                    PieSeries slice = new PieSeries //new "slice" is initialized and declared
                    {
                        Title = process.Process.ProcessName + " (" + process.MemoryUsageMB + " MB)",
                        Values = new ChartValues<double> { process.MemoryUsageMB },
                        PushOut = 8,
                        DataLabels = true,
                        LabelPosition = PieLabelPosition.InsideSlice,
                        LabelPoint = chartPoint => string.Format("{0} ({1:P})", process.Process.ProcessName, chartPoint.Participation)
                    };
                    series.Add(slice); //slice is added to the pie-chart series
                }
                else    //if it does not belong to the largest processes -> sum of memory usage of remaining processes
                {
                    memoryOfOther += process.MemoryUsageMB;
                }
            }
            #endregion
            #region sum of other Processes
            PieSeries sliceOfOther = new PieSeries      //new "slice" for the remaining processes
            {
                Title = "other" + " (" + Math.Round(memoryOfOther,2) + " MB)",
                Values = new ChartValues<double> { memoryOfOther },
                PushOut = 8,
                DataLabels = true,
                LabelPosition = PieLabelPosition.InsideSlice,
                LabelPoint = chartPoint => string.Format("{0} ({1:P})", "other", chartPoint.Participation)
            };
            series.Add(sliceOfOther); //slice of remaining processes is added to the pie-chart series
            #endregion

            pieChart.Series = series;   //show PieChart
        }

        public void UpdateListView(List<ProcessWithCount> processes) //method for updating the ListView
        {
            livProcesses.Items.Clear(); //clears all items in the List View

            SortProcesses(processes); //sorts the processes (sorting criteria from MainView)     

            foreach (ProcessWithCount process in processes) //for every process in the list -> new ListViewItem = one line in the ListView
            {
                ListViewItem item = new ListViewItem(InternalProcesses.ProcessWithCountToStringArrray(process)); //new ListViewItem for each process
                item.Tag = process; //tag is used for Detail-View

                livProcesses.Items.Add(item); //item is added to the ListView
            }
        }

        public void UpdateLineChart(List<List<int>> chartlist, string[] labels) //Method for Updating the LineChart
        {
            int counter = 0; //counter for order of the labels

            SeriesCollection series = new SeriesCollection(); //new SeriesCollection-Object gets initialized

            foreach (List<int> dataset in chartlist)    //for every dataset in chartlist a new line gets declared
            {
                LineSeries line = new LineSeries(); //LineSeries gets initialized (each line is a line in the chart; one for CPU-usage and one for RAM-usage)
                line.Values = new ChartValues<int>(dataset); 
                line.Title = labels[counter]; //label of the line is labels[counter]
                series.Add(line); //each line-chart gets added to the series
                counter++;
            }
                        
            lncCpuRamHistory.Series = series;   //show all lines in one chart
        }
        #endregion

        #region private methods
        private void MainView_Load(object sender, EventArgs e)  //when the MainView is loaded then the current running Processes are shown in the ListView 
        {
            UpdateProcessesRequested?.Invoke(this, e);
        }

        private void SortProcesses(List<ProcessWithCount> processes) //method to sort the processes-List
        {
            if (rbProcessCount.Checked)    //if RadioButton for Sorting ProccesCount is checked
            {
                SortByProcessCount scount = new SortByProcessCount(); //sorting criteria (SortByProcessCount-Object) gets initialized
                processes.Sort(scount); //Processes are sorted with sorting criteria
            }
            else if (rbMemory.Checked)  //if RadioButton for Sorting MemoryUsage is checked
            {
                SortByMemorySize smem = new SortByMemorySize(); //sorting criteria (SortByProcessCount-Object) gets initialized
                processes.Sort(smem); //Processes are sorted with sorting criteria
            }
            else if (rbThreads.Checked) //if RadioButton for Sorting number of threads is checked
            {
                SortByThreads sthreads = new SortByThreads(); //sorting criteria (SortByProcessCount-Object) gets initialized
                processes.Sort(sthreads); //Processes are sorted with sorting criteria
            }
            if (reverse) //if the bool flag reverse is true -> order of list of processes is reversed
            {
                processes.Reverse();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)    //for manual uptdating
        {
            UpdateProcessesRequested?.Invoke(this, e);
        }

        private void btnDetails_Click(object sender, EventArgs e)   //to open the DetailView
        {
            var selected = livProcesses.SelectedItems; //gets the selected Item of the List view
            if (selected.Count == 1)    //open only if only one Item in the Listview is selected
            {
                var item = selected[0];
                ProcessWithCount selectedProcess = (ProcessWithCount)item.Tag; //a new ProcessWithCount gets initialized and declared with item.Tag (the selected Process)
                ShowDetail?.Invoke(this, selectedProcess); // ShowDetail event is fired
            }
            else if (selected.Count == 0) //if no process is selected -> User information (Message Box)
            {
                System.Windows.Forms.MessageBox.Show("Please select any Process in the List to get detailed Information", "No Process selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChangeSorting_Click(object sender, EventArgs e) //changes sorting direction and ´text of label
        {
            if (!reverse)
            {
                lblSorting.Text = "Sorting: descending";
                reverse = true;
            }
            else if (reverse)
            {
                lblSorting.Text = "Sorting: ascending";
                reverse = false;
            }

            UpdateProcessesRequested?.Invoke(this, e);
        }

        private void refreshProcessTimer_Tick(object sender, EventArgs e)  //if the refreshProcessTimer is running -> every 2 seconds the listView is updated
        {
            UpdateProcessesRequested?.Invoke(this, e);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) //when the selected tab changes
        {
            if (tabControl.SelectedIndex == 0)  //if the first tab is selected (Process ListView)
            {
                UpdateProcessesRequested?.Invoke(this, e); //ListView is updated
                if (rbAutomatic.Checked) //if user is in the first tab and in automatic mode is selected -> start refreshProcessTimer
                {
                    refreshProcessTimer.Start();
                }
            }
            if (tabControl.SelectedIndex == 1)  //if  the second tab is selected (PieChhart)
            {
                refreshProcessTimer.Stop(); //stops the refreshProcessTimer (ListView must not get updated because it cannot be seen)
                tbSlices.Value = 5; //TaskBar value is set to 5 (default Value)
                UpdatePieChartRequested?.Invoke(this, tbSlices.Value); //Updates the Pie Chart with the current Value of the TaskBar
            }
            else if (tabControl.SelectedIndex == 2) //if the third tab  is selected (lineChart) 
            {
                refreshProcessTimer.Stop(); //stops the refreshProcessTimer (ListView must not get updated because it cannot be seen)
            }
        }

        private void rbAutomatic_CheckedChanged(object sender, EventArgs e) 
        {
            if (rbAutomatic.Checked) //If automatic-Update is selected -> Timer is started, Label is changed and Update-Button is invisible
            {
                btnUpdate.Visible = false;
                UpdateProcessesRequested?.Invoke(this, e);
                refreshProcessTimer.Start();
                lblUpdateMode.Text = "Update-Mode: automatic";
            }
            else //manual-Update is selected -> Timer is stopped, Label is changed and Update-Button is visible
            {
                refreshProcessTimer.Stop();
                btnUpdate.Visible = true;
                lblUpdateMode.Text = "Update-Mode: manual";
            }

        }

        private void refreshCpuRamTimer_Tick(object sender, EventArgs e)
        {
            UpdateCpuRamRequested?.Invoke(this, e); //fires event to refresh the line Chart
        }

        //if any Radio button is Clicked -> List view is sorted (Event for updating ListView is fired)
        private void rbThreads_Click(object sender, EventArgs e)    //for sorting
        {
            UpdateProcessesRequested?.Invoke(this, e);
        }

        private void rbMemory_Click(object sender, EventArgs e)     //for sorting
        {
            UpdateProcessesRequested?.Invoke(this, e);
        }

        private void rbProcessCount_Click(object sender, EventArgs e)   //for sorting
        {
            UpdateProcessesRequested?.Invoke(this, e);
        }



        private void tbSlices_Scroll(object sender, EventArgs e) //If the value of the TaskBar changed the Pie chart is updated with the current value
        {
            UpdatePieChartRequested(this, tbSlices.Value);
        }



        #endregion


    }
}