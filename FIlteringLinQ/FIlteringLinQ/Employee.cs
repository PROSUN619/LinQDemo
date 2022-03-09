using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyLinQ
{
  class Employee
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> Skills { get; set; }
  }
}
