using DoubleSlash_Api.DB.Tables;
using Microsoft.EntityFrameworkCore;

namespace DoubleSlash_Api.DB {
    public class DoubleSlashDB : DbContext {
        public DbSet<Cpu> cpu { get; set; }
        public DbSet<Chipset> chipset { get; set; }
        public DoubleSlashDB() {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("Host=pg.ytin24.xyz;Port=5432;Database=doubleslashdb;Username=postgres;Password=333qwertY333"); // Нужен логин и пароль!
        }
    }
}
