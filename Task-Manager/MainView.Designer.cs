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
            this.bwRefreshTasks = new System.ComponentModel.BackgroundWorker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNumberOfProcesses = new System.Windows.Forms.Label();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // livTasks
            // 
            this.livTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTaskName,
            this.cMemory,
            this.cPriority});
            this.livTasks.Location = new System.Drawing.Point(20, 19);
            this.livTasks.Margin = new System.Windows.Forms.Padding(5);
            this.livTasks.Name = "livTasks";
            this.livTasks.Size = new System.Drawing.Size(794, 956);
            this.livTasks.TabIndex = 0;
            this.livTasks.UseCompatibleStateImageBehavior = false;
            this.livTasks.View = System.Windows.Forms.View.Details;
            // 
            // cTaskName
            // 
            this.cTaskName.Text = "Task Name";
            this.cTaskName.Width = 200;
            // 
            // cMemory
            // 
            this.cMemory.Text = "Memory Useage";
            this.cMemory.Width = 125;
            // 
            // cPriority
            // 
            this.cPriority.Text = "Priority";
            // 
            // bwRefreshTasks
            // 
            this.bwRefreshTasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRefreshTasks_DoWork);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(861, 929);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 46);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNumberOfProcesses
            // 
            this.lblNumberOfProcesses.AutoSize = true;
            this.lblNumberOfProcesses.Location = new System.Drawing.Point(861, 43);
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
            this.pieChart.Location = new System.Drawing.Point(861, 100);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(867, 790);
            this.pieChart.TabIndex = 4;
            this.pieChart.Text = "pieChart1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 989);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.lblNumberOfProcesses);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.livTasks);
            this.Name = "MainView";
            this.Text = "Task Viewer | © Nitsche - Weismann";
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
    }
}