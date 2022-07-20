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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNumberOfProcesses = new System.Windows.Forms.Label();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDetails = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // livTasks
            // 
            this.livTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTaskName,
            this.cMemory,
            this.cPriority,
            this.cThreads});
            this.livTasks.Location = new System.Drawing.Point(6, 6);
            this.livTasks.Name = "livTasks";
            this.livTasks.Size = new System.Drawing.Size(1223, 775);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1309, 917);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 46);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNumberOfProcesses
            // 
            this.lblNumberOfProcesses.AutoSize = true;
            this.lblNumberOfProcesses.Location = new System.Drawing.Point(10, 861);
            this.lblNumberOfProcesses.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumberOfProcesses.Name = "lblNumberOfProcesses";
            this.lblNumberOfProcesses.Size = new System.Drawing.Size(245, 32);
            this.lblNumberOfProcesses.TabIndex = 3;
            this.lblNumberOfProcesses.Text = "Number of Processes:";
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.SystemColors.Control;
            this.pieChart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pieChart.Location = new System.Drawing.Point(1306, 71);
            this.pieChart.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(992, 773);
            this.pieChart.TabIndex = 4;
            this.pieChart.Text = "pieChart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1276, 950);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.livTasks);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1260, 896);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1260, 896);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(1306, 851);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(5);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(171, 53);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Show details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2320, 987);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.lblNumberOfProcesses);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnUpdate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Task Viewer | © Nitsche - Weismann";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView livTasks;
        private ColumnHeader cTaskName;
        private ColumnHeader cMemory;
        private ColumnHeader cPriority;
        private System.ComponentModel.BackgroundWorker bwRefreshTasks;
        private Button btnUpdate;
        private Label lblNumberOfProcesses;
        private LiveCharts.WinForms.PieChart pieChart;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ColumnHeader cThreads;
        private Button btnDetails;
    }
}