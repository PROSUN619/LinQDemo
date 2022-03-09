using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> {1,2,3,4,5,6,7,8,9,10 };

            //query syntax
            Console.WriteLine("------------query syntax----------");

            var querySyntax = from obj in list
                              where obj > 2
                              select obj;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            //method syntax
            Console.WriteLine("------------query syntax----------");

            var methodSyntax = list.Where(x => x > 2);

            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }

            //method syntax
            Console.WriteLine("------------mixed syntax----------");

            var mixedSyntax = (from obj in list
                               select obj).Min();

            Console.WriteLine(mixedSyntax);

            Console.ReadLine();
        }
    }
}
