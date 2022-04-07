using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotvsTest
{
    public class DbContext
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }

        public DbContext()
        {
            Orders = new List<Order>();
            Products = new List<Product>();

            Products.AddRange(
                new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Notebook",
                        Price = 5000
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Monitor",
                        Price = 1500
                    }
                }
            );
        }
    }
}
