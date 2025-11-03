namespace Assignment2
{
 partial class Form1
 {
 private System.ComponentModel.IContainer components = null;

 protected override void Dispose(bool disposing)
 {
 if (disposing && (components != null))
 {
 components.Dispose();
 }
 base.Dispose(disposing);
 }

 private void InitializeComponent()
 {
 SuspendLayout();
 AutoScaleDimensions = new SizeF(10F,25F);
 AutoScaleMode = AutoScaleMode.Font;
 ClientSize = new Size(800,450);
 Name = "Form1";
 Text = "Form1";
 Load += Form1_Load;
 ResumeLayout(false);
 }
 }
}
