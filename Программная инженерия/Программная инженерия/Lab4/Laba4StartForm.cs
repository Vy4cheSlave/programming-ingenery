﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Программная_инженерия
{
    public partial class Laba4StartForm : Form
    {
        public Laba4StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinTimer1 dial = new WinTimer1();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinTimer2 dial = new WinTimer2();
            dial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WinButNum dial = new WinButNum();
            dial.ShowDialog();
        }
    }
}
