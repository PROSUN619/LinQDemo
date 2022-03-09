using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeWhileLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = new int[] { 1, 2, 3, 10, 11, 4, 5, 6 };

      //var ms = numbers.TakeWhile( x => x <3).ToArray();

      List<string> lst = new List<string>() {"AB", "BC", "CD", "EF" };

      var ms = lst.TakeWhile((x, i) => i < x.Length).ToList();
    }
  }
}
