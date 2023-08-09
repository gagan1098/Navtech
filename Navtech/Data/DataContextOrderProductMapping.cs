namespace Navtech.Data
{
    public class DataContextOrderProductMapping:DbContext
    {
        public DataContextOrderProductMapping(DbContextOptions<DataContextOrderProductMapping> options) : base(options) { }

        public DbSet<OrderProductMapping> orderproducts { get; set; }
    }
}
