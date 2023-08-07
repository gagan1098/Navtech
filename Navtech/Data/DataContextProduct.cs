namespace Navtech.Data
{
    public class DataContextProduct:DbContext
    {
        public DataContextProduct(DbContextOptions<DataContextProduct> options) : base(options) { }

        public DbSet<Product> products { get; set; }
    }
}
