namespace Программная_инженерия
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dial = new Form2();
            dial.ShowDialog();  
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для перевода чисел из двоичной CC в " +
                "восьмеричную, десятичную и шестнадцатиричную.Создатель: указать ФИО.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}