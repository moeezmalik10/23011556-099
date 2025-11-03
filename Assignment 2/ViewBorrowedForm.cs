using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
 public class ViewBorrowedForm : Form
 {
 public ViewBorrowedForm()
 {
 Text = "Borrowed Books";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.7);
 Height = (int)(wa.Height *0.6);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;
 var dgv = new DataGridView { Left =10, Top =10, Width =Width -40, Height =Height -40, ReadOnly = true, AutoGenerateColumns = true, Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
 dgv.DataSource = BookStore.Books.Where(x => !x.Available).ToList();
 Controls.Add(dgv);
 }
 }
}
