using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradeLens.Server.Migrations
{
    /// <inheritdoc />
    public partial class RenameToLastCandleClose : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeeklyCandleClose",
                table: "Trades",
                newName: "WeeklyLastCandleClose");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeeklyLastCandleClose",
                table: "Trades",
                newName: "WeeklyCandleClose");
        }
    }
}
