using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<string> names = new List<string> {"A","B","C","D","E","F" };

      //var ms = names.AsEnumerable().Contains("A");

      //var qs = (from name in names
      //          select name).Contains("E");


      List<Student> students = new List<Student>()
      {
          new Student() {Id =1, Name = "A" },
          new Student() {Id =2, Name = "B" }
      };


      var comparer = new StudentComparer();

      var ms = students.Contains(new Student() { Id = 1, Name = "A" }, comparer);

      var qs = (from student in students
               select student).Contains(new Student() { Id = 1, Name = "C" }, comparer);
      //var ms = students.Contains(new Student() { Id = 1, Name = "A" }, comparer);


    }
  }

  class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }

  class StudentComparer : IEqualityComparer<Student>
  {
    public bool Equals(Student x, Student y)
    {
      if (Object.ReferenceEquals(x,y))
      {
        return true;
      }

      if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
      {
        return false;
      }

      return x.Id == y.Id && x.Name == y.Name;
    }

    public int GetHashCode(Student obj)
    {
      if (obj == null)
      {
        return 0;
      }

      int idHashCode = obj.Id.GetHashCode();
      int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

      return idHashCode ^ nameHashCode;
    }
  }
}
