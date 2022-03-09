using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplList = new List<Employee>() 
            { 
                new Employee(){Id =1, Name="Tom", Email="tom@gmail.com"},
                new Employee(){Id =2, Name="Sara", Email="sara@gmail.com"},
                new Employee(){Id =3, Name="Thomas", Email="thomas@gmail.com"},
                new Employee(){Id =4, Name="Jain", Email="jain@gmail.com"},
                new Employee(){Id =5, Name="Lili", Email="lili@gmail.com"}
            };

      // select * or single column
      /* 
        var basicQuery = (from emp in emplList
                          select emp).ToList();

        basicQuery = emplList.ToList();


        var ids = (from emp in basicQuery
                  select emp.Id).ToList();

        var ids1 =  basicQuery.Select(s => s.Id).ToList();

        foreach (var item in basicQuery)
        {
            Console.WriteLine("Id:= " +item.Id + " Name:= "+item.Name);
        }
      */
      // end select * or single column

      // select multiple column

      //var multicolumn = (from emp in emplList
      //                   where emp.Id > 1
      //                   select new Employee()
      //                   {
      //                     Id = emp.Id,
      //                     Name = emp.Name
      //                   }).ToList();


      //different class
      var multicolumn = (from emp in emplList
                         select new Manager()
                         {
                           ManagerId = emp.Id,
                           ManagerName = emp.Name,
                           ManagerEmail= emp.Email
                         }).ToList();

      //method syntax
      multicolumn = emplList.Select(s => new Manager()
      {
        ManagerId = s.Id,
        ManagerName = s.Name,
        ManagerEmail = s.Email
      }).ToList();

      // annonymous type
      var multicolumnA = (from emp in emplList
                    select new
                    {
                      ManagerId = emp.Id,
                      ManagerName = emp.Name,
                      ManagerEmail = emp.Email
                    }).ToList();

      multicolumnA = emplList.Select(s => new 
      {
        ManagerId = s.Id,
        ManagerName = s.Name,
        ManagerEmail = s.Email
      }).ToList();


      // fetch index from list

     var query1 =  emplList.Select((emp, index) => new { Index = index, Name = emp.Name }).ToList();


      foreach (var item in multicolumn)
      {
        var print = $"Id {item.ManagerId} Name {item.ManagerName} Email {item.ManagerEmail}";
        Console.WriteLine(print);
      }

      Console.ReadLine();

      //end select multiple column

      


    }
  }
}
