namespace Task_Manager
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.livTasks = new System.Windows.Forms.ListView();
            this.cTaskName = new System.Windows.Forms.ColumnHeader();
            this.cMemory = new System.Windows.Forms.ColumnHeader();
            this.cPriority = new System.Windows.Forms.ColumnHeader();
            this.cThreads = new System.Windows.Forms.ColumnHeader();
            this.bwRefreshTasks = new System.ComponentModel.BackgroundWorker();
            this.lblNumberOfProcesses = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // livTasks
            // 
            this.livTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTaskName,
            this.cMemory,
            this.cPriority,
            this.cThreads});
            this.livTasks.Location = new System.Drawing.Point(16, 10);
            this.livTasks.Margin = new System.Windows.Forms.Padding(2);
            this.livTasks.Name = "livTasks";
            this.livTasks.Size = new System.Drawing.Size(959, 691);
            this.livTasks.TabIndex = 0;
            this.livTasks.UseCompatibleStateImageBehavior = false;
            this.livTasks.View = System.Windows.Forms.View.Details;
            this.livTasks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.livTasks_ColumnClick);
            // 
            // cTaskName
            // 
            this.cTaskName.Text = "Task Name";
            this.cTaskName.Width = 250;
            // 
            // cMemory
            // 
            this.cMemory.Text = "Memory Useage";
            this.cMemory.Width = 200;
            // 
            // cPriority
            // 
            this.cPriority.Text = "Priority";
            this.cPriority.Width = 100;
            // 
            // cThreads
            // 
            this.cThreads.Text = "Threads";
            this.cThreads.Width = 120;
            // 
            // bwRefreshTasks
            // 
            this.bwRefreshTasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRefreshTasks_DoWork);
            // 
            // lblNumberOfProcesses
            // 
            this.lblNumberOfProcesses.AutoSize = true;
            this.lblNumberOfProcesses.Location = new System.Drawing.Point(6, 504);
            this.lblNumberOfProcesses.Name = "lblNumberOfProcesses";
            this.lblNumberOfProcesses.Size = new System.Drawing.Size(151, 20);
            this.lblNumberOfProcesses.TabIndex = 3;
            this.lblNumberOfProcesses.Text = "Number of Processes:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 762);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.livTasks);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(982, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pieChart);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(982, 708);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Memory Useage (Piechart)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(1028, 676);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(5);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(171, 53);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Show details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1028, 737);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 46);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(8, 8);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(966, 692);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 795);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Task Viewer | © Nitsche - Weismann";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView livTasks;
        private ColumnHeader cTaskName;
        private ColumnHeader cMemory;
        private ColumnHeader cPriority;
        private System.ComponentModel.BackgroundWorker bwRefreshTasks;
        private Label lblNumberOfProcesses;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ColumnHeader cThreads;
        private Button btnDetails;
        private Button btnUpdate;
        private LiveCharts.WinForms.PieChart pieChart;
    }
}