using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PooPlanner.Domain.Migrations
{
    public partial class AddedMedication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Medicines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
