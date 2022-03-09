using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<String> ds1 = new List<string> {"A","B","C","D" };
      //List<String> ds2 = new List<string> { "F", "G", "C", "D" };

      //var ms = ds1.Except(ds2).ToList();

      var student1 = new List<Student>()
      { 
        new Student(){Id = 1, Name="A" },
        new Student(){Id = 2, Name="B" },
        new Student(){Id = 3, Name="C" },
        new Student(){Id = 4, Name="D" },
      };

      var student2 = new List<Student>()
      {
        new Student(){Id = 1, Name="A" },
        new Student(){Id = 2, Name="B" },
        new Student(){Id = 3, Name="D" },
        new Student(){Id = 4, Name="F" },
      };

      //var ms = student1.Select(s => s.Name).Except(student2.Select(s => s.Name)).ToList();

      //var ms = student1.Select(s => new { s.Id, s.Name }).Except(student2.Select(s => new { s.Id, s.Name })).ToList();

      var ms = student1.Except(student2, new StudentComparer()).ToList();
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
      return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
    }

    public int GetHashCode(Student obj)
    {
      int idHashCode = obj.Id.GetHashCode();
      int nameHashCode = obj.Name.GetHashCode();

      return idHashCode ^ nameHashCode;
    }
  }
}
