using Microsoft.EntityFrameworkCore;
using model_test.Models;

namespace model_test.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubProductTree> SubProductTrees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkCenter> WorkCenters { get; set; }
        public DbSet<WorkCenterOperation> WorkCenterOperations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

    }
}