using System.Collections.Generic;

namespace model_test.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}