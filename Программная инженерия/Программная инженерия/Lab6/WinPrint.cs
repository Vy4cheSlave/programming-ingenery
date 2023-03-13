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
    public partial class WinPrint : Form
    {
        string s;
        string[] strings;
        int ArrayCounter = 0;
        public WinPrint()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            //string Hello = "Hello World!";
            //e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);

            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            float MyLines = 0;
            float YPosition = 0;
            int Counter = 0;
            string CurrentLine;
            MyLines = e.MarginBounds.Height / this.Font.GetHeight(e.Graphics);
            while (Counter < MyLines && ArrayCounter <= strings.Length - 1)
            {
                CurrentLine = strings[ArrayCounter];
                YPosition = TopMargin + Counter * this.Font.GetHeight(e.Graphics);
                e.Graphics.DrawString(CurrentLine, this.Font, Brushes.Black, LeftMargin, YPosition, new StringFormat());
                Counter++;
                ArrayCounter++;
            }
            if (!(ArrayCounter >= strings.GetLength(0) - 1))
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.ShowDialog();
            Laba6Task3Form aForm = new Laba6Task3Form();
            System.Windows.Forms.DialogResult aResult;
            aForm.printPreviewControl1.Document = printDocument1;
            aResult = aForm.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult aResult;
            aResult = openFileDialog1.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                System.IO.StreamReader aReader = new System.IO.StreamReader(openFileDialog1.FileName);
                s = aReader.ReadToEnd();
                aReader.Close();
                strings = s.Split('\n');
            }
        }
    }
}
