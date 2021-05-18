using System.Collections.Generic;

namespace model_test.Models
{
    public class WorkCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public ICollection<WorkCenterOperation> WorkCenterOperation { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
    }
}