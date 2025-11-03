using System;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
 public class BorrowBookForm : Form
 {
 private ComboBox cbBooks;
 private Button btnBorrow;
 public BorrowBookForm()
 {
 Text = "Borrow Book";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.5);
 Height = (int)(wa.Height *0.25);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;

 cbBooks = new ComboBox { Left =10, Top =10, Width =Width -40, DropDownStyle = ComboBoxStyle.DropDownList, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
 btnBorrow = new Button { Text = "Borrow", Left =10, Top =50, Width =100 };
 btnBorrow.Click += BtnBorrow_Click;

 Controls.Add(cbBooks);
 Controls.Add(btnBorrow);

 Load += BorrowBookForm_Load;
 }

 private void BorrowBookForm_Load(object? sender, EventArgs e)
 {
 cbBooks.Items.Clear();
 foreach (var b in BookStore.Books.Where(x => x.Available))
 cbBooks.Items.Add(b);
 cbBooks.DisplayMember = "Title";
 }

 private void BtnBorrow_Click(object? sender, EventArgs e)
 {
 if (cbBooks.SelectedItem is Book b)
 {
 b.Available = false;
 MessageBox.Show($"You borrowed '{b.Title}'");
 this.Close();
 }
 }
 }
}
