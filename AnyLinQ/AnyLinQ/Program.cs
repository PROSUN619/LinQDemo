using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      //Student[] students = 
      //{ 
      //   new Student(){Name ="A",Marks = 80 },
      //   new Student(){Name ="B",Marks = 60 },
      //   new Student(){Name ="C",Marks = 70 }
      //};

      //var ms = students.Any(x => x.Marks > 70);

      //var qs = (from student in students
      //         select student).Any(x => x.Marks > 70);

      Student[] students = new Student[]
      {
         new Student(){Name = "A",
          Subjects = new List<Subject>()
          {
             new Subject(){Name = "Bengali",Marks=75 },
             new Subject(){Name = "English",Marks=80 },
             new Subject(){Name = "Math",Marks=90 }
          }
         },
         new Student(){Name = "B",
          Subjects = new List<Subject>()
          {
             new Subject(){Name = "Bengali",Marks=65 },
             new Subject(){Name = "English",Marks=70 },
             new Subject(){Name = "Math",Marks=80 }
          }
         },
         new Student(){Name = "C",
          Subjects = new List<Subject>()
          {
             new Subject(){Name = "Bengali",Marks=90 },
             new Subject(){Name = "English",Marks=95 },
             new Subject(){Name = "Math",Marks=100 }
          }
         },
      };

      var ms = students.Where(w => w.Subjects
                       .Any(a => a.Marks > 70))
                       .Select(s => s).ToList();

      var qs = (from student in students
                where student.Subjects.Any(a => a.Marks > 70)
                select student).ToList();




    }
  }

  //class Student
  //{
  //  public string Name { get; set; }
  //  public int Marks { get; set; }
  //}

  class Student
  {
    public string Name { get; set; }
    public List<Subject> Subjects { get; set; }
  }

  class Subject
  {
    public string Name { get; set; }
    public int Marks { get; set; }
  }
}
