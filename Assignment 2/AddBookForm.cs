using System;
using System.Windows.Forms;

namespace Assignment2
{
 public class AddBookForm : Form
 {
 private TextBox txtTitle;
 private TextBox txtAuthor;
 private Button btnSave;
 public AddBookForm()
 {
 Text = "Add Book";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.4);
 Height = (int)(wa.Height *0.35);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;

 var lblTitle = new Label { Text = "Title:", Left =10, Top =20, Width =80 };
 txtTitle = new TextBox { Left =100, Top =18, Width =200 };
 var lblAuthor = new Label { Text = "Author:", Left =10, Top =60, Width =80 };
 txtAuthor = new TextBox { Left =100, Top =58, Width =200 };
 btnSave = new Button { Text = "Save", Left =100, Top =100, Width =100 };
 btnSave.Click += BtnSave_Click;

 Controls.Add(lblTitle);
 Controls.Add(txtTitle);
 Controls.Add(lblAuthor);
 Controls.Add(txtAuthor);
 Controls.Add(btnSave);
 }

 private void BtnSave_Click(object? sender, EventArgs e)
 {
 if (string.IsNullOrWhiteSpace(txtTitle.Text)) { MessageBox.Show("Title required"); return; }
 var b = new Book { Title = txtTitle.Text.Trim(), Author = txtAuthor.Text.Trim(), Available = true };
 BookStore.Add(b);
 MessageBox.Show("Book added");
 this.Close();
 }
 }
}
