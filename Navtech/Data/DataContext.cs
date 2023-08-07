using Microsoft.EntityFrameworkCore;

namespace Navtech.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
         
        public DbSet<Order> orders { get; set; }


    }
}
