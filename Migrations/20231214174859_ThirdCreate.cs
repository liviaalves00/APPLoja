using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace livia.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.AlterColumn<int>(
                name: "TipoDePagamentoId",
                table: "NotaDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TipoDePagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.AlterColumn<int>(
                name: "TipoDePagamentoId",
                table: "NotaDeVenda",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TipoDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TipoDePagamento",
                principalColumn: "Id");
        }
    }
}
