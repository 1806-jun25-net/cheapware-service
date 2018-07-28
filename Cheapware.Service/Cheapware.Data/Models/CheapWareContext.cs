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

        public virtual DbSet<ComputerCases> ComputerCases { get; set; }
        public virtual DbSet<Cpus> Cpus { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<GraphicsCards> GraphicsCards { get; set; }
        public virtual DbSet<HardDrives> HardDrives { get; set; }
        public virtual DbSet<Inventorys> Inventorys { get; set; }
        public virtual DbSet<MotherBoards> MotherBoards { get; set; }
        public virtual DbSet<PartsJunctions> PartsJunctions { get; set; }
        public virtual DbSet<PartsOrders> PartsOrders { get; set; }
        public virtual DbSet<PowerSupplys> PowerSupplys { get; set; }
        public virtual DbSet<Rams> Rams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerCases>(entity =>
            {
                entity.HasKey(e => e.ComputerCaseId);

                entity.ToTable("ComputerCases", "Cheap");

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
                    .WithMany(p => p.ComputerCases)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComputerCases_Name");
            });

            modelBuilder.Entity<Cpus>(entity =>
            {
                entity.HasKey(e => e.Cpuid);

                entity.ToTable("CPUs", "Cheap");

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
                    .WithMany(p => p.Cpus)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPUs_Name");
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

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<GraphicsCards>(entity =>
            {
                entity.HasKey(e => e.GraphicsCardId);

                entity.ToTable("GraphicsCards", "Cheap");

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
                    .WithMany(p => p.GraphicsCards)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GraphicsCards_Name");
            });

            modelBuilder.Entity<HardDrives>(entity =>
            {
                entity.HasKey(e => e.HardDriveId);

                entity.ToTable("HardDrives", "Cheap");

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
                    .WithMany(p => p.HardDrives)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HardDrives_Name");
            });

            modelBuilder.Entity<Inventorys>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Inventorys", "Cheap");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(128);

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<MotherBoards>(entity =>
            {
                entity.HasKey(e => e.MotherBoardId);

                entity.ToTable("MotherBoards", "Cheap");

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
                    .WithMany(p => p.MotherBoards)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MotherBoards_Name");
            });

            modelBuilder.Entity<PartsJunctions>(entity =>
            {
                entity.ToTable("PartsJunctions", "Cheap");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.PartsJunctions)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartsJunctions_Name");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PartsJunctions)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartsJunctions_OrderID");
            });

            modelBuilder.Entity<PartsOrders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("PartsOrders", "Cheap");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.FinalPrice).HasColumnType("money");

                entity.Property(e => e.TimeOfOrder).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PartsOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartsOrders_CustomerID");
            });

            modelBuilder.Entity<PowerSupplys>(entity =>
            {
                entity.HasKey(e => e.PowerSupplyId);

                entity.ToTable("PowerSupplys", "Cheap");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Wattage)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.PowerSupplys)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PowerSupplys_Name");
            });

            modelBuilder.Entity<Rams>(entity =>
            {
                entity.HasKey(e => e.Ramid);

                entity.ToTable("RAMs", "Cheap");

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
                    .WithMany(p => p.Rams)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAMs_Name");
            });
        }
    }
}
