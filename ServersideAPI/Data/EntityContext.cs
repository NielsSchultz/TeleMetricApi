using Microsoft.EntityFrameworkCore;
using ServersideAPI.Data.Entities;

namespace ServersideAPI.Data
{
    public class EntityContext : DbContext
    {
        
        public EntityContext()
            : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.135.16.166,1433;Database=TelemetricsDB;User Id=sa;password=P@ssw0rd");
        }

        public DbSet<Telemetrics> Telemtrics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Telemetrics>().ToTable("Telemetrics");
        }

    }
}
