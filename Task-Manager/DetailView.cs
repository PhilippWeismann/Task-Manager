﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class DetailView : Form
    {
        public DetailView(ProcessWithCount process)
        {
            InitializeComponent();

            tbxTaskName.Text = process.Process.ProcessName;
            tbxNumberOfTasks.Text = process.Count.ToString();
            tbxID.Text = process.IdOfAll;
            tbxMemoryUseage.Text = process.MemoryUseageOfAllMB;
            tbxThreads.Text = process.ThreadsOfAll.ToString();
            tbxSumMemoryUseage.Text = process.MemoryUsageMB.ToString();
        }
    }
}
