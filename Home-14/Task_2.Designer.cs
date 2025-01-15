namespace Home_14
{
    partial class Task_2
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
            exitLb = new Label();
            menuPanel = new Panel();
            endTb = new TextBox();
            startTb = new TextBox();
            task2Lb = new Label();
            takeItemsLb = new Label();
            randomLb = new Label();
            newArrayLb = new Label();
            arrrayLb = new Label();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // exitLb
            // 
            exitLb.AutoSize = true;
            exitLb.BackColor = Color.Black;
            exitLb.Font = new Font("Dubai", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLb.ForeColor = Color.Green;
            exitLb.Location = new Point(-1, 368);
            exitLb.Name = "exitLb";
            exitLb.Size = new Size(219, 60);
            exitLb.TabIndex = 2;
            exitLb.Text = "Back to menu";
            exitLb.Click += exitLb_Click_1;
            exitLb.MouseLeave += exitLb_MouseLeave_1;
            exitLb.MouseHover += exitLb_MouseHover_1;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Black;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(endTb);
            menuPanel.Controls.Add(startTb);
            menuPanel.Controls.Add(task2Lb);
            menuPanel.Controls.Add(takeItemsLb);
            menuPanel.Controls.Add(randomLb);
            menuPanel.Controls.Add(newArrayLb);
            menuPanel.Controls.Add(arrrayLb);
            menuPanel.Controls.Add(exitLb);
            menuPanel.ForeColor = Color.Black;
            menuPanel.Location = new Point(12, 12);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(598, 426);
            menuPanel.TabIndex = 3;
            // 
            // endTb
            // 
            endTb.BackColor = Color.Black;
            endTb.BorderStyle = BorderStyle.None;
            endTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endTb.ForeColor = Color.Green;
            endTb.Location = new Point(102, 236);
            endTb.Name = "endTb";
            endTb.PlaceholderText = "End";
            endTb.Size = new Size(89, 32);
            endTb.TabIndex = 3;
            endTb.TextAlign = HorizontalAlignment.Center;
            // 
            // startTb
            // 
            startTb.BackColor = Color.Black;
            startTb.BorderStyle = BorderStyle.None;
            startTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startTb.ForeColor = Color.Green;
            startTb.Location = new Point(7, 236);
            startTb.Name = "startTb";
            startTb.PlaceholderText = "Start";
            startTb.Size = new Size(89, 32);
            startTb.TabIndex = 3;
            startTb.TextAlign = HorizontalAlignment.Center;
            // 
            // task2Lb
            // 
            task2Lb.AutoSize = true;
            task2Lb.BackColor = Color.Black;
            task2Lb.Font = new Font("Dubai", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task2Lb.ForeColor = Color.Green;
            task2Lb.Location = new Point(239, 15);
            task2Lb.Name = "task2Lb";
            task2Lb.Size = new Size(109, 54);
            task2Lb.TabIndex = 1;
            task2Lb.Text = "Task 2";
            // 
            // takeItemsLb
            // 
            takeItemsLb.AutoSize = true;
            takeItemsLb.BackColor = Color.Black;
            takeItemsLb.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            takeItemsLb.ForeColor = Color.Green;
            takeItemsLb.Location = new Point(197, 229);
            takeItemsLb.Name = "takeItemsLb";
            takeItemsLb.Size = new Size(151, 49);
            takeItemsLb.TabIndex = 2;
            takeItemsLb.Text = "Take items";
            takeItemsLb.Click += takeItemsLb_Click;
            takeItemsLb.MouseLeave += takeItemsLb_MouseLeave;
            takeItemsLb.MouseHover += takeItemsLb_MouseHover;
            // 
            // randomLb
            // 
            randomLb.AutoSize = true;
            randomLb.BackColor = Color.Black;
            randomLb.Font = new Font("Dubai", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            randomLb.ForeColor = Color.Green;
            randomLb.Location = new Point(456, 99);
            randomLb.Name = "randomLb";
            randomLb.Size = new Size(137, 49);
            randomLb.TabIndex = 2;
            randomLb.Text = "Rand new";
            randomLb.Click += randomLb_Click;
            randomLb.MouseLeave += randomLb_MouseLeave;
            randomLb.MouseHover += randomLb_MouseHover;
            // 
            // newArrayLb
            // 
            newArrayLb.AutoSize = true;
            newArrayLb.BackColor = Color.Black;
            newArrayLb.Font = new Font("Dubai", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newArrayLb.ForeColor = Color.Green;
            newArrayLb.Location = new Point(-1, 168);
            newArrayLb.Name = "newArrayLb";
            newArrayLb.Size = new Size(145, 45);
            newArrayLb.TabIndex = 2;
            newArrayLb.Text = "New array: ";
            // 
            // arrrayLb
            // 
            arrrayLb.AutoSize = true;
            arrrayLb.BackColor = Color.Black;
            arrrayLb.Font = new Font("Dubai", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            arrrayLb.ForeColor = Color.Green;
            arrrayLb.Location = new Point(3, 103);
            arrrayLb.Name = "arrrayLb";
            arrrayLb.Size = new Size(93, 45);
            arrrayLb.TabIndex = 2;
            arrrayLb.Text = "Array: ";
            // 
            // Task_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(622, 450);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Task_2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_14";
            FormClosed += Task_2_FormClosed;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label exitLb;
        private Panel menuPanel;
        private Label task2Lb;
        private Label arrrayLb;
        private Label randomLb;
        private TextBox endTb;
        private TextBox startTb;
        private Label takeItemsLb;
        private Label newArrayLb;
    }
}