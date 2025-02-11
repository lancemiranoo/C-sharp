using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Contacts.Migrations
{
    /// <inheritdoc />
    public partial class Organization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Contacts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Organization",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "A", "Friend" },
                    { "B", "Work" },
                    { "C", "Family" },
                    { "D", "Acquaintance" }
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                columns: new[] { "CategoryId", "DateAdded", "Organization" },
                values: new object[] { "A", new DateTime(2025, 2, 11, 0, 45, 23, 835, DateTimeKind.Local).AddTicks(5336), " " });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateAdded", "Organization" },
                values: new object[] { "B", new DateTime(2025, 2, 11, 0, 45, 23, 837, DateTimeKind.Local).AddTicks(4877), " " });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateAdded", "Organization" },
                values: new object[] { "C", new DateTime(2025, 2, 11, 0, 45, 23, 837, DateTimeKind.Local).AddTicks(4895), " " });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryId",
                table: "Contacts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Categories_CategoryId",
                table: "Contacts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Categories_CategoryId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CategoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Organization",
                table: "Contacts");
        }
    }
}
