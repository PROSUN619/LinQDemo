using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoinLinQ
{
  class Program
  {
    static void Main(string[] args)
    {

      List<Student> students = new List<Student>()
      {
         new Student(){Id = 1 , Name = "Student 1", AddressId = 3 },
         new Student(){Id = 2 , Name = "Student 2", AddressId = 2 },
         new Student(){Id = 3 , Name = "Student 3", AddressId = 1 },
         new Student(){Id = 4 , Name = "Student 4", AddressId = 1 },
         new Student(){Id = 5 , Name = "Student 5", AddressId = 2 }
      };

      List<Address> addresses = new List<Address>()
      {
         new Address(){ Id = 1, FullAddress = "Address 1" },
         new Address(){ Id = 2, FullAddress = "Address 2" },
         new Address(){ Id = 3, FullAddress = "Address 3" }
      };

      List<Marks> marks = new List<Marks>()
      {
         new Marks(){ Id = 1, StudentId = 1, Mark = 60  },
         new Marks(){ Id = 2, StudentId = 2, Mark = 70  },
         new Marks(){ Id = 3, StudentId = 3, Mark = 80  }
      };

      var qs = (from student in students
                join address in addresses
                on student.AddressId equals address.Id
                join mark in marks
                on student.Id equals mark.StudentId
                select new
                {
                  StudentName = student.Name,
                  StudentAddress = address.FullAddress,
                  StudentMarks = mark.Mark
                }).ToList();





      //var ms = students.Join(addresses,
      //          std => std.AddressId,
      //          add => add.Id,
      //          (std, add) => new
      //          {
      //            StudentName = std.Name,
      //            StudentAddress = add.FullAddress
      //          }).ToList();


      var ms = students.Join(addresses,
                            std => std.AddressId,
                            add => add.Id,
                            (std, add) => new { std, add })
                        .Join(marks,
                            std => std.std.Id,
                            m => m.StudentId,
                            (std, m) => new { std, m })
                        .Select(x => new
                        {
                          StudentName = x.std.std.Name,
                          StudentAddress = x.std.add.FullAddress,
                          StudentMarks = x.m.Mark
                        }
                        ).ToList();

    }    
  }

  class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int AddressId { get; set; }
  }

  class Address
  {
    public int Id { get; set; }
    public string FullAddress { get; set; }
  }

  class Marks
  {
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int Mark { get; set; }
  }
}
