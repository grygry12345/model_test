using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set;}
        public bool IsSalable {get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
        public ICollection<SubProductTree> SubProductTree { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
    }
}