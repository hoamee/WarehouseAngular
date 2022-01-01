
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.Property(p => p.WhId).IsRequired().HasMaxLength(50);
            builder.Property(p => p.WhName).IsRequired().HasMaxLength(100);
            builder.HasOne(p => p.Site).WithMany().HasForeignKey(p => p.SiteId);
        }
    }

    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(p => p.LocId).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LocName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.LocCap).IsRequired();
            builder.HasOne(p => p.Warehouse).WithMany().HasForeignKey(p => p.WhId);
        }
    }
}