using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_14
{
    public partial class Task_1 : Form
    {
        private Menu _menu;
        public Task_1(Menu menu)
        {
            _menu = menu;
            InitializeComponent();
        }

        private void Task_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            _menu.Show();
            Hide();
        }

        private void exitLb_MouseHover(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.White;
        }

        private void exitLb_MouseLeave(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.Green;
        }

        private void calculateLb_MouseHover(object sender, EventArgs e)
        {
            calculateLb.ForeColor = Color.White;
        }

        private void calculateLb_MouseLeave(object sender, EventArgs e)
        {
            calculateLb.ForeColor = Color.Green;
        }

        private void calculateLb_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numberTB.Text);
            int power = int.Parse(powerTb.Text);

            int result = number.ToPow(power);
            resultLb.Text = result.ToString();
        }
    }
}
