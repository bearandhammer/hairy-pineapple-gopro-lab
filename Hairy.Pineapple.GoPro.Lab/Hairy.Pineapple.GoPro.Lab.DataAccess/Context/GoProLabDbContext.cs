using Hairy.Pineapple.GoPro.Lab.DataAccess.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hairy.Pineapple.GoPro.Lab.DataAccess.Context
{
    public class GoProLabDbContext : DbContext
    {
        public GoProLabDbContext()
        {
        }

        public GoProLabDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<PresetHeader> PresetHeaders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"GoProLab\Data1");
            Directory.CreateDirectory(sqlitePath);
            var fileName = $"{sqlitePath}\test.db";
            if (!File.Exists(fileName))
                File.Create(fileName);

            optionsBuilder.UseSqlite($"Data Source={fileName}", options =>
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}