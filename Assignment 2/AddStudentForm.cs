using System;
using System.Windows.Forms;

namespace Assignment2
{
 public class AddStudentForm : Form
 {
 private TextBox txtName;
 private TextBox txtAge;
 private TextBox txtClass;
 private Button btnSave;

 public AddStudentForm()
 {
 Text = "Add Student";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.4);
 Height = (int)(wa.Height *0.35);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;
 FormBorderStyle = FormBorderStyle.Sizable;
 MaximizeBox = true;

 var lblName = new Label { Text = "Name:", Left =10, Top =20, Width =80 };
 txtName = new TextBox { Left =100, Top =18, Width =200 };
 var lblAge = new Label { Text = "Age:", Left =10, Top =60, Width =80 };
 txtAge = new TextBox { Left =100, Top =58, Width =200 };
 var lblClass = new Label { Text = "Class:", Left =10, Top =100, Width =80 };
 txtClass = new TextBox { Left =100, Top =98, Width =200 };
 btnSave = new Button { Text = "Save", Left =100, Top =140, Width =100 };
 btnSave.Click += BtnSave_Click;

 Controls.Add(lblName);
 Controls.Add(txtName);
 Controls.Add(lblAge);
 Controls.Add(txtAge);
 Controls.Add(lblClass);
 Controls.Add(txtClass);
 Controls.Add(btnSave);
 }

 private void BtnSave_Click(object? sender, EventArgs e)
 {
 if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Name required"); return; }
 if (!int.TryParse(txtAge.Text, out var age)) { MessageBox.Show("Age must be a number"); return; }
 var s = new Student { Name = txtName.Text.Trim(), Age = age, Class = txtClass.Text.Trim() };
 StudentStore.Add(s);
 MessageBox.Show("Student saved");
 this.Close();
 }
 }
}
