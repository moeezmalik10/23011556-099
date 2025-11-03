using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form2 : Form
    {
        private string _username = string.Empty;

        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button3.Click += Button3_Click;
        }

        public Form2(string username) : this()
        {
            _username = username;
            label1.Text = $"Welcome {_username}";
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Profile {_username}", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
