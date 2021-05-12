using System.Collections.Generic;

namespace model_test.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public ICollection<Order> Order { get; set;}
    }
}