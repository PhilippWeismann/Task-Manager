using LiveCharts;
using LiveCharts.WinForms;
using System.ComponentModel;
using System.Diagnostics;

namespace Task_Manager
{
    public partial class MainView : Form
    {
        public event System.EventHandler OnUpdateTasksRequested;
        

        public MainView()
        {
            InitializeComponent();
           // bwRefreshTasks.RunWorkerAsync();
        }

        public void bwRefreshTasks_DoWork(object sender, DoWorkEventArgs e)
        {
            //OnUpdateTasksRequested?.Invoke(this, e);
        }

        //public static void listViewAddItem(ListView varListView, ListViewItem item)
        //{
        //    if (varListView.InvokeRequired)
        //    {
        //        varListView.BeginInvoke(new MethodInvoker(() => listViewAddItem(varListView, item)));
        //    }
        //    else
        //    {
        //        varListView.Items.Add(item);
        //    }
        //}

        //private delegate void ListViewHandler(ListView varListView);
        //public static void listViewClearItems(ListView varListView)
        //{
        //    if (varListView.InvokeRequired)
        //    {
        //        varListView.BeginInvoke(new ListViewHandler(listViewClearItems), new object[] { varListView });
        //    }
        //    else
        //    {
        //        varListView.Items.Clear();
        //    }
        //}


        public void UpdateListView(object sender, List<string[]> processes)
        {
            livTasks.Items.Clear();

            foreach (string[] pstring in processes)
            {
                ListViewItem itm = new ListViewItem(pstring);
                livTasks.Items.Add(itm);
            }

            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdateTasksRequested?.Invoke(this, e);
        }
    }
}