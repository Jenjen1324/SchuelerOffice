﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchülerOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkUtils mu = new MarkUtils();
            mu.ShowDialog();
        }
    }
}
