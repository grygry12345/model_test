using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class WorkCenterOperation
    {
        public int Id { get; set; }
        public int Speed { get; set; }
        public int WorkCenterId { get; set; }
        [ForeignKey("WorkCenterId")]
        public WorkCenter WorkCenter { get; set; }
        public int OperationId { get; set; }
        [ForeignKey("OperationId")]
        public Operation Operation { get; set; }
    }
}