using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab2_web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Sotrudnik> Sotrudniki { get; set; } = default!;
        public DbSet<Dolzhnost> Dolzhnosti { get; set; } = default!;
        public DbSet<Naznachenie> Naznacheniyas { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Naznachenie>()
                .HasOne(n => n.Sotrudnik)
                .WithMany()
                .HasForeignKey(n => n.KodSotrudnika)
                .OnDelete(DeleteBehavior.Restrict);  // Устанавливаем внешний ключ

            modelBuilder.Entity<Naznachenie>()
                .HasOne(n => n.Dolzhnost)
                .WithMany()
                .HasForeignKey(n => n.KodDolzhnosti)
                .OnDelete(DeleteBehavior.Restrict);  // Устанавливаем внешний ключ
        }
    }
}
