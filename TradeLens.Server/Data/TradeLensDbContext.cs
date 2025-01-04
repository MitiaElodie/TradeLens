using Microsoft.EntityFrameworkCore;
using TradeLens.Server.Models;

public class TradeLensDbContext : DbContext
{
    public DbSet<Trade> Trades { get; set; }

    public TradeLensDbContext(DbContextOptions<TradeLensDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Trade>()
            .Property(t => t.H4Pattern)
            .HasConversion<string>();

        modelBuilder.Entity<Trade>()
            .Property(t => t.DailyPattern)
            .HasConversion<string>();

        modelBuilder.Entity<Trade>()
            .Property(t => t.DailyPattern)
            .HasConversion<string>();

        base.OnModelCreating(modelBuilder);
    }
}
