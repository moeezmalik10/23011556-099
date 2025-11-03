using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
 public class MainMenuForm : Form
 {
 private string _username;
 private Label lblWelcome;
 private Button btnProfile;
 private Button btnSettings;
 private Button btnLogout;
 private Button btnPrograms;

 public MainMenuForm(string username)
 {
 _username = username;
 InitializeComponents();
 }

 private void InitializeComponents()
 {
 Text = "Home Page";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.5);
 Height = (int)(wa.Height *0.6);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;
 FormBorderStyle = FormBorderStyle.Sizable;
 MaximizeBox = true;
 BackColor = Color.LightBlue;

 lblWelcome = new Label { Text = $"Welcome, {_username}!", Left =20, Top =20, Width =350, Font = new Font(FontFamily.GenericSansSerif,12, FontStyle.Bold) };

 btnProfile = new Button { Text = "Profile", Left =20, Top =60, Width =100 };
 btnSettings = new Button { Text = "Settings", Left =140, Top =60, Width =100 };
 btnPrograms = new Button { Text = "Programs", Left =20, Top =100, Width =100 };
 btnLogout = new Button { Text = "Logout", Left =260, Top =60, Width =100 };

 btnProfile.Click += BtnProfile_Click;
 btnSettings.Click += BtnSettings_Click;
 btnPrograms.Click += BtnPrograms_Click;
 btnLogout.Click += BtnLogout_Click;

 Controls.Add(lblWelcome);
 Controls.Add(btnProfile);
 Controls.Add(btnSettings);
 Controls.Add(btnPrograms);
 Controls.Add(btnLogout);
 }

 private void BtnProfile_Click(object? sender, EventArgs e)
 {
 MessageBox.Show("Profile page not implemented. This can navigate to another form.", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }

 private void BtnSettings_Click(object? sender, EventArgs e)
 {
 MessageBox.Show("Settings page not implemented.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }

 private void BtnPrograms_Click(object? sender, EventArgs e)
 {
 var prog = new Program2Form();
 prog.ShowDialog();
 }

 private void BtnLogout_Click(object? sender, EventArgs e)
 {
 this.Close();
 }
 }
}
