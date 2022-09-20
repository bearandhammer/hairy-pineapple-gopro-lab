using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Context
{
    public class GoProLabDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}