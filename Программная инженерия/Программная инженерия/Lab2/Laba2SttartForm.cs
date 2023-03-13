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
    public partial class Laba2SttartForm : Form
    {
        public Laba2SttartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 dial = new Form3();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 dial = new Form4();
            dial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nForm dial = new nForm();
            dial.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MdiAplication dial = new MdiAplication();
            dial.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 dial = new Form5();
            dial.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 dial = new Form6();
            dial.ShowDialog();
        }
    }
}
