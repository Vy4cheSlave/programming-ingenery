namespace Программная_инженерия
{
    partial class TestStandartDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            цветФонаToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, форматToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cохранитьКакToolStripMenuItem, открытьToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(59, 24);
            toolStripMenuItem1.Text = "Файл";
            // 
            // cохранитьКакToolStripMenuItem
            // 
            cохранитьКакToolStripMenuItem.Name = "cохранитьКакToolStripMenuItem";
            cохранитьКакToolStripMenuItem.Size = new Size(224, 26);
            cохранитьКакToolStripMenuItem.Text = "Cохранить как...";
            cохранитьКакToolStripMenuItem.Click += cохранитьКакToolStripMenuItem_Click;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветФонаToolStripMenuItem, шрифтToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(77, 24);
            форматToolStripMenuItem.Text = "Формат";
            // 
            // цветФонаToolStripMenuItem
            // 
            цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            цветФонаToolStripMenuItem.Size = new Size(224, 26);
            цветФонаToolStripMenuItem.Text = "Цвет фона";
            цветФонаToolStripMenuItem.Click += цветФонаToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(224, 26);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 422);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(224, 26);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TestStandartDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TestStandartDialog";
            Text = "TestStandartDialog";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem cохранитьКакToolStripMenuItem;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem цветФонаToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
    }
}