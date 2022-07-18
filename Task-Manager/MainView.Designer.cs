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
            this.SuspendLayout();
            // 
            // livTasks
            // 
            this.livTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTaskName,
            this.cMemory,
            this.cPriority});
            this.livTasks.Location = new System.Drawing.Point(12, 12);
            this.livTasks.Name = "livTasks";
            this.livTasks.Size = new System.Drawing.Size(904, 358);
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
            this.btnUpdate.Location = new System.Drawing.Point(965, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 382);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.livTasks);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Task Viewer | © Nitsche - Weismann";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView livTasks;
        private ColumnHeader cTaskName;
        private ColumnHeader cMemory;
        private ColumnHeader cPriority;
        private System.ComponentModel.BackgroundWorker bwRefreshTasks;
        private Button btnUpdate;
    }
}