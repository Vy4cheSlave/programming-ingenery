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
    public partial class Laba8StartForm : Form
    {
        public Laba8StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinAsynchMethod dial = new WinAsynchMethod();
            dial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinLanguage dial = new WinLanguage();
            dial.ShowDialog();
        }
    }
}
