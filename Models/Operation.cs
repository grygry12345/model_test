
namespace model_test.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public int ProductId { get; set; }
        public Product ProductType { get; set; }
        public WorkCenterOperation WorkCenterOperation { get; set; }
    }
}