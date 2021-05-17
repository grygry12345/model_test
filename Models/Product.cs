using System.Collections.Generic;

namespace model_test.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
<<<<<<< HEAD
        public string Type { get; set; }
        public ICollection<Order> Orders { get; set; }
=======
        public bool IsSalable {get; set; }
        public OrderItem OrderItem { get; set; }
        public Operation ProductType {get; set; }
        public ICollection<SubProduct> SubProduct { get; set; }
>>>>>>> parent of 354d828 (Simpler Data Model)
    }
}