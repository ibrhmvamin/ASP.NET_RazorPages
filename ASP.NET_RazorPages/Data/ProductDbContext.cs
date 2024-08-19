using ASP.NET_RazorPages.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_RazorPages.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>
            options)
            :base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
