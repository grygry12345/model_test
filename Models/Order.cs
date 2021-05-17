using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class Order
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
<<<<<<< HEAD
        public ICollection<Product> Products { get; set; }
=======
>>>>>>> parent of 354d828 (Simpler Data Model)

        public ICollection<OrderItem> OrderItem { get; set; }
    }
}