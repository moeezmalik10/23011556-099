using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
 public class DashboardForm : Form
 {
 public DashboardForm()
 {
 Text = "Student System by YourName";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.5);
 Height = (int)(wa.Height *0.6);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;
 FormBorderStyle = FormBorderStyle.Sizable;
 MaximizeBox = true;

 var btnAdd = new Button { Text = "Add Student", Left =20, Top =20, Width =120 };
 var btnView = new Button { Text = "View Students", Left =160, Top =20, Width =120 };
 var btnExit = new Button { Text = "Exit", Left =300, Top =20, Width =120 };

 btnAdd.Click += (s,e) => { var add = new AddStudentForm(); add.ShowDialog(); };
 btnView.Click += (s,e) => { var view = new ViewStudentsForm(); view.ShowDialog(); };
 btnExit.Click += (s,e) => this.Close();

 Controls.Add(btnAdd);
 Controls.Add(btnView);
 Controls.Add(btnExit);
 }
 }
}
