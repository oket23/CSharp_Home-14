namespace Home_14
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuLb = new Label();
            task1Lb = new Label();
            task2Lb = new Label();
            menuPanel = new Panel();
            exitLb = new Label();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuLb
            // 
            menuLb.AutoSize = true;
            menuLb.BackColor = Color.Black;
            menuLb.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuLb.ForeColor = Color.Green;
            menuLb.Location = new Point(188, 13);
            menuLb.Name = "menuLb";
            menuLb.Size = new Size(146, 81);
            menuLb.TabIndex = 0;
            menuLb.Text = "Menu";
            // 
            // task1Lb
            // 
            task1Lb.AutoSize = true;
            task1Lb.BackColor = Color.Black;
            task1Lb.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task1Lb.ForeColor = Color.Green;
            task1Lb.Location = new Point(3, 115);
            task1Lb.Name = "task1Lb";
            task1Lb.Size = new Size(226, 81);
            task1Lb.TabIndex = 1;
            task1Lb.Text = "1. Task_1";
            task1Lb.Click += task1Lb_Click;
            task1Lb.MouseLeave += task1Lb_MouseLeave;
            task1Lb.MouseHover += task1Lb_MouseHover;
            // 
            // task2Lb
            // 
            task2Lb.AutoSize = true;
            task2Lb.BackColor = Color.Black;
            task2Lb.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task2Lb.ForeColor = Color.Green;
            task2Lb.Location = new Point(3, 196);
            task2Lb.Name = "task2Lb";
            task2Lb.Size = new Size(226, 81);
            task2Lb.TabIndex = 0;
            task2Lb.Text = "2. Task_2";
            task2Lb.Click += task2Lb_Click;
            task2Lb.MouseLeave += task2Lb_MouseLeave;
            task2Lb.MouseHover += task2Lb_MouseHover;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Black;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(menuLb);
            menuPanel.Controls.Add(exitLb);
            menuPanel.Controls.Add(task2Lb);
            menuPanel.Controls.Add(task1Lb);
            menuPanel.ForeColor = Color.Black;
            menuPanel.Location = new Point(12, 12);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(513, 426);
            menuPanel.TabIndex = 0;
            // 
            // exitLb
            // 
            exitLb.AutoSize = true;
            exitLb.BackColor = Color.Black;
            exitLb.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLb.ForeColor = Color.Green;
            exitLb.Location = new Point(3, 277);
            exitLb.Name = "exitLb";
            exitLb.Size = new Size(157, 81);
            exitLb.TabIndex = 0;
            exitLb.Text = "3. Exit";
            exitLb.Click += exitLb_Click;
            exitLb.MouseLeave += exitLb_MouseLeave;
            exitLb.MouseHover += exitLb_MouseHover;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(537, 450);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home-14";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label menuLb;
        private Label task1Lb;
        private Label task2Lb;
        private Panel menuPanel;
        private Label exitLb;
    }
}
