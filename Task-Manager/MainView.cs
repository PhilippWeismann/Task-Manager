using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.ComponentModel;
using System.Diagnostics;

namespace Task_Manager
{
    public partial class MainView : Form
    {
        public event EventHandler OnUpdateTasksRequested;
        public event EventHandler<ProcessWithCount> OnShowDetail;

        public MainView()
        {
            InitializeComponent();
            // bwRefreshTasks.RunWorkerAsync();
        }

        public void bwRefreshTasks_DoWork(object sender, DoWorkEventArgs e)
        {
            //OnUpdateTasksRequested?.Invoke(this, e);
        }

        public void UpdatePiechart(object sender, List<ProcessWithCount> processes)
        {
            SeriesCollection series = new SeriesCollection();
            long memoryOfOther = 0;

            //List

            foreach (var process in processes)
            {
                if (process.MemoryUseage > 100000000)
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


        public void UpdateListView(object sender, List<string[]> processes)
        {
            livTasks.Items.Clear();

            foreach (string[] pstring in processes)
            {
                ListViewItem itm = new ListViewItem(pstring);
                livTasks.Items.Add(itm);
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

        private void livTasks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int columnindex = e.Column;

            //livTasks.Columns[columnindex].Width == 0;
            

        }
    }
}