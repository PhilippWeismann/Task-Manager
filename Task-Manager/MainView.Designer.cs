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
            this.livProcesses = new System.Windows.Forms.ListView();
            this.cProcessName = new System.Windows.Forms.ColumnHeader();
            this.cMemory = new System.Windows.Forms.ColumnHeader();
            this.cPriority = new System.Windows.Forms.ColumnHeader();
            this.cThreads = new System.Windows.Forms.ColumnHeader();
            this.lblNumberOfProcesses = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUpdateMode = new System.Windows.Forms.Label();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbAutomatic = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSorting = new System.Windows.Forms.Label();
            this.rbMemory = new System.Windows.Forms.RadioButton();
            this.rbThreads = new System.Windows.Forms.RadioButton();
            this.rbProcessCount = new System.Windows.Forms.RadioButton();
            this.btnChangeSorting = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.tbSlices = new System.Windows.Forms.TrackBar();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lncCpuRamHistory = new LiveCharts.WinForms.CartesianChart();
            this.refreshProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshCpuRamTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlices)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // livProcesses
            // 
            this.livProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cProcessName,
            this.cMemory,
            this.cPriority,
            this.cThreads});
            this.livProcesses.Location = new System.Drawing.Point(4, 6);
            this.livProcesses.Margin = new System.Windows.Forms.Padding(1);
            this.livProcesses.MultiSelect = false;
            this.livProcesses.Name = "livProcesses";
            this.livProcesses.Size = new System.Drawing.Size(680, 433);
            this.livProcesses.TabIndex = 0;
            this.livProcesses.UseCompatibleStateImageBehavior = false;
            this.livProcesses.View = System.Windows.Forms.View.Details;
            // 
            // cProcessName
            // 
            this.cProcessName.Text = "Process Name";
            this.cProcessName.Width = 275;
            // 
            // cMemory
            // 
            this.cMemory.Text = "Memory Useage [MB]";
            this.cMemory.Width = 180;
            // 
            // cPriority
            // 
            this.cPriority.Text = "Priority";
            this.cPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cPriority.Width = 100;
            // 
            // cThreads
            // 
            this.cThreads.Text = "Threads";
            this.cThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cThreads.Width = 100;
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
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(957, 476);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.livProcesses);
            this.tabPage1.Controls.Add(this.btnDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Processes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUpdateMode);
            this.groupBox2.Controls.Add(this.rbManual);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.rbAutomatic);
            this.groupBox2.Location = new System.Drawing.Point(701, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 149);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lblUpdateMode
            // 
            this.lblUpdateMode.AutoSize = true;
            this.lblUpdateMode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUpdateMode.Location = new System.Drawing.Point(6, 17);
            this.lblUpdateMode.Name = "lblUpdateMode";
            this.lblUpdateMode.Size = new System.Drawing.Size(191, 25);
            this.lblUpdateMode.TabIndex = 6;
            this.lblUpdateMode.Text = "Update-Mode: manual";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(6, 75);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(79, 24);
            this.rbManual.TabIndex = 8;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 33);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbAutomatic
            // 
            this.rbAutomatic.AutoSize = true;
            this.rbAutomatic.Location = new System.Drawing.Point(6, 45);
            this.rbAutomatic.Name = "rbAutomatic";
            this.rbAutomatic.Size = new System.Drawing.Size(183, 24);
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
            this.groupBox1.Controls.Add(this.rbProcessCount);
            this.groupBox1.Controls.Add(this.btnChangeSorting);
            this.groupBox1.Location = new System.Drawing.Point(701, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 195);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSorting.Location = new System.Drawing.Point(6, 23);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(158, 25);
            this.lblSorting.TabIndex = 2;
            this.lblSorting.Text = "Sorting: ascending";
            // 
            // rbMemory
            // 
            this.rbMemory.AutoSize = true;
            this.rbMemory.Location = new System.Drawing.Point(16, 111);
            this.rbMemory.Name = "rbMemory";
            this.rbMemory.Size = new System.Drawing.Size(130, 24);
            this.rbMemory.TabIndex = 1;
            this.rbMemory.Text = "Memory Usage";
            this.rbMemory.UseVisualStyleBackColor = true;
            this.rbMemory.Click += new System.EventHandler(this.rbMemory_Click);
            // 
            // rbThreads
            // 
            this.rbThreads.AutoSize = true;
            this.rbThreads.Location = new System.Drawing.Point(16, 81);
            this.rbThreads.Name = "rbThreads";
            this.rbThreads.Size = new System.Drawing.Size(82, 24);
            this.rbThreads.TabIndex = 3;
            this.rbThreads.Text = "Threads";
            this.rbThreads.UseVisualStyleBackColor = true;
            this.rbThreads.Click += new System.EventHandler(this.rbThreads_Click);
            // 
            // rbProcessCount
            // 
            this.rbProcessCount.AutoSize = true;
            this.rbProcessCount.Checked = true;
            this.rbProcessCount.Location = new System.Drawing.Point(16, 51);
            this.rbProcessCount.Name = "rbProcessCount";
            this.rbProcessCount.Size = new System.Drawing.Size(122, 24);
            this.rbProcessCount.TabIndex = 4;
            this.rbProcessCount.TabStop = true;
            this.rbProcessCount.Text = "Process Count";
            this.rbProcessCount.UseVisualStyleBackColor = true;
            this.rbProcessCount.Click += new System.EventHandler(this.rbProcessCount_Click);
            // 
            // btnChangeSorting
            // 
            this.btnChangeSorting.Location = new System.Drawing.Point(16, 141);
            this.btnChangeSorting.Name = "btnChangeSorting";
            this.btnChangeSorting.Size = new System.Drawing.Size(181, 33);
            this.btnChangeSorting.TabIndex = 5;
            this.btnChangeSorting.Text = "ascending / descending";
            this.btnChangeSorting.UseVisualStyleBackColor = true;
            this.btnChangeSorting.Click += new System.EventHandler(this.btnChangeSorting_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(701, 395);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(236, 33);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Show details of Process";
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSize);
            this.tabPage2.Controls.Add(this.lblmax);
            this.tabPage2.Controls.Add(this.lblmin);
            this.tabPage2.Controls.Add(this.tbSlices);
            this.tabPage2.Controls.Add(this.pieChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Memory Useage ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(478, 381);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(180, 20);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Number of showed Slices:";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(895, 417);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(25, 20);
            this.lblmax.TabIndex = 3;
            this.lblmax.Text = "13";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(664, 417);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(17, 20);
            this.lblmin.TabIndex = 2;
            this.lblmin.Text = "1";
            // 
            // tbSlices
            // 
            this.tbSlices.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSlices.Location = new System.Drawing.Point(664, 381);
            this.tbSlices.Maximum = 13;
            this.tbSlices.Minimum = 1;
            this.tbSlices.Name = "tbSlices";
            this.tbSlices.Size = new System.Drawing.Size(256, 56);
            this.tbSlices.TabIndex = 1;
            this.tbSlices.Value = 5;
            this.tbSlices.Scroll += new System.EventHandler(this.tbSlices_Scroll);
            // 
            // pieChart
            // 
            this.pieChart.Location = new System.Drawing.Point(5, 5);
            this.pieChart.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(925, 361);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblInfo);
            this.tabPage3.Controls.Add(this.lncCpuRamHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(949, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CPU / RAM useage history";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(5, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(383, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Chart shows the CPU / RAM usage of the last 20 seconds:";
            // 
            // lncCpuRamHistory
            // 
            this.lncCpuRamHistory.Location = new System.Drawing.Point(2, 44);
            this.lncCpuRamHistory.Margin = new System.Windows.Forms.Padding(2);
            this.lncCpuRamHistory.Name = "lncCpuRamHistory";
            this.lncCpuRamHistory.Size = new System.Drawing.Size(943, 395);
            this.lncCpuRamHistory.TabIndex = 0;
            this.lncCpuRamHistory.Text = "cartesianChart1";
            // 
            // refreshProcessTimer
            // 
            this.refreshProcessTimer.Interval = 2000;
            this.refreshProcessTimer.Tick += new System.EventHandler(this.refreshProcessTimer_Tick);
            // 
            // refreshCpuRamTimer
            // 
            this.refreshCpuRamTimer.Interval = 1000;
            this.refreshCpuRamTimer.Tick += new System.EventHandler(this.refreshCpuRamTimer_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 497);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainView";
            this.Text = "Process Viewer | © Nitsche - Weismann";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlices)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView livProcesses;
        private ColumnHeader cProcessName;
        private ColumnHeader cMemory;
        private ColumnHeader cPriority;
        private Label lblNumberOfProcesses;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ColumnHeader cThreads;
        private Button btnDetails;
        private LiveCharts.WinForms.PieChart pieChart;
        private Button btnChangeSorting;
        private RadioButton rbProcessCount;
        private RadioButton rbThreads;
        private Label lblSorting;
        private RadioButton rbMemory;
        private System.Windows.Forms.Timer refreshProcessTimer;
        private RadioButton rbAutomatic;
        private Button btnUpdate;
        private GroupBox groupBox2;
        private Label lblUpdateMode;
        private RadioButton rbManual;
        private GroupBox groupBox1;
        private TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart lncCpuRamHistory;
        private System.Windows.Forms.Timer refreshCpuRamTimer;
        private Label lblInfo;
        private Label lblmin;
        private TrackBar tbSlices;
        private Label lblSize;
        private Label lblmax;
    }
}