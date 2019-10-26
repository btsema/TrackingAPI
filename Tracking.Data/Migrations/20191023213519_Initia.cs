using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tracking.Data.Migrations
{
    public partial class Initia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Web = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyUnits",
                columns: table => new
                {
                    CompanyUnitId = table.Column<Guid>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    XCoorinate = table.Column<int>(nullable: false),
                    YCoorinate = table.Column<int>(nullable: false),
                    CompanyUnitType = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUnits", x => x.CompanyUnitId);
                    table.ForeignKey(
                        name: "FK_CompanyUnits_Company_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUnits_CustomerId",
                table: "CompanyUnits",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyUnits");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
