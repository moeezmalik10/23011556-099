using System;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string ageText = textBox3.Text.Trim();
            string cls = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ageText) || string.IsNullOrEmpty(cls))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var s = new Student { Name = name, Age = age, Class = cls };
            StudentRepository.Add(s);
            MessageBox.Show("Student saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }
    }
}
