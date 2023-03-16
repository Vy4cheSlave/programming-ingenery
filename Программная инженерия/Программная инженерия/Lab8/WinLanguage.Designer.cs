namespace Программная_инженерия
{
    partial class WinLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLanguage));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            commandOneToolStripMenuItem = new ToolStripMenuItem();
            commandTwoToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            resources.ApplyResources(menuToolStripMenuItem, "menuToolStripMenuItem");
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { commandOneToolStripMenuItem, commandTwoToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            // 
            // commandOneToolStripMenuItem
            // 
            resources.ApplyResources(commandOneToolStripMenuItem, "commandOneToolStripMenuItem");
            commandOneToolStripMenuItem.Name = "commandOneToolStripMenuItem";
            // 
            // commandTwoToolStripMenuItem
            // 
            resources.ApplyResources(commandTwoToolStripMenuItem, "commandTwoToolStripMenuItem");
            commandTwoToolStripMenuItem.Name = "commandTwoToolStripMenuItem";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WinLanguage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WinLanguage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem commandOneToolStripMenuItem;
        private ToolStripMenuItem commandTwoToolStripMenuItem;
        private Button button1;
    }
}