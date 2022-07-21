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
            this.components = new System.ComponentModel.Container();
            this.livTasks = new System.Windows.Forms.ListView();
            this.cTaskName = new System.Windows.Forms.ColumnHeader();
            this.cMemory = new System.Windows.Forms.ColumnHeader();
            this.cPriority = new System.Windows.Forms.ColumnHeader();
            this.cThreads = new System.Windows.Forms.ColumnHeader();
            this.bwRefreshTasks = new System.ComponentModel.BackgroundWorker();
            this.lblNumberOfProcesses = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUpdateMode = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbAutomatic = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSorting = new System.Windows.Forms.Label();
            this.rbMemory = new System.Windows.Forms.RadioButton();
            this.rbThreads = new System.Windows.Forms.RadioButton();
            this.rbTaskCount = new System.Windows.Forms.RadioButton();
            this.btnChangeSorting = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gauRAM = new LiveCharts.WinForms.SolidGauge();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.gauCPU = new LiveCharts.WinForms.SolidGauge();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lncCpuHistory = new LiveCharts.WinForms.CartesianChart();
            this.refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // livTasks
            // 
            this.livTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTaskName,
            this.cMemory,
            this.cPriority,
            this.cThreads});
            this.livTasks.Location = new System.Drawing.Point(6, 10);
            this.livTasks.Margin = new System.Windows.Forms.Padding(2);
            this.livTasks.Name = "livTasks";
            this.livTasks.Size = new System.Drawing.Size(1102, 690);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(20, 19);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1555, 762);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.livTasks);
            this.tabPage1.Controls.Add(this.btnDetails);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1539, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUpdateMode);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.rbAutomatic);
            this.groupBox2.Location = new System.Drawing.Point(1139, 331);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(393, 238);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lblUpdateMode
            // 
            this.lblUpdateMode.AutoSize = true;
            this.lblUpdateMode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUpdateMode.Location = new System.Drawing.Point(10, 27);
            this.lblUpdateMode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdateMode.Name = "lblUpdateMode";
            this.lblUpdateMode.Size = new System.Drawing.Size(308, 40);
            this.lblUpdateMode.TabIndex = 6;
            this.lblUpdateMode.Text = "Update-Mode: manual";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 120);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 36);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "manual";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(26, 168);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(211, 53);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbAutomatic
            // 
            this.rbAutomatic.AutoSize = true;
            this.rbAutomatic.Location = new System.Drawing.Point(10, 72);
            this.rbAutomatic.Margin = new System.Windows.Forms.Padding(5);
            this.rbAutomatic.Name = "rbAutomatic";
            this.rbAutomatic.Size = new System.Drawing.Size(291, 36);
            this.rbAutomatic.TabIndex = 8;
            this.rbAutomatic.Text = "automatic (every 2 sec)";
            this.rbAutomatic.UseVisualStyleBackColor = true;
            this.rbAutomatic.CheckedChanged += new System.EventHandler(this.rbAutomatic_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSorting);
            this.groupBox1.Controls.Add(this.rbMemory);
            this.groupBox1.Controls.Add(this.rbThreads);
            this.groupBox1.Controls.Add(this.rbTaskCount);
            this.groupBox1.Controls.Add(this.btnChangeSorting);
            this.groupBox1.Location = new System.Drawing.Point(1139, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(393, 312);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSorting.Location = new System.Drawing.Point(10, 37);
            this.lblSorting.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(255, 40);
            this.lblSorting.TabIndex = 2;
            this.lblSorting.Text = "Sorting: ascending";
            // 
            // rbMemory
            // 
            this.rbMemory.AutoSize = true;
            this.rbMemory.Location = new System.Drawing.Point(26, 178);
            this.rbMemory.Margin = new System.Windows.Forms.Padding(5);
            this.rbMemory.Name = "rbMemory";
            this.rbMemory.Size = new System.Drawing.Size(207, 36);
            this.rbMemory.TabIndex = 1;
            this.rbMemory.Text = "Memory Usage";
            this.rbMemory.UseVisualStyleBackColor = true;
            // 
            // rbThreads
            // 
            this.rbThreads.AutoSize = true;
            this.rbThreads.Location = new System.Drawing.Point(26, 130);
            this.rbThreads.Margin = new System.Windows.Forms.Padding(5);
            this.rbThreads.Name = "rbThreads";
            this.rbThreads.Size = new System.Drawing.Size(129, 36);
            this.rbThreads.TabIndex = 3;
            this.rbThreads.Text = "Threads";
            this.rbThreads.UseVisualStyleBackColor = true;
            // 
            // rbTaskCount
            // 
            this.rbTaskCount.AutoSize = true;
            this.rbTaskCount.Checked = true;
            this.rbTaskCount.Location = new System.Drawing.Point(26, 82);
            this.rbTaskCount.Margin = new System.Windows.Forms.Padding(5);
            this.rbTaskCount.Name = "rbTaskCount";
            this.rbTaskCount.Size = new System.Drawing.Size(161, 36);
            this.rbTaskCount.TabIndex = 4;
            this.rbTaskCount.TabStop = true;
            this.rbTaskCount.Text = "Task Count";
            this.rbTaskCount.UseVisualStyleBackColor = true;
            // 
            // btnChangeSorting
            // 
            this.btnChangeSorting.Location = new System.Drawing.Point(26, 226);
            this.btnChangeSorting.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangeSorting.Name = "btnChangeSorting";
            this.btnChangeSorting.Size = new System.Drawing.Size(211, 53);
            this.btnChangeSorting.TabIndex = 5;
            this.btnChangeSorting.Text = "Up / Down";
            this.btnChangeSorting.UseVisualStyleBackColor = true;
            this.btnChangeSorting.Click += new System.EventHandler(this.btnChangeSorting_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(1165, 646);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(5);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(211, 53);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Show details";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.gauRAM);
            this.tabPage2.Controls.Add(this.pieChart);
            this.tabPage2.Controls.Add(this.gauCPU);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1539, 708);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Memory Useage (Piechart), CPU/RAM utilization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1184, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1184, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPU";
            // 
            // gauRAM
            // 
            this.gauRAM.Location = new System.Drawing.Point(1124, 384);
            this.gauRAM.Margin = new System.Windows.Forms.Padding(16);
            this.gauRAM.Name = "gauRAM";
            this.gauRAM.Size = new System.Drawing.Size(185, 197);
            this.gauRAM.TabIndex = 7;
            this.gauRAM.Text = "RAM - Usage";
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(8, 8);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(965, 691);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            this.pieChart.DisableAnimations = true;
            // 
            // gauCPU
            // 
            this.gauCPU.Location = new System.Drawing.Point(1124, 127);
            this.gauCPU.Margin = new System.Windows.Forms.Padding(5);
            this.gauCPU.Name = "gauCPU";
            this.gauCPU.Size = new System.Drawing.Size(185, 184);
            this.gauCPU.TabIndex = 7;
            this.gauCPU.Text = "CPU - Usage";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lncCpuHistory);
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1539, 708);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CPU useage history";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lncCpuHistory
            // 
            this.lncCpuHistory.Location = new System.Drawing.Point(3, 6);
            this.lncCpuHistory.Name = "lncCpuHistory";
            this.lncCpuHistory.Size = new System.Drawing.Size(1530, 696);
            this.lncCpuHistory.TabIndex = 0;
            this.lncCpuHistory.Text = "cartesianChart1";
            this.lncCpuHistory.DisableAnimations = true;
            // 
            // refreshtimer
            // 
            this.refreshtimer.Interval = 2000;
            this.refreshtimer.Tick += new System.EventHandler(this.refreshtimer_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 795);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Task Viewer | © Nitsche - Weismann";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView livTasks;
        private ColumnHeader cTaskName;
        private ColumnHeader cMemory;
        private ColumnHeader cPriority;
        private System.ComponentModel.BackgroundWorker bwRefreshTasks;
        private Label lblNumberOfProcesses;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ColumnHeader cThreads;
        private Button btnDetails;
        private LiveCharts.WinForms.PieChart pieChart;
        private LiveCharts.WinForms.SolidGauge gauCPU;
        private LiveCharts.WinForms.SolidGauge gauRAM;
        private Button btnChangeSorting;
        private RadioButton rbTaskCount;
        private RadioButton rbThreads;
        private Label lblSorting;
        private RadioButton rbMemory;
        private System.Windows.Forms.Timer refreshtimer;
        private RadioButton rbAutomatic;
        private Button btnUpdate;
        private GroupBox groupBox2;
        private Label lblUpdateMode;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart lncCpuHistory;
    }
}