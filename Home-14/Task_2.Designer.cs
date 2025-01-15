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
            SuspendLayout();
            // 
            // exitLb
            // 
            exitLb.AutoSize = true;
            exitLb.BackColor = Color.Black;
            exitLb.Font = new Font("Dubai", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLb.ForeColor = Color.Green;
            exitLb.Location = new Point(12, 360);
            exitLb.Name = "exitLb";
            exitLb.Size = new Size(302, 81);
            exitLb.TabIndex = 2;
            exitLb.Text = "Back to menu";
            exitLb.Click += exitLb_Click_1;
            exitLb.MouseLeave += exitLb_MouseLeave_1;
            exitLb.MouseHover += exitLb_MouseHover_1;
            // 
            // Task_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(exitLb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Task_2";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_14";
            FormClosed += Task_2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exitLb;
    }
}