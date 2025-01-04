using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradeLens.Server.Migrations
{
    /// <inheritdoc />
    public partial class StoreEnumsAsString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeeklyImage",
                table: "Trades",
                newName: "WeeklyScreenshot");

            migrationBuilder.RenameColumn(
                name: "H4Image",
                table: "Trades",
                newName: "H4Screenshot");

            migrationBuilder.RenameColumn(
                name: "DailyImage",
                table: "Trades",
                newName: "DailyScreenshot");

            migrationBuilder.AlterColumn<string>(
                name: "H4Pattern",
                table: "Trades",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "DailyPattern",
                table: "Trades",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeeklyScreenshot",
                table: "Trades",
                newName: "WeeklyImage");

            migrationBuilder.RenameColumn(
                name: "H4Screenshot",
                table: "Trades",
                newName: "H4Image");

            migrationBuilder.RenameColumn(
                name: "DailyScreenshot",
                table: "Trades",
                newName: "DailyImage");

            migrationBuilder.AlterColumn<int>(
                name: "H4Pattern",
                table: "Trades",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "DailyPattern",
                table: "Trades",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
