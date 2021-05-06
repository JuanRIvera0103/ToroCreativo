using Microsoft.EntityFrameworkCore.Migrations;

namespace ToroCreativo.Migrations
{
    public partial class SeagregoCambiosdelSprintdeJD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {            
            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "Pedidos",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "Clientes",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "categorias",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "Pedidos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "Clientes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "categorias",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
