using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Laba3StartForm dial = new Laba3StartForm();
            dial.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 dial = new Form1();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Laba2SttartForm dial = new Laba2SttartForm();
            dial.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Laba4StartForm dial = new Laba4StartForm();
            dial.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Laba5StartForm dial = new Laba5StartForm();
            dial.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Laba6StartForm dial = new Laba6StartForm();
            dial.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Laba7StartForm dial = new Laba7StartForm();
            dial.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Laba8StartForm dial = new Laba8StartForm();
            dial.ShowDialog();
        }
    }
}
