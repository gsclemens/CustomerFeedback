using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerFeedback.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerTypeId",
                table: "Contact");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Contact",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeId",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
