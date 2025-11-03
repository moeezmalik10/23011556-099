namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string password = textBox2.Text;
            if (userName == "admin" && password == "1234")
            {
                using (var home = new Form2(userName))
                {
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
