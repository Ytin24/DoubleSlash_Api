using DoubleSlash_Api.DB.Tables;
using Microsoft.EntityFrameworkCore;

namespace DoubleSlash_Api.DB {
    public class DoubleSlashDB : DbContext {
        public DbSet<Chipset> chipset { get; set; }
        public DbSet<Cooler> cooler { get; set; }
        public DbSet<Cpu> cpu { get; set; }
        public DbSet<DdrType> ddr_type { get; set; }
        public DbSet<Gpu> gpu { get; set; }
        public DbSet<Motherboard> motherboard { get; set; }
        public DbSet<Pb> pb { get; set; }

        public DoubleSlashDB() {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=doubleslashdb;Username=dsuser;Password=qwertY");
        }
    }
}
