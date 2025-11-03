using System;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
 public class ViewStudentsForm : Form
 {
 private DataGridView dgv;
 public ViewStudentsForm()
 {
 Text = "View Students";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.7);
 Height = (int)(wa.Height *0.6);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;

 dgv = new DataGridView { Left =10, Top =10, Width =Width -40, Height =Height -80, ReadOnly = true, AutoGenerateColumns = true, Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
 var btnDelete = new Button { Text = "Delete Selected", Left =10, Top =Height -60, Width =120, Anchor = AnchorStyles.Bottom | AnchorStyles.Left };
 btnDelete.Click += BtnDelete_Click;

 Controls.Add(dgv);
 Controls.Add(btnDelete);

 Load += ViewStudentsForm_Load;
 }

 private void ViewStudentsForm_Load(object? sender, EventArgs e)
 {
 dgv.DataSource = StudentStore.Students.ToList();
 }

 private void BtnDelete_Click(object? sender, EventArgs e)
 {
 if (dgv.CurrentRow == null) return;
 if (dgv.CurrentRow.DataBoundItem is Student s)
 {
 var confirm = MessageBox.Show($"Delete {s.Name}?","Confirm",MessageBoxButtons.YesNo);
 if (confirm == DialogResult.Yes)
 {
 StudentStore.Remove(s.Id);
 dgv.DataSource = StudentStore.Students.ToList();
 }
 }
 }
 }
}
