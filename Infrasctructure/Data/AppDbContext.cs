using Microsoft.EntityFrameworkCore;
using Proove_of_concept.Domaines.Entities;

namespace Proove_of_concept.Infrasctructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<Produit> Produits { get; set; }
        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produit>()
                .Property(p => p.Nom)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Produit>()
                .Property(p => p.Prix)
                 .HasColumnType("decimal(18, 2)");

        }
        
    }
    
}
