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
    public partial class Laba3StartForm : Form
    {
        public Laba3StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinQuestion dial = new WinQuestion();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestList dial = new TestList();
            dial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab3Task3 dial = new Lab3Task3();
            dial.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WinContainer dial = new WinContainer();
            dial.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WinLinkLabel dial = new WinLinkLabel();
            dial.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrationForm dial = new RegistrationForm();
            dial.ShowDialog();
        }
    }
}
