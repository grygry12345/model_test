using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class SubProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public string Amount { get; set; }
    }
}