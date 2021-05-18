
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace model_test.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public string ProductType { get; set; }
        public ICollection<WorkCenterOperation> WorkCenterOperations { get; set; }
    }
}