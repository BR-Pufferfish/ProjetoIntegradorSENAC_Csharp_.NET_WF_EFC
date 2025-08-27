using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SENAC_ProjetoIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lucro",
                table: "PecaItems");

            migrationBuilder.DropColumn(
                name: "Lucro",
                table: "Equipamentos");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Venda",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                table: "PecaItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                table: "Equipamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServicoServico_OrdemServicoId",
                table: "OrdemServicoServico",
                column: "OrdemServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServicoServico_OrdemServicos_OrdemServicoId",
                table: "OrdemServicoServico",
                column: "OrdemServicoId",
                principalTable: "OrdemServicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServicoServico_OrdemServicos_OrdemServicoId",
                table: "OrdemServicoServico");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServicoServico_OrdemServicoId",
                table: "OrdemServicoServico");

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "PecaItems");

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "Equipamentos");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Venda",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AddColumn<decimal>(
                name: "Lucro",
                table: "PecaItems",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Lucro",
                table: "Equipamentos",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
