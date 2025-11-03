using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    public class Program2Form : Form
    {
        public Program2Form()
        {
            Text = "Programs Dashboard";
            var wa = Screen.PrimaryScreen.WorkingArea;
            Width = (int)(wa.Width *0.5);
            Height = (int)(wa.Height *0.6);
            Left =0;
            Top = wa.Height - Height;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;

            var btnProgram2 = new Button { Text = "Program2 - Student System", Left =20, Top =20, Width =200 };
            var btnProgram3 = new Button { Text = "Program3 - Library", Left =20, Top =60, Width =200 };
            var btnProgram4 = new Button { Text = "Program4 - Calculator", Left =20, Top =100, Width =200 };

            btnProgram2.Click += (s,e) => { var d = new DashboardForm(); d.ShowDialog(); };
            btnProgram3.Click += (s,e) => { var l = new LibraryDashboardForm(); l.ShowDialog(); };
            btnProgram4.Click += (s,e) => { var c = new CalculatorForm(); c.ShowDialog(); };

            Controls.Add(btnProgram2);
            Controls.Add(btnProgram3);
            Controls.Add(btnProgram4);
        }
    }
}
