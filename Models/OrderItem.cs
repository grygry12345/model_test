using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Amount { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}