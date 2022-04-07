using System.Collections.Generic;

namespace TotvsTest
{
    public class Order
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public List<Product> Products { get; set; }
    }
}
