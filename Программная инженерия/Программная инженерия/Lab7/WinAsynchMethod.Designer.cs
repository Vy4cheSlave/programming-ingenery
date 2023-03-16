namespace Программная_инженерия
{
    partial class WinAsynchMethod
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
            components = new System.ComponentModel.Container();
            btnRun = new Button();
            btnWork = new Button();
            lblA = new Label();
            lblB = new Label();
            txbA = new TextBox();
            txbB = new TextBox();
            helpProvider1 = new HelpProvider();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnRun
            // 
            helpProvider1.SetHelpString(btnRun, "Sum");
            btnRun.Location = new Point(16, 64);
            btnRun.Name = "btnRun";
            helpProvider1.SetShowHelp(btnRun, true);
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 0;
            btnRun.Text = "Сумма";
            toolTip1.SetToolTip(btnRun, "Sum");
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnWork
            // 
            helpProvider1.SetHelpString(btnWork, "Start work");
            btnWork.Location = new Point(120, 128);
            btnWork.Name = "btnWork";
            helpProvider1.SetShowHelp(btnWork, true);
            btnWork.Size = new Size(94, 29);
            btnWork.TabIndex = 1;
            btnWork.Text = "Работа";
            toolTip1.SetToolTip(btnWork, "Start work");
            btnWork.UseVisualStyleBackColor = true;
            btnWork.Click += btnWork_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(8, 24);
            lblA.Name = "lblA";
            lblA.Size = new Size(94, 20);
            lblA.TabIndex = 2;
            lblA.Text = "Значение  А";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(216, 24);
            lblB.Name = "lblB";
            lblB.Size = new Size(89, 20);
            lblB.TabIndex = 3;
            lblB.Text = "Значение В";
            // 
            // txbA
            // 
            helpProvider1.SetHelpString(txbA, "For input integer A");
            txbA.Location = new Point(88, 24);
            txbA.Name = "txbA";
            helpProvider1.SetShowHelp(txbA, true);
            txbA.Size = new Size(125, 27);
            txbA.TabIndex = 4;
            toolTip1.SetToolTip(txbA, "For input integer A");
            txbA.TextChanged += txbA_TextChanged;
            // 
            // txbB
            // 
            helpProvider1.SetHelpString(txbB, "For input integer B");
            txbB.Location = new Point(296, 24);
            txbB.Name = "txbB";
            helpProvider1.SetShowHelp(txbB, true);
            txbB.Size = new Size(125, 27);
            txbB.TabIndex = 5;
            toolTip1.SetToolTip(txbB, "For input integer B");
            txbB.TextChanged += txbB_TextChanged;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "C:\\Users\\ADMIN\\Desktop\\Программная инженерия\\Программная инженерия\\Программная инженерия\\Lab8task2.txt";
            // 
            // button1
            // 
            button1.Location = new Point(8, 128);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WinAsynchMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 153);
            Controls.Add(button1);
            Controls.Add(txbB);
            Controls.Add(txbA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(btnWork);
            Controls.Add(btnRun);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WinAsynchMethod";
            helpProvider1.SetShowHelp(this, true);
            Text = "Асинхронный запуск";
            Load += WinAsynchMethod_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Button btnWork;
        private Label lblA;
        private Label lblB;
        private TextBox txbA;
        private TextBox txbB;
        private HelpProvider helpProvider1;
        private Button button1;
        private ToolTip toolTip1;
    }
}