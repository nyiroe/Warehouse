using System;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Models
{
    public partial class WarehouseContext : DbContext
    {
        public WarehouseContext()
        {
        }

        public WarehouseContext(DbContextOptions<WarehouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StockItems> StockItems { get; set; }
        public virtual DbSet<StockMovements> StockMovements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<StockItems>(entity =>
            {
                entity.HasKey(e => e.StockItemId);

                entity.HasIndex(e => e.Id)
                    .HasName("IDX_Id_NotNull")
                    .IsUnique()
                    .HasFilter("([Id] IS NOT NULL)");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Mass).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<StockMovements>(entity =>
            {
                entity.HasKey(e => e.StockMovementId);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.StockItem)
                    .WithMany(p => p.StockMovements)
                    .HasForeignKey(d => d.StockItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_StockMovements_StockItems");
            });
        }
    }
}
