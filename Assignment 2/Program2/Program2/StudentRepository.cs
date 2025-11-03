using System.ComponentModel;

namespace Program2
{
 public class Student
 {
 public string Name { get; set; }
 public int Age { get; set; }
 public string Class { get; set; }
 }

 public static class StudentRepository
 {
 // Use BindingList so the DataGridView updates automatically when items change
 public static BindingList<Student> Students { get; } = new BindingList<Student>();

 public static void Add(Student s) => Students.Add(s);

 public static void Remove(Student s)
 {
 if (Students.Contains(s))
 Students.Remove(s);
 }

 public static BindingList<Student> GetAll() => Students;
 }
}
