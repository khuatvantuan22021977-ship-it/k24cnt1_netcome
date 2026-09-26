using kvhh2410900034_exam.Models;
using Microsoft.EntityFrameworkCore;

namespace kvhh2410900034_exam.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<kvhhStudent> kvhhStudent { get; set; }
    }
}