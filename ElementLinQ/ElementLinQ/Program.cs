using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementLinQ
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

     var ms =  numbers.Where(w => w > 5).ElementAtOrDefault(1);
    }
  }
}
