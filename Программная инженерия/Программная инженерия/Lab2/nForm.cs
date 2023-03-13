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
    public partial class nForm : Form4
    {
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Hello!!!";
            label1.Text = "Hello!!! это тупо менять текст если обрамление по наследованию отсутствует";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
        }
    }
}
