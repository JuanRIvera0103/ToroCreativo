using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class Usersconpedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreImagen",
                table: "Ilustracions");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Ilustracions",
                type: "nvarchar(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetallePedidos",
                columns: table => new
                {
                    IdDetallePedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPedido = table.Column<int>(nullable: false),
                    IdCaracteristica = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Subtotal = table.Column<double>(nullable: false),
                    TotalIva = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedidos", x => x.IdDetallePedido);
                });

            migrationBuilder.CreateTable(
                name: "ImagenIlustraciones",
                columns: table => new
                {
                    IdImagenIlustracion = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdIlustracion = table.Column<int>(nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenIlustraciones", x => x.IdImagenIlustracion);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ApellidoCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdUsuario = table.Column<string>(nullable: true),
                    EstadoCliente = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    FechaPedido = table.Column<DateTime>(nullable: false),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    Subtotal = table.Column<double>(nullable: false),
                    TotalIva = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    NombreImagen = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.IdPedido);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedidos");

            migrationBuilder.DropTable(
                name: "ImagenIlustraciones");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Ilustracions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)");

            migrationBuilder.AddColumn<string>(
                name: "NombreImagen",
                table: "Ilustracions",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }
    }
}
