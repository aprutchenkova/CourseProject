using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyApp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка моделей
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Word>()
                .HasOne(w => w.Theme)
                .WithMany(t => t.Words)
                .HasForeignKey(w => w.ThemeId);
        }
    }
}