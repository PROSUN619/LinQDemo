using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> listNum = new List<int>() { 1,3,2,5,4,10,6,9,8,7};

      //char[] chars = {'a','b','a','c','d','c','a' };
      //dynamic result = chars.Where(w => w == 'a').Count();

      //var querySyntax = (from num in listNum
      //                   where num > 3
      //                   orderby num 
      //                   select num).ToList();

      //var methodSyntax = listNum.OrderBy(x => x).ToList();

      List<Student> students = new List<Student>()
      {
          new Student()
          {
           Id = 1, Name = "C"
          },
          new Student()
          {
           Id = 2, Name = "A"
          },
          new Student()
          {
           Id = 3, Name = "Z"
          },
          new Student()
          {
           Id = 4, Name = "I"
          }
      };

      var methodSyntax = (from student in students
                          orderby student.Name
                          select student).ToList();

      var querySyntax = students.OrderBy(o => o.Name).ToList();

      var methodSyntaxDesc = (from student in students
                          orderby student.Name descending
                          select student).ToList();

      var querySyntaxDesc = students.OrderByDescending(o => o.Name).ToList();

    }
  }
}
