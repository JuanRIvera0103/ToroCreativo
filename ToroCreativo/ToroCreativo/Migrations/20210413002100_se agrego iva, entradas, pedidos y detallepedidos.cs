using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class seagregoivaentradaspedidosydetallepedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "entradas",
                columns: table => new
                {
                    idEntrada = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(nullable: false),
                    F_Inicio = table.Column<DateTime>(nullable: false),
                    Caracteristica_idCaracteristica = table.Column<int>(nullable: false),
                    Producto_idProductos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entradas", x => x.idEntrada);
                });

            migrationBuilder.CreateTable(
                name: "ivas",
                columns: table => new
                {
                    idIva = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Precio = table.Column<double>(nullable: false),
                    F_Inicio = table.Column<DateTime>(nullable: false),
                    F_Fin = table.Column<DateTime>(nullable: false),
                    Productos_idProductos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ivas", x => x.idIva);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ApellidoCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
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
                name: "entradas");

            migrationBuilder.DropTable(
                name: "ivas");

            migrationBuilder.DropTable(
                name: "Pedidos");
        }
    }
}
