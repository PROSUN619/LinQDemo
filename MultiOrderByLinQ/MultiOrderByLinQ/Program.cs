using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOrderByLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = new List<Employee>()
      {
        new Employee(){Id =1, FirstName="A",LastName="S",Salary=10000 },
        new Employee(){Id =1, FirstName="A",LastName="R",Salary=12000 },
        new Employee(){Id =1, FirstName="B",LastName="B",Salary=40000 },
        new Employee(){Id =1, FirstName="B",LastName="A",Salary=50000 }
      };

      var querySyntax = (from employee in employees
                         orderby employee.FirstName, employee.LastName
                         select employee).ToList();

      var methodSyntax = employees.OrderBy(o => o.FirstName).ThenBy(t => t.LastName).ToList();



    }

  }

  class  Employee
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Salary { get; set; }
  }
}
