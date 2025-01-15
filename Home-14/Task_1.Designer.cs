namespace Home_14
{
    partial class Task_1
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
            powerTb = new TextBox();
            numberTB = new TextBox();
            resultLb = new Label();
            equalLb = new Label();
            task1LB = new Label();
            calculateLb = new Label();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // exitLb
            // 
            exitLb.AutoSize = true;
            exitLb.BackColor = Color.Black;
            exitLb.Font = new Font("Dubai", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLb.ForeColor = Color.Green;
            exitLb.Location = new Point(3, 370);
            exitLb.Name = "exitLb";
            exitLb.Size = new Size(201, 54);
            exitLb.TabIndex = 1;
            exitLb.Text = "Back to menu";
            exitLb.Click += exitLb_Click;
            exitLb.MouseLeave += exitLb_MouseLeave;
            exitLb.MouseHover += exitLb_MouseHover;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Black;
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(powerTb);
            menuPanel.Controls.Add(numberTB);
            menuPanel.Controls.Add(resultLb);
            menuPanel.Controls.Add(equalLb);
            menuPanel.Controls.Add(task1LB);
            menuPanel.Controls.Add(calculateLb);
            menuPanel.Controls.Add(exitLb);
            menuPanel.ForeColor = Color.Black;
            menuPanel.Location = new Point(12, 12);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(400, 426);
            menuPanel.TabIndex = 2;
            // 
            // powerTb
            // 
            powerTb.BackColor = Color.Black;
            powerTb.BorderStyle = BorderStyle.None;
            powerTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            powerTb.ForeColor = Color.Green;
            powerTb.Location = new Point(134, 129);
            powerTb.Name = "powerTb";
            powerTb.PlaceholderText = "Power";
            powerTb.Size = new Size(89, 32);
            powerTb.TabIndex = 2;
            powerTb.TextAlign = HorizontalAlignment.Center;
            // 
            // numberTB
            // 
            numberTB.BackColor = Color.Black;
            numberTB.BorderStyle = BorderStyle.None;
            numberTB.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberTB.ForeColor = Color.Green;
            numberTB.Location = new Point(52, 155);
            numberTB.Name = "numberTB";
            numberTB.PlaceholderText = "Number";
            numberTB.Size = new Size(116, 39);
            numberTB.TabIndex = 2;
            numberTB.TextAlign = HorizontalAlignment.Right;
            // 
            // resultLb
            // 
            resultLb.AutoSize = true;
            resultLb.BackColor = Color.Black;
            resultLb.Font = new Font("Dubai", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLb.ForeColor = Color.Green;
            resultLb.Location = new Point(213, 151);
            resultLb.Name = "resultLb";
            resultLb.Size = new Size(57, 54);
            resultLb.TabIndex = 1;
            resultLb.Text = "12";
            // 
            // equalLb
            // 
            equalLb.AutoSize = true;
            equalLb.BackColor = Color.Black;
            equalLb.Font = new Font("Dubai", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equalLb.ForeColor = Color.Green;
            equalLb.Location = new Point(183, 151);
            equalLb.Name = "equalLb";
            equalLb.Size = new Size(40, 54);
            equalLb.TabIndex = 1;
            equalLb.Text = "=";
            equalLb.MouseHover += exitLb_MouseHover;
            // 
            // task1LB
            // 
            task1LB.AutoSize = true;
            task1LB.BackColor = Color.Black;
            task1LB.Font = new Font("Dubai", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task1LB.ForeColor = Color.Green;
            task1LB.Location = new Point(147, 16);
            task1LB.Name = "task1LB";
            task1LB.Size = new Size(109, 54);
            task1LB.TabIndex = 1;
            task1LB.Text = "Task 1";
            // 
            // calculateLb
            // 
            calculateLb.AutoSize = true;
            calculateLb.BackColor = Color.Black;
            calculateLb.Font = new Font("Dubai", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculateLb.ForeColor = Color.Green;
            calculateLb.Location = new Point(115, 214);
            calculateLb.Name = "calculateLb";
            calculateLb.Size = new Size(141, 54);
            calculateLb.TabIndex = 1;
            calculateLb.Text = "Calculate";
            calculateLb.Click += calculateLb_Click;
            calculateLb.MouseLeave += calculateLb_MouseLeave;
            calculateLb.MouseHover += calculateLb_MouseHover;
            // 
            // Task_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(422, 450);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Task_1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_14";
            FormClosed += Task_1_FormClosed;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label exitLb;
        private Panel menuPanel;
        private TextBox numberTB;
        private TextBox powerTb;
        private Label resultLb;
        private Label equalLb;
        private Label task1LB;
        private Label calculateLb;
    }
}