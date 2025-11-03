using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
 public class CalculatorForm : Form
 {
 private TextBox txtA;
 private TextBox txtB;
 private List<string> history = new List<string>();
 public CalculatorForm()
 {
 Text = "Calculator - YourName"; // originality: show name
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.5);
 Height = (int)(wa.Height *0.45);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;

 var lblA = new Label { Text = "A:", Left =10, Top =20, Width =20 };
 txtA = new TextBox { Left =40, Top =18, Width =120 };
 var lblB = new Label { Text = "B:", Left =180, Top =20, Width =20 };
 txtB = new TextBox { Left =210, Top =18, Width =120 };

 var btnAdd = new Button { Text = "Add", Left =40, Top =60, Width =80 };
 var btnSub = new Button { Text = "Subtract", Left =140, Top =60, Width =80 };
 var btnMul = new Button { Text = "Multiply", Left =240, Top =60, Width =80 };
 var btnDiv = new Button { Text = "Divide", Left =40, Top =100, Width =80 };
 var btnHist = new Button { Text = "Show History", Left =140, Top =100, Width =120 };

 btnAdd.Click += (s,e) => DoOp((a,b) => a+b, "+");
 btnSub.Click += (s,e) => DoOp((a,b) => a-b, "-");
 btnMul.Click += (s,e) => DoOp((a,b) => a*b, "*");
 btnDiv.Click += (s,e) => DoOp((a,b) => a/b, "/");
 btnHist.Click += (s,e) => { var h = new HistoryForm(history); h.ShowDialog(); };

 Controls.Add(lblA);
 Controls.Add(txtA);
 Controls.Add(lblB);
 Controls.Add(txtB);
 Controls.Add(btnAdd);
 Controls.Add(btnSub);
 Controls.Add(btnMul);
 Controls.Add(btnDiv);
 Controls.Add(btnHist);
 }

 private void DoOp(Func<double,double,double> op, string sym)
 {
 if (!double.TryParse(txtA.Text, out var a) || !double.TryParse(txtB.Text, out var b)) { MessageBox.Show("Enter two numbers"); return; }
 if (sym == "/" && b==0) { MessageBox.Show("Divide by zero"); return; }
 var r = op(a,b);
 var record = $"{a} {sym} {b} = {r}";
 history.Add(record);
 MessageBox.Show(record, "Result");
 }
 }
}
