using Microsoft.EntityFrameworkCore;

namespace Navtech.Data
{
    public class DataContextOrder:DbContext
    {
        public DataContextOrder(DbContextOptions<DataContextOrder> options) : base(options) { }
         
        public DbSet<Order> orders { get; set; }


    }
}
