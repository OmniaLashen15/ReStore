using Microsoft.EntityFrameworkCore;
using ReactProject.Entities;

namespace ReactProject.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products {get; set;}
    }
}