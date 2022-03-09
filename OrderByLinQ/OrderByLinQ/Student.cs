using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByLinQ
{
  class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Skill> Programming { get; set; }
  }

  class Skill 
  {
    public string Language { get; set; }
  }
}
