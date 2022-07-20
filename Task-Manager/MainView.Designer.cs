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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnChangeSorting = new System.Windows.Forms.Button();
            this.rbTaskCount = new System.Windows.Forms.RadioButton();
            this.rbThreads = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMemory = new System.Windows.Forms.RadioButton();
            this.btnDetails = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gauRAM = new LiveCharts.WinForms.SolidGauge();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.gauCPU = new LiveCharts.WinForms.SolidGauge();
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
            this.livTasks.Location = new System.Drawing.Point(10, 6);
            this.livTasks.Margin = new System.Windows.Forms.Padding(1);
            this.livTasks.Name = "livTasks";
            this.livTasks.Size = new System.Drawing.Size(680, 433);
            this.livTasks.TabIndex = 0;
            this.livTasks.UseCompatibleStateImageBehavior = false;
            this.livTasks.View = System.Windows.Forms.View.Details;
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 476);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnChangeSorting);
            this.tabPage1.Controls.Add(this.rbTaskCount);
            this.tabPage1.Controls.Add(this.rbThreads);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbMemory);
            this.tabPage1.Controls.Add(this.livTasks);
            this.tabPage1.Controls.Add(this.btnDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(739, 386);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnChangeSorting
            // 
            this.btnChangeSorting.Location = new System.Drawing.Point(739, 124);
            this.btnChangeSorting.Name = "btnChangeSorting";
            this.btnChangeSorting.Size = new System.Drawing.Size(130, 53);
            this.btnChangeSorting.TabIndex = 5;
            this.btnChangeSorting.Text = "Up / Down";
            this.btnChangeSorting.UseVisualStyleBackColor = true;
            this.btnChangeSorting.Click += new System.EventHandler(this.btnChangeSorting_Click);
            // 
            // rbTaskCount
            // 
            this.rbTaskCount.AutoSize = true;
            this.rbTaskCount.Checked = true;
            this.rbTaskCount.Location = new System.Drawing.Point(739, 34);
            this.rbTaskCount.Name = "rbTaskCount";
            this.rbTaskCount.Size = new System.Drawing.Size(100, 24);
            this.rbTaskCount.TabIndex = 4;
            this.rbTaskCount.TabStop = true;
            this.rbTaskCount.Text = "Task Count";
            this.rbTaskCount.UseVisualStyleBackColor = true;
            // 
            // rbThreads
            // 
            this.rbThreads.AutoSize = true;
            this.rbThreads.Location = new System.Drawing.Point(739, 64);
            this.rbThreads.Name = "rbThreads";
            this.rbThreads.Size = new System.Drawing.Size(82, 24);
            this.rbThreads.TabIndex = 3;
            this.rbThreads.Text = "Threads";
            this.rbThreads.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(739, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sorting:";
            // 
            // rbMemory
            // 
            this.rbMemory.AutoSize = true;
            this.rbMemory.Location = new System.Drawing.Point(739, 94);
            this.rbMemory.Name = "rbMemory";
            this.rbMemory.Size = new System.Drawing.Size(130, 24);
            this.rbMemory.TabIndex = 1;
            this.rbMemory.Text = "Memory Usage";
            this.rbMemory.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(739, 266);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(130, 33);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Show details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gauRAM);
            this.tabPage2.Controls.Add(this.pieChart);
            this.tabPage2.Controls.Add(this.gauCPU);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Memory Useage (Piechart)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gauRAM
            // 
            this.gauRAM.Location = new System.Drawing.Point(701, 149);
            this.gauRAM.Margin = new System.Windows.Forms.Padding(10);
            this.gauRAM.Name = "gauRAM";
            this.gauRAM.Size = new System.Drawing.Size(105, 123);
            this.gauRAM.TabIndex = 7;
            this.gauRAM.Text = "RAM - Usage";
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(5, 5);
            this.pieChart.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(594, 432);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            // 
            // gauCPU
            // 
            this.gauCPU.Location = new System.Drawing.Point(692, 21);
            this.gauCPU.Name = "gauCPU";
            this.gauCPU.Size = new System.Drawing.Size(114, 115);
            this.gauCPU.TabIndex = 7;
            this.gauCPU.Text = "CPU - Usage";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 490);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainView";
            this.Text = "Task Viewer | © Nitsche - Weismann";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private LiveCharts.WinForms.SolidGauge gauCPU;
        private LiveCharts.WinForms.SolidGauge gauRAM;
        private Button btnChangeSorting;
        private RadioButton rbTaskCount;
        private RadioButton rbThreads;
        private Label label1;
        private RadioButton rbMemory;
    }
}