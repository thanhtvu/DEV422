using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdoptionService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PersonalityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdoptedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdopted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "AdoptedBy", "Age", "IsAdopted", "Name", "PersonalityType", "Type" },
                values: new object[,]
                {
                    { 1, "", 3, false, "Max", "Friendly", "Dog" },
                    { 2, "", 2, false, "Garfield", "Playful", "Cat" },
                    { 3, "", 4, false, "Whiteshoes", "Protective", "Dog" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
