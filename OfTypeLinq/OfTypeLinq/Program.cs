using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfTypeLinq
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Object> list = new List<object>() {"A","BX","C",1,2,3 };

      var methodSyntax = list.OfType<string>().Where(w => w.Length > 1).ToList();

      var querySyntax = (from x in list
                         where x is string
                         select x).ToList();
    }
  }
}
