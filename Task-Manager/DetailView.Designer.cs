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
            this.label4 = new System.Windows.Forms.Label();
            this.tbxStartTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.label3.Location = new System.Drawing.Point(37, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(85, 131);
            this.tbxID.Name = "tbxID";
            this.tbxID.ReadOnly = true;
            this.tbxID.Size = new System.Drawing.Size(613, 39);
            this.tbxID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Starttime:";
            // 
            // tbxStartTime
            // 
            this.tbxStartTime.Location = new System.Drawing.Point(158, 181);
            this.tbxStartTime.Name = "tbxStartTime";
            this.tbxStartTime.ReadOnly = true;
            this.tbxStartTime.Size = new System.Drawing.Size(540, 39);
            this.tbxStartTime.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total processor time:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(421, 39);
            this.textBox1.TabIndex = 9;
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 311);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxStartTime);
            this.Controls.Add(this.label4);
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
        private Label label4;
        private TextBox tbxStartTime;
        private Label label5;
        private TextBox textBox1;
    }
}