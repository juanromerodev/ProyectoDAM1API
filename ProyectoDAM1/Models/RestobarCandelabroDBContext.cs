using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoDAM1.Models
{
    public partial class RestobarCandelabroDBContext : DbContext
    {
        public RestobarCandelabroDBContext()
        {
        }

        public RestobarCandelabroDBContext(DbContextOptions<RestobarCandelabroDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bebidum> Bebida { get; set; } = null!;
        public virtual DbSet<CategoriaBebidum> CategoriaBebida { get; set; } = null!;
        public virtual DbSet<CategoriaPlato> CategoriaPlatos { get; set; } = null!;
        public virtual DbSet<Comprobante> Comprobantes { get; set; } = null!;
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Mesa> Mesas { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Plato> Platos { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NKVPEO3\\SQLDEVELOPER;Initial Catalog=RestobarCandelabroDB;uid=sa;pwd=sql123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bebidum>(entity =>
            {
                entity.HasKey(e => e.IdBebida)
                    .HasName("PK__BEBIDA__A3EF9CADB005B817");

                entity.ToTable("BEBIDA");

                entity.Property(e => e.IdBebida)
                    .ValueGeneratedNever()
                    .HasColumnName("id_bebida");

                entity.Property(e => e.CategoriaBebidaId).HasColumnName("categoria_bebida_id");

                entity.Property(e => e.DescripcionBebida)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion_bebida");

                entity.Property(e => e.DetalleBebida)
                    .HasMaxLength(100)
                    .HasColumnName("detalle_bebida");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.ImagenUrl)
                    .HasMaxLength(200)
                    .HasColumnName("imagen_url");

                entity.HasOne(d => d.CategoriaBebida)
                    .WithMany(p => p.Bebida)
                    .HasForeignKey(d => d.CategoriaBebidaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BEBIDA__categori__45F365D3");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Bebida)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BEBIDA__id_produ__46E78A0C");
            });

            modelBuilder.Entity<CategoriaBebidum>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaBebida)
                    .HasName("PK__CATEGORI__7075EFCC37BC7C73");

                entity.ToTable("CATEGORIA_BEBIDA");

                entity.Property(e => e.IdCategoriaBebida)
                    .ValueGeneratedNever()
                    .HasColumnName("id_categoria_bebida");

                entity.Property(e => e.DesCategoria)
                    .HasMaxLength(50)
                    .HasColumnName("des_categoria");
            });

            modelBuilder.Entity<CategoriaPlato>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaPlato)
                    .HasName("PK__CATEGORI__37F746CB8D7D3701");

                entity.ToTable("CATEGORIA_PLATO");

                entity.Property(e => e.IdCategoriaPlato)
                    .ValueGeneratedNever()
                    .HasColumnName("id_categoria_plato");

                entity.Property(e => e.DesCategoria)
                    .HasMaxLength(50)
                    .HasColumnName("des_categoria");
            });

            modelBuilder.Entity<Comprobante>(entity =>
            {
                entity.HasKey(e => e.NumComprobante)
                    .HasName("PK__COMPROBA__3D2B8656C9195F38");

                entity.ToTable("COMPROBANTE");

                entity.Property(e => e.NumComprobante)
                    .ValueGeneratedNever()
                    .HasColumnName("num_comprobante");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Comprobantes)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK__COMPROBAN__id_pe__52593CB8");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => e.IdDetallePedido)
                    .HasName("PK__DETALLE___C08768CF50690969");

                entity.ToTable("DETALLE_PEDIDO");

                entity.Property(e => e.IdDetallePedido)
                    .ValueGeneratedNever()
                    .HasColumnName("id_detalle_pedido");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdPedido).HasColumnName("id_pedido");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("subtotal");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__subto__4E88ABD4");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DETALLE_P__id_pr__4F7CD00D");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__EMPLEADO__88B51394BC63DF2F");

                entity.ToTable("EMPLEADO");

                entity.Property(e => e.IdEmpleado)
                    .ValueGeneratedNever()
                    .HasColumnName("id_empleado");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .HasColumnName("cargo");

                entity.Property(e => e.Dni)
                    .HasMaxLength(20)
                    .HasColumnName("dni");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .HasColumnName("nombres");
            });

            modelBuilder.Entity<Mesa>(entity =>
            {
                entity.HasKey(e => e.NumMesa)
                    .HasName("PK__MESA__E855CB7DC5EA4022");

                entity.ToTable("MESA");

                entity.Property(e => e.NumMesa)
                    .ValueGeneratedNever()
                    .HasColumnName("num_mesa");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("estado");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__PEDIDO__6FF014895612687C");

                entity.ToTable("PEDIDO");

                entity.Property(e => e.IdPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("id_pedido");

                entity.Property(e => e.NumMesa).HasColumnName("num_mesa");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.NumMesaNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.NumMesa)
                    .HasConstraintName("FK__PEDIDO__num_mesa__4BAC3F29");
            });

            modelBuilder.Entity<Plato>(entity =>
            {
                entity.HasKey(e => e.IdPlato)
                    .HasName("PK__PLATO__04D4F2C0EA4C1F9B");

                entity.ToTable("PLATO");

                entity.Property(e => e.IdPlato)
                    .ValueGeneratedNever()
                    .HasColumnName("id_plato");

                entity.Property(e => e.CategoriaPlatoId).HasColumnName("categoria_plato_id");

                entity.Property(e => e.DescripcionPlato)
                    .HasMaxLength(200)
                    .HasColumnName("descripcion_plato");

                entity.Property(e => e.DetallePlato)
                    .HasMaxLength(100)
                    .HasColumnName("detalle_plato");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.ImagenUrl)
                    .HasMaxLength(200)
                    .HasColumnName("imagen_url");

                entity.HasOne(d => d.CategoriaPlato)
                    .WithMany(p => p.Platos)
                    .HasForeignKey(d => d.CategoriaPlatoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PLATO__categoria__403A8C7D");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Platos)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PLATO__id_produc__412EB0B6");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__PRODUCTO__FF341C0DEB60FDEB");

                entity.ToTable("PRODUCTO");

                entity.Property(e => e.IdProducto)
                    .ValueGeneratedNever()
                    .HasColumnName("id_producto");

                entity.Property(e => e.PrecioUnit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precio_unit");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIO__4E3E04AD638DD485");

                entity.ToTable("USUARIO");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("id_usuario");

                entity.Property(e => e.Contrasenia)
                    .HasMaxLength(50)
                    .HasColumnName("contrasenia");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.ImagenUrl)
                    .HasMaxLength(200)
                    .HasColumnName("imagen_url");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USUARIO__id_empl__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
