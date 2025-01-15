
namespace Home_14
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void task1Lb_Click(object sender, EventArgs e)
        {
            Task_1 task_1 = new Task_1(this);
            SwapForm(task_1);
        }

        private void task1Lb_MouseHover(object sender, EventArgs e)
        {
            task1Lb.ForeColor = Color.White;
        }

        private void task1Lb_MouseLeave(object sender, EventArgs e)
        {
            task1Lb.ForeColor = Color.Green;
        }

        private void task2Lb_Click(object sender, EventArgs e)
        {
            Task_2 task_2 = new Task_2(this);
            SwapForm(task_2);

        }

        private void task2Lb_MouseHover(object sender, EventArgs e)
        {
            task2Lb.ForeColor = Color.White;
        }

        private void task2Lb_MouseLeave(object sender, EventArgs e)
        {
            task2Lb.ForeColor = Color.Green;
        }

        private void exitLb_MouseHover(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.White;
        }

        private void exitLb_MouseLeave(object sender, EventArgs e)
        {
            exitLb.ForeColor = Color.Green;
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye-Bye");
            Application.Exit();
        }

        private void SwapForm(Form form)
        {
            form.Show();
            Hide();
        }
    }
}
