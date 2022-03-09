using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Student[] students = new Student[]
      {
         new Student(){Name = "A", Marks=60 },
         new Student(){Name = "B", Marks=70 },
         new Student(){Name = "C", Marks=80 },
      };

      var ms = students.All(a => a.Marks > 50);

      var qs = (from student in students
               select student).All(a => a.Marks > 50);
      */

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
                       .All(a => a.Marks > 70))
                       .Select(s => s).ToList();

      var qs = (from student in students
                where student.Subjects.All(a => a.Marks > 70)
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
