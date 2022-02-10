using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerFeedback.Migrations
{
    public partial class UpdateDataTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_ComodityType_CommodityTypeId",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComodityType",
                table: "ComodityType");

            migrationBuilder.RenameTable(
                name: "ComodityType",
                newName: "CommodityType");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "KpiType",
                type: "VARCHAR(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CommodityType",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommodityType",
                table: "CommodityType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_CommodityType_CommodityTypeId",
                table: "Customer",
                column: "CommodityTypeId",
                principalTable: "CommodityType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_CommodityType_CommodityTypeId",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommodityType",
                table: "CommodityType");

            migrationBuilder.RenameTable(
                name: "CommodityType",
                newName: "ComodityType");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "KpiType",
                type: "VARCHAR(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ComodityType",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComodityType",
                table: "ComodityType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_ComodityType_CommodityTypeId",
                table: "Customer",
                column: "CommodityTypeId",
                principalTable: "ComodityType",
                principalColumn: "Id");
        }
    }
}
