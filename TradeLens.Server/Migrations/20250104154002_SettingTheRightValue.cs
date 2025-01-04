using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradeLens.Server.Migrations
{
    /// <inheritdoc />
    public partial class SettingTheRightValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "H4Confirmation",
                table: "Trades",
                newName: "H4Pattern");

            migrationBuilder.RenameColumn(
                name: "DailyConfirmation",
                table: "Trades",
                newName: "DailyPattern");

            migrationBuilder.AlterColumn<double>(
                name: "RiskReward",
                table: "Trades",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");
            migrationBuilder.RenameColumn(
                name: "RiskReward",
                table: "Trades",
                newName: "Profit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CloseDate",
                table: "Trades",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "H4Pattern",
                table: "Trades",
                newName: "H4Confirmation");

            migrationBuilder.RenameColumn(
                name: "DailyPattern",
                table: "Trades",
                newName: "DailyConfirmation");

            migrationBuilder.AlterColumn<double>(
                name: "Profit",
                table: "Trades",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CloseDate",
                table: "Trades",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }
    }
}
