using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFDatabaseFirst.Models
{
    public partial class bd_pruebaContext : DbContext
    {
        public bd_pruebaContext()
        {
        }

        public bd_pruebaContext(DbContextOptions<bd_pruebaContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Customer> Customers { get; set; } = null!;
        //public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Empleado> Empleado { get; set; } = null!;
        public virtual DbSet<Persona> Persona { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-C8449RA\\SQLEXPRESS;Initial Catalog=bd_prueba;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("empleado");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CuentaSueldo).HasColumnName("cuenta_sueldo");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.FAlta)
                    .HasColumnType("datetime")
                    .HasColumnName("f_alta");

                entity.Property(e => e.FkId).HasColumnName("fk_id");

                entity.Property(e => e.Legajo).HasColumnName("legajo");

                entity.HasOne(d => d.Fk)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.FkId)
                    .HasConstraintName("FK__empleado__fk_id__4316F928");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OrderID");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("persona");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.FNac)
                    .HasColumnType("datetime")
                    .HasColumnName("f_nac");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
