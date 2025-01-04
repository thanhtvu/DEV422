using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthMonitoringService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HealthStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    IsHealthy = table.Column<bool>(type: "bit", nullable: false),
                    AlertMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastChecked = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HealthStatuses",
                columns: new[] { "Id", "AlertMessage", "IsHealthy", "LastChecked", "PetId" },
                values: new object[,]
                {
                    { 1, "Pet is healthy!", true, new DateTime(2024, 11, 25, 18, 29, 35, 514, DateTimeKind.Local).AddTicks(3299), 1 },
                    { 2, "Pet is healthy!", true, new DateTime(2024, 11, 25, 18, 29, 35, 519, DateTimeKind.Local).AddTicks(2180), 2 },
                    { 3, "Pet is healthy!", true, new DateTime(2024, 11, 25, 18, 29, 35, 519, DateTimeKind.Local).AddTicks(2235), 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthStatuses");
        }
    }
}
