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
    public partial class Laba6StartForm : Form
    {
        public Laba6StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinPrint dial = new WinPrint();
            dial.ShowDialog();
        }
    }
}
