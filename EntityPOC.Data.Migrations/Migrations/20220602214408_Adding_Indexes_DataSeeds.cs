using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPOC.Data.Migrations
{
    public partial class Adding_Indexes_DataSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cards",
                type: "varchar(95)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Boards",
                type: "varchar(95)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BoardColumns",
                type: "varchar(95)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "Name", "UpdatedAt" },
                values: new object[] { 1500, new DateTime(2022, 6, 2, 21, 44, 7, 86, DateTimeKind.Utc).AddTicks(6027), "Default board created by data seeds", "https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=dotnet-core-cli", "Default - Board", new DateTime(2022, 6, 2, 21, 44, 7, 86, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.InsertData(
                table: "BoardColumns",
                columns: new[] { "Id", "BoardId", "Color", "CreatedAt", "Description", "Header", "Name", "UpdatedAt" },
                values: new object[] { 1500, 1500, "Red", new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(4952), "Default backlog column", "Backlog", "To-Dos", new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.InsertData(
                table: "BoardColumns",
                columns: new[] { "Id", "BoardId", "Color", "CreatedAt", "Description", "Header", "Name", "UpdatedAt" },
                values: new object[] { 1501, 1500, "Blue", new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5590), "Default Current column", "Current", "Working on", new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.InsertData(
                table: "BoardColumns",
                columns: new[] { "Id", "BoardId", "Color", "CreatedAt", "Description", "Header", "Name", "UpdatedAt" },
                values: new object[] { 1502, 1500, "Green", new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5597), "Default Done column", "Done", "Completed", new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Attachment", "BoardColumnId", "CreatedAt", "Description", "Image", "Name", "Owner", "UpdatedAt" },
                values: new object[,]
                {
                    { 1000, "https://futbollibre.net/inicio/?tv", 1500, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description", "https://futbollibre.net/inicio/?tv", "Backog card 1", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1001, "https://futbollibre.net/inicio/?tv", 1500, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description 2", "https://futbollibre.net/inicio/?tv", "Backog card 2", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1002, "https://futbollibre.net/inicio/?tv", 1500, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description 3", "https://futbollibre.net/inicio/?tv", "Backog card 3", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1003, "https://futbollibre.net/inicio/?tv", 1501, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description for Current", "https://futbollibre.net/inicio/?tv", "Current card 1", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1004, "https://futbollibre.net/inicio/?tv", 1501, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description for Current 2", "https://futbollibre.net/inicio/?tv", "Current card 2", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1005, "https://futbollibre.net/inicio/?tv", 1501, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description for Current 3", "https://futbollibre.net/inicio/?tv", "Current card 3", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1006, "https://futbollibre.net/inicio/?tv", 1502, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description for Done", "https://futbollibre.net/inicio/?tv", "Done card 1", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1007, "https://futbollibre.net/inicio/?tv", 1502, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description for Done 2", "https://futbollibre.net/inicio/?tv", "Done card 2", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) },
                    { 1008, "https://futbollibre.net/inicio/?tv", 1502, new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), "Test Description for Done 3", "https://futbollibre.net/inicio/?tv", "Done card 3", "Reynaldo", new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Name",
                table: "Cards",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Boards_Name",
                table: "Boards",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_BoardColumns_Name",
                table: "BoardColumns",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cards_Name",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Boards_Name",
                table: "Boards");

            migrationBuilder.DropIndex(
                name: "IX_BoardColumns_Name",
                table: "BoardColumns");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cards",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(95)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Boards",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(95)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BoardColumns",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(95)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
