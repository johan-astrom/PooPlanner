using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PooPlanner.Domain.Migrations
{
    public partial class DishChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dishes",
                newName: "DishName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DishName",
                table: "Dishes",
                newName: "Name");
        }
    }
}
