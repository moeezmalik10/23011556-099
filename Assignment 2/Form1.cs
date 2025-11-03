using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUser;
        private Label lblPass;

        public Form1()
        {
            InitializeComponent();

            Text = "Login";
            var wa = Screen.PrimaryScreen.WorkingArea;
            Width = (int)(wa.Width *0.5);
            Height = (int)(wa.Height *0.4);
            Left =0;
            Top = wa.Height - Height;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.Sizable;

            lblUser = new Label { Text = "Username:", Left =20, Top =20, Width =80 };
            txtUsername = new TextBox { Left =110, Top =18, Width =200 };

            lblPass = new Label { Text = "Password:", Left =20, Top =60, Width =80 };
            txtPassword = new TextBox { Left =110, Top =58, Width =200, UseSystemPasswordChar = true };

            btnLogin = new Button { Text = "Login", Left =110, Top =100, Width =100 };
            btnLogin.Click += BtnLogin_Click;

            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;

            if (user == "admin" && pass == "1234")
            {
                var menu = new MainMenuForm(user);
                menu.FormClosed += (s, args) => this.Show();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
