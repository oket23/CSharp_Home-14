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
    public partial class Task_2 : Form
    {
        private Menu _menu;
        private int[] _array;
        public Task_2(Menu menu)
        {
            _menu = menu;
            InitializeComponent();
        }

        private void Task_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitLb_Click_1(object sender, EventArgs e)
        {
            _menu.Show();
            Hide();
        }

        private void exitLb_MouseHover_1(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.White;
        }

        private void exitLb_MouseLeave_1(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.Green;
        }

        private void randomLb_MouseHover(object sender, EventArgs e)
        {
            randomLb.ForeColor = Color.White;
        }

        private void randomLb_MouseLeave(object sender, EventArgs e)
        {
            randomLb.ForeColor = Color.Green;
        }

        private void randomLb_Click(object sender, EventArgs e)
        {
            arrrayLb.Text = "Array: ";
            Random rand = new Random();
            _array = new int[10];

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(10, 101);
                arrrayLb.Text += _array[i].ToString() + " ";
            }


        }

        private void takeItemsLb_Click(object sender, EventArgs e)
        {
            newArrayLb.Text = "New array: ";
            

            try
            {
                int start = int.Parse(startTb.Text);
                int end = int.Parse(endTb.Text);

                int[] newArray = _array.TakeSome(start, end);
                newArrayLb.Text += string.Join(" ", newArray);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error start or end numbers! Try again");
            }

        }

        private void takeItemsLb_MouseHover(object sender, EventArgs e)
        {
            takeItemsLb.ForeColor = Color.White;
        }

        private void takeItemsLb_MouseLeave(object sender, EventArgs e)
        {
            takeItemsLb.ForeColor = Color.Green;
        }
    }
}
