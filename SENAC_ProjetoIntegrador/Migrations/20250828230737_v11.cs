using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SENAC_ProjetoIntegrador.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "Venda",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtEncerramento",
                table: "Servicos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "Servicos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtEncerramento",
                table: "Pessoas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "Pessoas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtEncerramento",
                table: "PecaItems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "PecaItems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtEncerramento",
                table: "OrdemServicos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "OrdemServicos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtEncerramento",
                table: "Equipamentos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "Equipamentos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "DtEncerramento",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "DtEncerramento",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DtEncerramento",
                table: "PecaItems");

            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "PecaItems");

            migrationBuilder.DropColumn(
                name: "DtEncerramento",
                table: "OrdemServicos");

            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "OrdemServicos");

            migrationBuilder.DropColumn(
                name: "DtEncerramento",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "Equipamentos");
        }
    }
}
