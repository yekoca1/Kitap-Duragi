using Microsoft.EntityFrameworkCore;
using KitapDuragi.entity;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Comment> Comments { get; set; } // Yorum tablosunu tanımlar

    // Diğer tablolar için DbSet tanımları
}
