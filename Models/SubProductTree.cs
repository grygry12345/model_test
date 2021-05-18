using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class SubProductTree
    {
        public int Id { get; set; }
        public string Subproduct { get; set;}
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public string Amount { get; set; }
    }
}