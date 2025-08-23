using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SENAC_ProjetoIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "PecaItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "PecaItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TipoEquipamento",
                table: "PecaItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "PecaItems");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "PecaItems");

            migrationBuilder.DropColumn(
                name: "TipoEquipamento",
                table: "PecaItems");
        }
    }
}
