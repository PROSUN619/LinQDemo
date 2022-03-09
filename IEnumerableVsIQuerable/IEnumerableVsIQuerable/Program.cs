using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVsIQuerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>() 
            { 
                new Employee(){ Id = 1, Name = "Tom"},
                new Employee(){ Id = 2, Name = "John"}
            };

            //IEnumerable
            IEnumerable<Employee> query1 = from obj in empList
                         where obj.Id == 1
                         select obj;

            foreach (var item in query1)
            {
                Console.WriteLine("Id: " + item.Id + " Name: " +item.Name);
            }


            //IQuerable
            Console.WriteLine("IQuerable");
            IQueryable<Employee> query2 = empList.AsQueryable().Where(x => x.Id == 1);

            foreach (var item in query2)
            {
                Console.WriteLine("Id: " + item.Id + " Name: " + item.Name);
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
