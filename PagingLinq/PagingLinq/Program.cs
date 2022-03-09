using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagingLinq
{
  class Program
  {
    static void Main(string[] args)
    {
      int totalPageperView = 5;

      do
      {
        Console.WriteLine("Please enter the page number!");
        int pno = Convert.ToInt32(Console.ReadLine());

        var list = GetStudents().Skip((pno - 1) * totalPageperView).Take(totalPageperView).ToList();

        foreach (var item in list)
        {
          Console.WriteLine("Id: " + item.Id + " Name: " + item.Name);
        }

      } while (true);
    }

    public static List<Student> GetStudents()
    {
      return new List<Student>()
      {
          new Student(){Id = 1, Name = "Student 1"},
          new Student(){Id = 2, Name = "Student 2"},
          new Student(){Id = 3, Name = "Student 3"},
          new Student(){Id = 4, Name = "Student 4"},
          new Student(){Id = 5, Name = "Student 5"},
          new Student(){Id = 6, Name = "Student 6"},
          new Student(){Id = 7, Name = "Student 7"},
          new Student(){Id = 8, Name = "Student 8"},
          new Student(){Id = 9, Name = "Student 9"},
          new Student(){Id = 10, Name = "Student 10"},
          new Student(){Id = 11, Name = "Student 11"},
          new Student(){Id = 12, Name = "Student 12"},
          new Student(){Id = 13, Name = "Student 13"},
          new Student(){Id = 14, Name = "Student 14"},
          new Student(){Id = 15, Name = "Student 15"},
          new Student(){Id = 16, Name = "Student 16"},
          new Student(){Id = 17, Name = "Student 17"},
          new Student(){Id = 18, Name = "Student 18"},
          new Student(){Id = 19, Name = "Student 19"},
          new Student(){Id = 20, Name = "Student 20"}
      };
    }
  }

  class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
