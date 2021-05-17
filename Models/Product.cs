using System.Collections.Generic;

namespace model_test.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSalable {get; set; }
        public OrderItem OrderItem { get; set; }
        public Operation ProductType {get; set; }
        public ICollection<SubProduct> SubProduct { get; set; }
    }
}