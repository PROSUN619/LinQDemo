using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOrDefaultLinq
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      //var ms1 = numbers.Where(x => x > 5).First();

      //var ms2 = numbers.First(x => x > 5);

      List<User> users = new List<User>()
      {
        new User(){ UserName = "User1", Password = "password"},
        new User(){ UserName = "User2", Password = "password"},
        new User(){ UserName = "User3", Password = "password"},
        new User(){ UserName = "User4", Password = "password"},
        new User(){ UserName = "User5", Password = "password"},
      };

     var user = users.FirstOrDefault(x => x.UserName == "aaa" && x.Password == "aa");

    }  
  }

  class User
  {
    public string UserName { get; set; }
    public string Password { get; set; }
  }
}
