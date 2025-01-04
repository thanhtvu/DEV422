using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CareService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetCares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    LastFed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastPlayed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HappinessLevel = table.Column<int>(type: "int", nullable: false),
                    HungerLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCares", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PetCares",
                columns: new[] { "Id", "HappinessLevel", "HungerLevel", "LastFed", "LastPlayed", "PetId" },
                values: new object[,]
                {
                    { 1, 50, 50, new DateTime(2024, 11, 25, 18, 15, 54, 956, DateTimeKind.Local).AddTicks(4237), new DateTime(2024, 11, 25, 18, 15, 54, 961, DateTimeKind.Local).AddTicks(1892), 1 },
                    { 2, 50, 50, new DateTime(2024, 11, 25, 18, 15, 54, 961, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 11, 25, 18, 15, 54, 961, DateTimeKind.Local).AddTicks(4016), 2 },
                    { 3, 50, 50, new DateTime(2024, 11, 25, 18, 15, 54, 961, DateTimeKind.Local).AddTicks(4021), new DateTime(2024, 11, 25, 18, 15, 54, 961, DateTimeKind.Local).AddTicks(4023), 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetCares");
        }
    }
}
