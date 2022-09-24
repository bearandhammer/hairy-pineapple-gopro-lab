using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Context
{
    public class GoProLabDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("DataSource=test.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
