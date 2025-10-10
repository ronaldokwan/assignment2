namespace assignment2
{
    public partial class logInScreen : Form
    {
        public logInScreen()
        {
            InitializeComponent();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            //temporary code to open task list form
            //fix it up later
            var taskListForm = new taskList();
            taskListForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
