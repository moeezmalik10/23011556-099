using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
 public class HistoryForm : Form
 {
 public HistoryForm(List<string> items)
 {
 Text = "History";
 Width =400;
 Height =300;
 var lb = new ListBox { Left =30, Top =30, Width =360, Height =240 };
 lb.Items.AddRange(items.ToArray());
 Controls.Add(lb);
 }
 }
}
