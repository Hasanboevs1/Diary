using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Migrations
{
    /// <inheritdoc />
    public partial class BirinchiMigratsiya : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diaries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Diaries",
                columns: new[] { "Id", "Content", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Without Goal, I have realized that I have nothing to do.", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9380), "Goal", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9380) },
                    { 2, "Without love, I have realized that I have nothing to do.", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9390), "Love", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9390) },
                    { 3, "Without happiness, I have realized that I have nothing to do.", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9390), "Happiness", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9390) },
                    { 4, "Without motivation, I have realized that I have nothing to do.", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9400), "Motivation", new DateTime(2024, 10, 11, 15, 22, 10, 729, DateTimeKind.Utc).AddTicks(9400) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diaries");
        }
    }
}
