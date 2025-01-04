using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradeLens.Server.Models;

public class TradeLensDbContext : DbContext
{
    public DbSet<Trade> Trades { get; set; }

    public TradeLensDbContext(DbContextOptions<TradeLensDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Automatically convert all enums to strings
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            foreach (var property in entityType.GetProperties())
            {
                if (property.ClrType.IsEnum)
                {
                    var enumType = property.ClrType;
                    var converterType = typeof(EnumToStringConverter<>).MakeGenericType(enumType);

                    var converter = (Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter)Activator.CreateInstance(converterType);
                    property.SetValueConverter(converter);
                }
            }
        }

        base.OnModelCreating(modelBuilder);
    }
}
