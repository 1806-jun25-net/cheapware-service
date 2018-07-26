using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cheapware.Data.Models
{
    public partial class CheapWareContext : DbContext
    {
        public CheapWareContext()
        {
        }

        public CheapWareContext(DbContextOptions<CheapWareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ComputerCase> ComputerCase { get; set; }
        public virtual DbSet<Cpu> Cpu { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<GraphicsCard> GraphicsCard { get; set; }
        public virtual DbSet<HardDrive> HardDrive { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<MotherBoard> MotherBoard { get; set; }
        public virtual DbSet<PartsJunction> PartsJunction { get; set; }
        public virtual DbSet<PartsOrder> PartsOrder { get; set; }
        public virtual DbSet<PowerSupply> PowerSupply { get; set; }
        public virtual DbSet<Ram> Ram { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerCase>(entity =>
            {
                entity.ToTable("ComputerCase", "Cheap");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.ComputerCase)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComputerCase_Name");
            });

            modelBuilder.Entity<Cpu>(entity =>
            {
                entity.ToTable("CPU", "Cheap");

                entity.Property(e => e.Cpuid).HasColumnName("CPUId");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Speed)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.Cpu)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPU_Name");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Customers", "Cheap");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<GraphicsCard>(entity =>
            {
                entity.ToTable("GraphicsCard", "Cheap");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Speed)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.GraphicsCard)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GraphicsCard_Name");
            });

            modelBuilder.Entity<HardDrive>(entity =>
            {
                entity.ToTable("HardDrive", "Cheap");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Speed)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.HardDrive)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HardDrive_Name");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Inventory", "Cheap");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(128);

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<MotherBoard>(entity =>
            {
                entity.ToTable("MotherBoard", "Cheap");

                entity.Property(e => e.FormFactor)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Pcislots).HasColumnName("PCISlots");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Ramslots).HasColumnName("RAMSlots");

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.MotherBoard)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoard_Name");
            });

            modelBuilder.Entity<PartsJunction>(entity =>
            {
                entity.ToTable("PartsJunction", "Cheap");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.PartsJunction)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartsJunction_Name");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PartsJunction)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartsJunction_OrderID");
            });

            modelBuilder.Entity<PartsOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("PartsOrder", "Cheap");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FinalPrice).HasColumnType("money");

                entity.Property(e => e.TimeOfOrder).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PartsOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartsOrder_CustomerID");
            });

            modelBuilder.Entity<PowerSupply>(entity =>
            {
                entity.ToTable("PowerSupply", "Cheap");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Modular).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Watage).HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.PowerSupply)
                    .HasForeignKey(d => d.Name)
                    .HasConstraintName("FK_PowerSupply_Name");
            });

            modelBuilder.Entity<Ram>(entity =>
            {
                entity.ToTable("RAM", "Cheap");

                entity.Property(e => e.Ramid).HasColumnName("RAMId");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Speed)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.Ram)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAM_Name");
            });
        }
    }
}
