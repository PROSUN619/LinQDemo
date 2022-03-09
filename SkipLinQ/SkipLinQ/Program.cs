using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipLinQ
{
  class Program
  {
    static void Main(string[] args)
    {

      int[] numbers = new int[] { 1, 2, 3, 10, 11, 4, 5, 6 };

      var ms = numbers.Where(w => w < 4).Skip(2).ToArray();


    }
  }
}
