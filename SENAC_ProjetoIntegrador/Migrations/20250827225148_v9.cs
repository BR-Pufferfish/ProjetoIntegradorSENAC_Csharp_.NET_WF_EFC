using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SENAC_ProjetoIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VendaId",
                table: "VendaEquipamento",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "EquipamentoId",
                table: "VendaEquipamento",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Venda",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "Razaosoc",
                table: "Pessoas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "Pais",
                keyValue: null,
                column: "Pais",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Pais",
                table: "Pessoas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "Estado",
                keyValue: null,
                column: "Estado",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Pessoas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "Cidade",
                keyValue: null,
                column: "Cidade",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Pessoas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TipoEquipamento",
                table: "PecaItems",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "OrdemServicos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "OrdemServicos",
                keyColumn: "Modelo",
                keyValue: null,
                column: "Modelo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "OrdemServicos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Equipamentos",
                keyColumn: "Modelo",
                keyValue: null,
                column: "Modelo",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Equipamentos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_VendaEquipamento_EquipamentoId",
                table: "VendaEquipamento",
                column: "EquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaEquipamento_VendaId",
                table: "VendaEquipamento",
                column: "VendaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServicoPecaItem_OrdemServicoId",
                table: "OrdemServicoPecaItem",
                column: "OrdemServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServicoPecaItem_OrdemServicos_OrdemServicoId",
                table: "OrdemServicoPecaItem",
                column: "OrdemServicoId",
                principalTable: "OrdemServicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaEquipamento_Equipamentos_EquipamentoId",
                table: "VendaEquipamento",
                column: "EquipamentoId",
                principalTable: "Equipamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaEquipamento_Venda_VendaId",
                table: "VendaEquipamento",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServicoPecaItem_OrdemServicos_OrdemServicoId",
                table: "OrdemServicoPecaItem");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaEquipamento_Equipamentos_EquipamentoId",
                table: "VendaEquipamento");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaEquipamento_Venda_VendaId",
                table: "VendaEquipamento");

            migrationBuilder.DropIndex(
                name: "IX_VendaEquipamento_EquipamentoId",
                table: "VendaEquipamento");

            migrationBuilder.DropIndex(
                name: "IX_VendaEquipamento_VendaId",
                table: "VendaEquipamento");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServicoPecaItem_OrdemServicoId",
                table: "OrdemServicoPecaItem");

            migrationBuilder.AlterColumn<string>(
                name: "VendaId",
                table: "VendaEquipamento",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EquipamentoId",
                table: "VendaEquipamento",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Venda",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.UpdateData(
                table: "Pessoas",
                keyColumn: "Razaosoc",
                keyValue: null,
                column: "Razaosoc",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Razaosoc",
                table: "Pessoas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Pais",
                table: "Pessoas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Pessoas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Pessoas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PecaItems",
                keyColumn: "TipoEquipamento",
                keyValue: null,
                column: "TipoEquipamento",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TipoEquipamento",
                table: "PecaItems",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "OrdemServicos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "OrdemServicos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Equipamentos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
