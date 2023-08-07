namespace Navtech.Data
{
    public class DataContextCustomer:DbContext
    {
        public DataContextCustomer(DbContextOptions<DataContextCustomer> options) : base(options) { }

        public DbSet<Customer> customers { get; set; }
    }
}
