using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TradeLens.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    H4Confirmation = table.Column<int>(type: "integer", nullable: false),
                    H4Image = table.Column<string>(type: "text", nullable: false),
                    DailyConfirmation = table.Column<int>(type: "integer", nullable: false),
                    DailyImage = table.Column<string>(type: "text", nullable: false),
                    WeeklyImage = table.Column<string>(type: "text", nullable: false),
                    WeeklyCandleClose = table.Column<bool>(type: "boolean", nullable: false),
                    WeeklySupplyAndDemand = table.Column<bool>(type: "boolean", nullable: false),
                    WeeklyMarketStructure = table.Column<bool>(type: "boolean", nullable: false),
                    WeeklyFibonacci = table.Column<bool>(type: "boolean", nullable: false),
                    RiskReward = table.Column<double>(type: "double precision", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Currency = table.Column<int>(type: "integer", nullable: false),
                    WeeklyHighLow = table.Column<bool>(type: "boolean", nullable: true),
                    WeeklyPattern = table.Column<bool>(type: "boolean", nullable: true),
                    WeeklyIC = table.Column<bool>(type: "boolean", nullable: true),
                    WeeklyFibCompletion = table.Column<bool>(type: "boolean", nullable: true),
                    DailyBreakAndRetest = table.Column<bool>(type: "boolean", nullable: true),
                    DailySupplyAndDemand = table.Column<bool>(type: "boolean", nullable: true),
                    DailyNewActionFakeout = table.Column<bool>(type: "boolean", nullable: true),
                    Result = table.Column<int>(type: "integer", nullable: true),
                    Missed = table.Column<bool>(type: "boolean", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trades");
        }
    }
}
