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

        public virtual DbSet<Cita> Citas { get; set; }
        public virtual DbSet<Cortecaja> Cortecajas { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<Nomina> Nominas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
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
            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PRIMARY");

                entity.ToTable("citas");

                entity.Property(e => e.IdCita).HasColumnName("idCita");

                entity.Property(e => e.FechaCita).HasColumnName("fecha_cita");

                entity.Property(e => e.NombreCita)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nombre_cita");

                entity.Property(e => e.TelefonoCita)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("telefono_cita");
            });

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

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.HasKey(e => e.IdGasto)
                    .HasName("PRIMARY");

                entity.ToTable("gastos");

                entity.Property(e => e.IdGasto).HasColumnName("idGasto");

                entity.Property(e => e.CantidadGasto).HasColumnName("cantidad_gasto");

                entity.Property(e => e.DescripcionGasto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("descripcion_gasto");

                entity.Property(e => e.FechaGasto).HasColumnName("fecha_gasto");

                entity.Property(e => e.NombreGasto)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nombre_gasto");
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

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.ContrasenaUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("contrasena_usuario");

                entity.Property(e => e.FechaUsuario).HasColumnName("fecha_usuario");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nombre_usuario");

                entity.Property(e => e.PrivilegioUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("privilegio_usuario");
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
