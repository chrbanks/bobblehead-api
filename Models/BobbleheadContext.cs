namespace BobbleheadApi.Models
{
    using System.IO;
    using Microsoft.Data.Entity;
    using Microsoft.Extensions.PlatformAbstractions;


    // >dnx . ef migrations add bobbleheadMigration
    public class BobbleheadContext : DbContext
    {
        public DbSet<Bobblehead> Bobbleheads { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bobblehead>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = PlatformServices.Default.Application.ApplicationBasePath;
            optionsBuilder.UseSqlite("Filename=" + Path.Combine(path, "bobbleheads.sqlite"));
        }
    }
}