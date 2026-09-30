using kvhhNetCoreLAB6_EF.Models;
using Microsoft.EntityFrameworkCore;
using kvhhNetCoreLAB6_EF.Models;

namespace kvhhNetCoreLAB6_EF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}