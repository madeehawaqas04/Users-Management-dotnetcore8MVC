using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthAuthorization.Migrations
{
    /// <inheritdoc />
    public partial class addpatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bc8a1ca-3cfa-4afe-b6d0-c0b23e973c21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "846715f3-f4d5-4bbf-a8f1-0d1329b8df85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a60a6552-b4a5-454b-8d9b-c39987986b15");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d11e1ec-7b05-4e3c-bd17-a459cf9f902e", null, "seller", "seller" },
                    { "ceb4a258-6f6a-4df0-b472-48de58d8524e", null, "admin", "admin" },
                    { "e00ed8af-dbaf-4241-9a83-22a852cc596b", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d11e1ec-7b05-4e3c-bd17-a459cf9f902e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceb4a258-6f6a-4df0-b472-48de58d8524e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e00ed8af-dbaf-4241-9a83-22a852cc596b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bc8a1ca-3cfa-4afe-b6d0-c0b23e973c21", null, "admin", "admin" },
                    { "846715f3-f4d5-4bbf-a8f1-0d1329b8df85", null, "seller", "seller" },
                    { "a60a6552-b4a5-454b-8d9b-c39987986b15", null, "client", "client" }
                });
        }
    }
}
