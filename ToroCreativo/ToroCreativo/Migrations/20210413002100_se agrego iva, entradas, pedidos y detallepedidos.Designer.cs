// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToroCreativo.Models.DAL;

namespace ToroCreativo.Migrations
{
    [DbContext(typeof(DbContextToroCreativo))]
    [Migration("20210413002100_se agrego iva, entradas, pedidos y detallepedidos")]
    partial class seagregoivaentradaspedidosydetallepedidos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ToroCreativo.Models.Entities.Caracteristica", b =>
                {
                    b.Property<int>("idCaracteristicas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Medida")
                        .HasColumnName("Tamaño_idUnidades_medidas")
                        .HasColumnType("int");

                    b.Property<int>("idProducto")
                        .HasColumnName("Productos_idProductos")
                        .HasColumnType("int");

                    b.HasKey("idCaracteristicas");

                    b.ToTable("caracteristicas");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Categorias", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("idCategoria");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("ApellidoCliente")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("EstadoCliente")
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreCliente")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.DetallePedido", b =>
                {
                    b.Property<int>("IdDetallePedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdCaracteristica")
                        .HasColumnType("int");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<double>("Subtotal")
                        .HasColumnType("double");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.Property<double>("TotalIva")
                        .HasColumnType("double");

                    b.HasKey("IdDetallePedido");

                    b.ToTable("DetallePedidos");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Entrada", b =>
                {
                    b.Property<int>("idEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Caracteristica")
                        .HasColumnName("Caracteristica_idCaracteristica")
                        .HasColumnType("int");

                    b.Property<DateTime>("F_Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("idProducto")
                        .HasColumnName("Producto_idProductos")
                        .HasColumnType("int");

                    b.HasKey("idEntrada");

                    b.ToTable("entradas");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Generos", b =>
                {
                    b.Property<int>("idGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("idGenero");

                    b.ToTable("generos");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Ilustracion", b =>
                {
                    b.Property<int>("IdIlustracion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("EstadoIlustracion")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnName("NombreImagen")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreIlustracion")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdIlustracion");

                    b.ToTable("Ilustracions");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Iva", b =>
                {
                    b.Property<int>("idIva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("F_Fin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("F_Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("IVA")
                        .HasColumnName("Precio")
                        .HasColumnType("double");

                    b.Property<int>("idProducto")
                        .HasColumnName("Productos_idProductos")
                        .HasColumnType("int");

                    b.HasKey("idIva");

                    b.ToTable("ivas");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("ApellidoCliente")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("EstadoCliente")
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnName("NombreImagen")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreCliente")
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Subtotal")
                        .HasColumnType("double");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.Property<double>("TotalIva")
                        .HasColumnType("double");

                    b.HasKey("IdPedido");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Precio", b =>
                {
                    b.Property<int>("idPrecios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("F_Fin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("F_Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Valor")
                        .HasColumnName("Precio")
                        .HasColumnType("double");

                    b.Property<int>("idProducto")
                        .HasColumnName("Productos_idProductos")
                        .HasColumnType("int");

                    b.HasKey("idPrecios");

                    b.ToTable("precios");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Productos", b =>
                {
                    b.Property<int>("idProductos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Categoria")
                        .HasColumnName("Categoria_idCategorias")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("idProductos");

                    b.ToTable("productos");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Tamaño", b =>
                {
                    b.Property<int>("idTamaño")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Categoria")
                        .HasColumnName("Categoria_idCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Medida")
                        .IsRequired()
                        .HasColumnName("Tamaño")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("idTamaño");

                    b.ToTable("tamaños");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
