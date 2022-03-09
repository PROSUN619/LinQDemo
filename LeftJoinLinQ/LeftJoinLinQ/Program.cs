using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftJoinLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Student> students = new List<Student>()
      {
        new Student(){ Id = 1, Name = "Student 1", AddressId = 1 },
        new Student(){ Id = 2, Name = "Student 2", AddressId = 2 },
        new Student(){ Id = 3, Name = "Student 3", AddressId = 3 },
        new Student(){ Id = 4, Name = "Student 4" },
        new Student(){ Id = 5, Name = "Student 5", AddressId = 4 }
      };

      List<Address> addresses = new List<Address>()
      {
        new Address(){Id = 1, LineAddress = "LineAddress 1"},
        new Address(){Id = 2, LineAddress = "LineAddress 2"},
        new Address(){Id = 3, LineAddress = "LineAddress 3"}
      };


      var qs = (from std in students
                join add in addresses on std.AddressId equals add.Id into stdaddress
                from sa in stdaddress.DefaultIfEmpty()
                select new
                {
                  StudentName = std.Name,
                  StudentAddesss = sa != null ? sa.LineAddress : "NA"
                }).ToList();

      var ms = students.GroupJoin(addresses, std => std.AddressId, add => add.Id,
                                  (std, add) => new { std, add })
                        .SelectMany(x =>
                       x.add.DefaultIfEmpty(),
                        (studentdata, addressdata) =>
                         new
                         {
                           studentdata.std,
                           addressdata
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
    public string LineAddress { get; set; }
  }

}
