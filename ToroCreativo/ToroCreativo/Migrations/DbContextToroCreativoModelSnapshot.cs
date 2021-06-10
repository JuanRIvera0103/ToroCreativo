﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToroCreativo.Models.DAL;

namespace ToroCreativo.Migrations
{
    [DbContext(typeof(DbContextToroCreativo))]
    partial class DbContextToroCreativoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.CalificacionProducto", b =>
                {
                    b.Property<int>("IdCalificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Calificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuario")
                        .HasColumnName("IdUsuario")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdCalificacion");

                    b.ToTable("CalificacionProductos");
                });

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
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

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

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnName("IdUsuario")
                        .HasColumnType("varchar(255)");

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

            modelBuilder.Entity("ToroCreativo.Models.Entities.Comentario", b =>
                {
                    b.Property<int>("IdComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("IdIlustracion")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnName("IdUsuario")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdComentario");

                    b.ToTable("Comentarios");
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

                    b.Property<int>("CantidadActual")
                        .HasColumnType("int");

                    b.Property<int>("CantidadInicial")
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
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

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
                        .HasColumnName("Descripcion")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("EstadoIlustracion")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("NombreIlustracion")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdIlustracion");

                    b.ToTable("Ilustracions");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.ImagenIlustracion", b =>
                {
                    b.Property<int>("IdImagenIlustracion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("IdIlustracion")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnName("NombreImagen")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdImagenIlustracion");

                    b.ToTable("ImagenIlustraciones");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.ImagenProducto", b =>
                {
                    b.Property<int>("IdImagenProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnName("NombreImagen")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdImagenProducto");

                    b.ToTable("ImagenProductos");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Iva", b =>
                {
                    b.Property<int>("idIva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("F_Fin")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("F_Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("IVA")
                        .HasColumnType("double");

                    b.Property<int>("idProducto")
                        .HasColumnName("Productos_idProductos")
                        .HasColumnType("int");

                    b.HasKey("idIva");

                    b.ToTable("ivas");
                });

            modelBuilder.Entity("ToroCreativo.Models.Entities.Notificacion", b =>
                {
                    b.Property<int>("IdNotificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Direccion")
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnName("IdUsuario")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Leido")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("IdNotificacion");

                    b.ToTable("Notificaciones");
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

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnName("IdUsuario")
                        .HasColumnType("varchar(255)");

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

                    b.Property<DateTime?>("F_Fin")
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
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
