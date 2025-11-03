using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment2
{
 public class Book
 {
 public int Id { get; set; }
 public string Title { get; set; } = string.Empty;
 public string Author { get; set; } = string.Empty;
 public bool Available { get; set; } = true;
 }

 public static class BookStore
 {
 public static List<Book> Books { get; } = new List<Book>();
 private static int _next =1;
 public static void Add(Book b) { b.Id = _next++; Books.Add(b); }
 }

 public class LibraryDashboardForm : Form
 {
 public LibraryDashboardForm()
 {
 Text = "Library Dashboard";
 var wa = Screen.PrimaryScreen.WorkingArea;
 Width = (int)(wa.Width *0.6);
 Height = (int)(wa.Height *0.6);
 Left =0;
 Top = wa.Height - Height;
 StartPosition = FormStartPosition.Manual;

 var btnAdd = new Button { Text = "Add Book", Left =10, Top =10, Width =120, BackColor = System.Drawing.Color.LightGreen };
 var btnBorrow = new Button { Text = "Borrow Book", Left =150, Top =10, Width =120 };
 var btnView = new Button { Text = "View Borrowed Books", Left =290, Top =10, Width =160 };

 btnAdd.Click += BtnAdd_Click;
 btnBorrow.Click += BtnBorrow_Click;
 btnView.Click += BtnView_Click;

 Controls.Add(btnAdd);
 Controls.Add(btnBorrow);
 Controls.Add(btnView);

 // add some sample books
 if (!BookStore.Books.Any())
 {
 BookStore.Add(new Book { Title = "1984", Author = "George Orwell" });
 BookStore.Add(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien" });
 BookStore.Add(new Book { Title = "Clean Code", Author = "Robert C. Martin" });
 }
 }

 private void BtnAdd_Click(object? sender, EventArgs e)
 {
 var f = new AddBookForm(); f.ShowDialog();
 }

 private void BtnBorrow_Click(object? sender, EventArgs e)
 {
 var f = new BorrowBookForm(); f.ShowDialog();
 }

 private void BtnView_Click(object? sender, EventArgs e)
 {
 var f = new ViewBorrowedForm(); f.ShowDialog();
 }
 }
}
