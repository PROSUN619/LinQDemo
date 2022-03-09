using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIlteringLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10 };

      var querySyntax = (from num in numbers
                         where num <= 5 || num > 9
                         select num).ToList();

      var methodSyntax = numbers.Where(x => x <= 5 || x > 9).ToList();
      */

      List<Student> students = new List<Student>()
      {
          new Student()
          {
           Id = 1, Name = "Student1",
            Programming = new List<Skill>()
            {
              new Skill(){Language = "java" },
              new Skill(){ Language = "C#"}
            }
          },
          new Student()
          {
           Id = 2, Name = "Student2",
            Programming = new List<Skill>()
            {
              new Skill(){Language = "python" },
              new Skill(){ Language = "php"}
            }
          },
          new Student()
          {
           Id = 3, Name = "Student3",
            Programming = new List<Skill>()
            {
              new Skill(){Language = "node" },
              new Skill(){ Language = "angular"},
              new Skill(){ Language = "CSS"}
            }
          },
          new Student()
          {
           Id = 4, Name = "Student4",
           Programming = new List<Skill>()
           {
              
           }
          }
      };

      var querySyntax = (from student in students
                         where student.Programming.Count == 0
                         select student).ToList();


      var methodSyntax = students.Where(s => s.Programming.Count == 0).ToList();

      Console.ReadLine();

    }
  }
}
