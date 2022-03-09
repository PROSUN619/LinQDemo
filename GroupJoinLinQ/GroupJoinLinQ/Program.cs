using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoinLinQ
{
  class Program
  {
    static void Main(string[] args)
    {

            List<Product> products = new List<Product>()
            {
              new Product(){Id = 1, Name ="Product 1", CategoryId = 1 },
              new Product(){Id = 2, Name ="Product 2", CategoryId = 1 },
              new Product(){Id = 3, Name ="Product 3", CategoryId = 2 },
              new Product(){Id = 4, Name ="Product 4", CategoryId = 2 },
              new Product(){Id = 5, Name ="Product 5", CategoryId = 3 },
            };


              List<Category> categories = new List<Category>()
            {
               new Category(){Id = 1, Name = "Category 1" },
               new Category(){Id = 2, Name = "Category 2" },
               new Category(){Id = 3, Name = "Category 3" },
            };

      var ms = categories.GroupJoin(products, cat => cat.Id, pro => pro.CategoryId,
        (cat, pro) => new { cat, pro }
        );

      var qs = from cat in categories
               join
               pro in products
               on cat.Id equals pro.CategoryId into groups
               select new { cat, groups };

      foreach (var item in ms)
      {
        Console.WriteLine(item.cat.Name + "======================>");

        foreach (var i in item.pro)
        {
          Console.WriteLine(i.Name);
        }
      }





    }






  }


  class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
  }

  class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }

}
