using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int WorkCenterId { get; set; }
        [ForeignKey("WorkCenterId")]
        public WorkCenter WorkCenter { get; set;}
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}