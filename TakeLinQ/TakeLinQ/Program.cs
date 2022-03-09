using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,10 };

      var ms = numbers.Where(w => w > 3).Take(5).ToArray();

      var qs = (from n in numbers select n).Where(w => w > 3).Take(5).ToArray();
    }
  }
}
