using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerFeedback.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    NameFirst = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    NameLast = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComodityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComodityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "VARCHAR(1000)", nullable: false),
                    QuestionType = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Options = table.Column<string>(type: "VARCHAR", nullable: true),
                    KpiTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_CustomerType_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Survey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(250)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdministratorId = table.Column<int>(type: "int", nullable: true),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Survey_Administrator_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrator",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Survey_CustomerType_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KpiType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KpiType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KpiType_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    QuestionId1 = table.Column<int>(type: "int", nullable: true),
                    SurveyId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Question_QuestionId1",
                        column: x => x.QuestionId1,
                        principalTable: "Question",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Survey_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Survey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyQuestion_Survey_SurveyId1",
                        column: x => x.SurveyId1,
                        principalTable: "Survey",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Team = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: true),
                    CommodityTypeId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    VPOId = table.Column<int>(type: "int", nullable: true),
                    OpsLeaderId = table.Column<int>(type: "int", nullable: true),
                    SalesRepId = table.Column<int>(type: "int", nullable: true),
                    ExecutiveId = table.Column<int>(type: "int", nullable: true),
                    KpiTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_ComodityType_CommodityTypeId",
                        column: x => x.CommodityTypeId,
                        principalTable: "ComodityType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_CustomerType_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Customer_KpiType_KpiTypeId",
                        column: x => x.KpiTypeId,
                        principalTable: "KpiType",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    Note = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    NameFirst = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    NameLast = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Answer = table.Column<string>(type: "VARCHAR(2000)", nullable: true),
                    QuestionScore = table.Column<int>(type: "int", nullable: true),
                    SurveyResponseIteration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuestionId1 = table.Column<int>(type: "int", nullable: true),
                    SurveyId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Question_QuestionId1",
                        column: x => x.QuestionId1,
                        principalTable: "Question",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Survey_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Survey",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SurveyResponse_Survey_SurveyId1",
                        column: x => x.SurveyId1,
                        principalTable: "Survey",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdministratorCustomer_CustomersId",
                table: "AdministratorCustomer",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CustomerId",
                table: "Contact",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CommodityTypeId",
                table: "Customer",
                column: "CommodityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerTypeId",
                table: "Customer",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_KpiTypeId",
                table: "Customer",
                column: "KpiTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_KpiType_QuestionId",
                table: "KpiType",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_CustomerTypeId",
                table: "Question",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Survey_AdministratorId",
                table: "Survey",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Survey_CustomerTypeId",
                table: "Survey",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_QuestionId",
                table: "SurveyQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_QuestionId1",
                table: "SurveyQuestion",
                column: "QuestionId1");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_SurveyId",
                table: "SurveyQuestion",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestion_SurveyId1",
                table: "SurveyQuestion",
                column: "SurveyId1");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_ContactId",
                table: "SurveyResponse",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_CustomerId",
                table: "SurveyResponse",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_QuestionId",
                table: "SurveyResponse",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_QuestionId1",
                table: "SurveyResponse",
                column: "QuestionId1");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_SurveyId",
                table: "SurveyResponse",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyResponse_SurveyId1",
                table: "SurveyResponse",
                column: "SurveyId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdministratorCustomer");

            migrationBuilder.DropTable(
                name: "SurveyQuestion");

            migrationBuilder.DropTable(
                name: "SurveyResponse");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Survey");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "ComodityType");

            migrationBuilder.DropTable(
                name: "KpiType");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "CustomerType");
        }
    }
}
