using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<Student> students = new List<Student>()
      //{
      //    new Student(){Id = 1, Name = "A"},
      //    new Student(){Id = 2, Name = "B"},
      //    new Student(){Id = 3, Name = "A"},
      //    new Student(){Id = 4, Name = "B"},
      //};

      //var qs = students.Select(s => s.Name).Distinct().ToList();


      List<Student> students = new List<Student>()
      {
          new Student(){Id = 1, Name = "A"},
          new Student(){Id = 2, Name = "B"},
          new Student(){Id = 1, Name = "A"},
          new Student(){Id = 4, Name = "B"},
      };

      //var ms = students.Distinct().ToList();

      var ms = students.Distinct(new StudentComparer()).ToList();
    }
  }


  //class Student : IEquatable<Student>
  //{
  //  public int Id { get; set; }
  //  public string Name { get; set; }

  //  public bool Equals(Student other)
  //  {
  //      if (Object.ReferenceEquals(other,null))
  //      {
  //        return false;
  //      }

  //      if (Object.ReferenceEquals(this,other))
  //      {
  //        return true;
  //      }

  //    return Id.Equals(other.Id) && Name.Equals(other.Name);

  //  }

  //  public override int GetHashCode()
  //  {
  //    int idHashCode = Id.GetHashCode();
  //    int nameHashCode = Name.GetHashCode();

  //    return idHashCode ^ nameHashCode;
  //  }
  //}

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
