using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerFeedback.Migrations
{
    public partial class UpdateDataTypes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdministratorCustomer");

            migrationBuilder.DropColumn(
                name: "ExecutiveId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "OpsLeaderId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SalesRepId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "VPOId",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExecutiveId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpsLeaderId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalesRepId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "Customer",
                type: "VARCHAR(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VPOId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdministratorCustomer",
                columns: table => new
                {
                    AdministratorsId = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministratorCustomer", x => new { x.AdministratorsId, x.CustomersId });
                    table.ForeignKey(
                        name: "FK_AdministratorCustomer_Administrator_AdministratorsId",
                        column: x => x.AdministratorsId,
                        principalTable: "Administrator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdministratorCustomer_Customer_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdministratorCustomer_CustomersId",
                table: "AdministratorCustomer",
                column: "CustomersId");
        }
    }
}
