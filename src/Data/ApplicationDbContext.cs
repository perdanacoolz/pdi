using JwtRoleAuthentication.Enums;
using JwtRoleAuthentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtRoleAuthentication.Data;

public class ApplicationDbContext : IdentityUserContext<ApplicationUser>
{
    public DbSet<Page> Pages => Set<Page>();

    public DbSet<Barang> Barangs => Set<Barang>();

    public DbSet<Kategori> kategoris => Set<Kategori>();

    public DbSet<Transaksi> transaksis => Set<Transaksi>();

    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaksi>()
               .HasOne(t => t.barang)
               .WithMany(c => c.Transactions)
               .HasForeignKey(t => t.BarangId);

        modelBuilder.Entity<Transaksi>()
            .HasOne(t => t.kategori)
            .WithMany(f => f.Transactions)
            .HasForeignKey(t => t.KategoriID);

        base.OnModelCreating(modelBuilder);
    }
}