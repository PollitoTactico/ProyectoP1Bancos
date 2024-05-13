using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoP1Bancos.Migrations
{
    /// <inheritdoc />
    public partial class nueva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumCuenta",
                table: "Usuario");

            migrationBuilder.CreateTable(
                name: "RegistroUsuario",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroUsuario", x => x.IdRegistro);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroUsuario");

            migrationBuilder.AddColumn<string>(
                name: "NumCuenta",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
