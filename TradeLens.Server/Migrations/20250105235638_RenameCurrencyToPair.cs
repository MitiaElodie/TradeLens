using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradeLens.Server.Migrations
{
    /// <inheritdoc />
    public partial class RenameCurrencyToPair : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "Trades",
                newName: "Pair");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pair",
                table: "Trades",
                newName: "Currency");
        }
    }
}
