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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parent = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
                textBox2.Text = Convert.ToString(parent, 2);
            else if (radioButton2.Checked)
            {
                string s = "";
                while (parent > 0)
                {
                    int t = parent % 3;
                    parent /= 3;
                    s += t.ToString();
                }
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);

                textBox2.Text = new String(arr);

            }
            else if (radioButton3.Checked)
                textBox2.Text = Convert.ToString(parent, 16);

        }
    }
}
