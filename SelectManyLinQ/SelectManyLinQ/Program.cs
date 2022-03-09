using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      //First Example

      /*
      List<string> list = new List<string>() {"Prasun","Chakraborty" };

      var methodResult = list.SelectMany(x => x).ToList();

      var queryResult = (from str in list
                         from ch in str
                         select ch).ToList();
      */
      /*
      List<Employee> list = new List<Employee>()
      { 
        new Employee(){Id =1, Name = "Tom", Skills = new List<string>(){"C#","JAVA","PYTHON" } },
        new Employee(){Id =1, Name = "Tom", Skills = new List<string>(){"C#","PHP","NODE" } },
        new Employee(){Id =1, Name = "Tom", Skills = new List<string>(){"VB","JAVA","ANGULAR" } }
      };

      var methodSyntax = list.SelectMany(s => s.Skills).ToList();

      var querySyntax = (from emp in list
                         from skl in emp.Skills
                         select skl).ToList();


      */

      //First Example End -----------------

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
              new Skill(){ Language = "angular"}
            }
          },
          new Student()
          {
           Id = 4, Name = "Student4",
            Programming = new List<Skill>()
            {
              new Skill()
            }
          }
      };


      var methodSyntax = students.SelectMany(x => x.Programming).ToList();

      var querySyntax = (from st in students
                        from lang in st.Programming
                        select lang).ToList();


      foreach (var item in querySyntax)
      {
        Console.WriteLine(item.Language);
      }

      Console.ReadLine();

    }
  }
}
