using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contexto.Migrations
{
    /// <inheritdoc />
    public partial class Unico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Moneda_Code",
                table: "Moneda",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Moneda_Code",
                table: "Moneda");
        }
    }
}
