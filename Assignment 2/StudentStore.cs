using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
 public static class StudentStore
 {
 private static List<Student> _students = new List<Student>();
 private static int _nextId =1;

 public static IEnumerable<Student> Students => _students;

 public static void Add(Student s)
 {
 s.Id = _nextId++;
 _students.Add(s);
 }

 public static void Remove(int id)
 {
 var item = _students.FirstOrDefault(x => x.Id == id);
 if (item != null) _students.Remove(item);
 }
 }
}
