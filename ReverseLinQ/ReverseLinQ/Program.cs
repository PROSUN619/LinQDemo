using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      //linq reverse
      int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,10 };

      var qs = numbers.Reverse().ToList();

      var ms = (from num in numbers
                select num).Reverse().ToList();

      //genric reverse
      List<string> names = new List<string>() {"Bob","Martin","Ayush","Diana" };

      foreach (var item in names)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("=====================");

      //names.Reverse();  //this will directly change the datasource

      var inveted = names.AsEnumerable().Reverse();


      foreach (var item in inveted)
      {
        Console.WriteLine(item);
      }

      Console.ReadLine();
    }
  }
}
