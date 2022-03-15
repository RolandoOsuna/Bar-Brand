using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WTFBarber.wtfbarberContext
{
    public partial class wtfbarberContext : DbContext
    {
        public wtfbarberContext()
        {
        }

        public wtfbarberContext(DbContextOptions<wtfbarberContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cortecaja> Cortecajas { get; set; }
        public virtual DbSet<Nomina> Nominas { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=LocalHost;UserId=root;Pass=;DataBase=wtfbarber;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cortecaja>(entity =>
            {
                entity.HasKey(e => e.IdCorte)
                    .HasName("PRIMARY");

                entity.ToTable("cortecaja");

                entity.Property(e => e.IdCorte).HasColumnName("idCorte");

                entity.Property(e => e.ComisionesTotalCorte).HasColumnName("comisionesTotal_corte");

                entity.Property(e => e.FechaCorte).HasColumnName("fecha_corte");

                entity.Property(e => e.GananciaCorte).HasColumnName("ganancia_corte");

                entity.Property(e => e.ProductosVendidosCorte).HasColumnName("productosVendidos_corte");

                entity.Property(e => e.TotalVentasCorte).HasColumnName("totalVentas_corte");
            });

            modelBuilder.Entity<Nomina>(entity =>
            {
                entity.HasKey(e => e.IdNomina)
                    .HasName("PRIMARY");

                entity.ToTable("nomina");

                entity.Property(e => e.IdNomina).HasColumnName("idNomina");

                entity.Property(e => e.FechaNomina).HasColumnName("fecha_nomina");

                entity.Property(e => e.TotalComisionNomina).HasColumnName("totalComision_nomina");

                entity.Property(e => e.TotalNomina).HasColumnName("total_nomina");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVentas)
                    .HasName("PRIMARY");

                entity.ToTable("ventas");

                entity.Property(e => e.IdVentas).HasColumnName("id_ventas");

                entity.Property(e => e.ComisionVenta).HasColumnName("comision_venta");

                entity.Property(e => e.EmpleadoVenta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("empleado_venta");

                entity.Property(e => e.FechaVenta).HasColumnName("fecha_venta");

                entity.Property(e => e.ProductoVenta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("producto_venta");

                entity.Property(e => e.TotalComisionVenta).HasColumnName("totalComision_venta");

                entity.Property(e => e.TotalFinalVenta).HasColumnName("totalFinal_venta");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
