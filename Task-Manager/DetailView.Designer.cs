namespace Task_Manager
{
    partial class DetailView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTaskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNumberOfTasks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMemoryUseage = new System.Windows.Forms.TextBox();
            this.tbxThreads = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task name:";
            // 
            // tbxTaskName
            // 
            this.tbxTaskName.Location = new System.Drawing.Point(173, 31);
            this.tbxTaskName.Name = "tbxTaskName";
            this.tbxTaskName.ReadOnly = true;
            this.tbxTaskName.Size = new System.Drawing.Size(525, 39);
            this.tbxTaskName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many tasks with this name:";
            // 
            // tbxNumberOfTasks
            // 
            this.tbxNumberOfTasks.Location = new System.Drawing.Point(399, 80);
            this.tbxNumberOfTasks.Name = "tbxNumberOfTasks";
            this.tbxNumberOfTasks.ReadOnly = true;
            this.tbxNumberOfTasks.Size = new System.Drawing.Size(299, 39);
            this.tbxNumberOfTasks.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(85, 182);
            this.tbxID.Name = "tbxID";
            this.tbxID.ReadOnly = true;
            this.tbxID.Size = new System.Drawing.Size(613, 39);
            this.tbxID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Memory Useage:";
            // 
            // tbxMemoryUseage
            // 
            this.tbxMemoryUseage.Location = new System.Drawing.Point(237, 237);
            this.tbxMemoryUseage.Name = "tbxMemoryUseage";
            this.tbxMemoryUseage.ReadOnly = true;
            this.tbxMemoryUseage.Size = new System.Drawing.Size(461, 39);
            this.tbxMemoryUseage.TabIndex = 11;
            // 
            // tbxThreads
            // 
            this.tbxThreads.Location = new System.Drawing.Point(230, 134);
            this.tbxThreads.Name = "tbxThreads";
            this.tbxThreads.ReadOnly = true;
            this.tbxThreads.Size = new System.Drawing.Size(468, 39);
            this.tbxThreads.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sum of Threads:";
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 293);
            this.Controls.Add(this.tbxThreads);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMemoryUseage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNumberOfTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTaskName);
            this.Controls.Add(this.label1);
            this.Name = "DetailView";
            this.Text = "DetailView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbxTaskName;
        private Label label2;
        private TextBox tbxNumberOfTasks;
        private Label label3;
        private TextBox tbxID;
        private Label label6;
        private TextBox tbxMemoryUseage;
        private TextBox tbxThreads;
        private Label label4;
    }
}