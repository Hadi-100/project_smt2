namespace project_smt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.Show();

            this.Hide();
        }
    }
}
