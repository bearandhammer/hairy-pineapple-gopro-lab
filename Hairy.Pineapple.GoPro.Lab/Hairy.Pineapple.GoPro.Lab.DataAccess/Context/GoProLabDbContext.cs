using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Context
{
    public class GoProLabDbContext : DbContext
    {
        public GoProLabDbContext()
        {
            Database.Migrate();
        }

        public virtual DbSet<PresetHeader> PresetHeaders => Set<PresetHeader>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string sqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"GoProLab\PresetData");
            Directory.CreateDirectory(sqlitePath);
            
            string fileName = $"{sqlitePath}\ttest.db";

            #region Better Mechanism Required

            //if (!initialised)
            //{ 
            //    if (File.Exists(fileName))
            //    {
            //        File.Delete(fileName);
            //    }

            //    File.Create(fileName);
            //}

            #endregion Better Mechanism Required

            optionsBuilder.UseSqlite($"Data Source={fileName}", options =>
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
