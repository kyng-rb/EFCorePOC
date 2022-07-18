using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPOC.Data.Migrations
{
    public partial class Labels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BackgroundImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CardLabel",
                columns: table => new
                {
                    CardsId = table.Column<int>(type: "int", nullable: false),
                    LabelsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardLabel", x => new { x.CardsId, x.LabelsId });
                    table.ForeignKey(
                        name: "FK_CardLabel_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardLabel_Labels_LabelsId",
                        column: x => x.LabelsId,
                        principalTable: "Labels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 379, DateTimeKind.Utc).AddTicks(8865), new DateTime(2022, 7, 18, 16, 59, 47, 379, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 379, DateTimeKind.Utc).AddTicks(9282), new DateTime(2022, 7, 18, 16, 59, 47, 379, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 379, DateTimeKind.Utc).AddTicks(9351), new DateTime(2022, 7, 18, 16, 59, 47, 379, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 377, DateTimeKind.Utc).AddTicks(532), new DateTime(2022, 7, 18, 16, 59, 47, 377, DateTimeKind.Utc).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981), new DateTime(2022, 7, 18, 16, 59, 47, 380, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.CreateIndex(
                name: "IX_CardLabel_LabelsId",
                table: "CardLabel",
                column: "LabelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardLabel");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 872, DateTimeKind.Utc).AddTicks(2445), new DateTime(2022, 7, 13, 19, 36, 8, 872, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 872, DateTimeKind.Utc).AddTicks(3190), new DateTime(2022, 7, 13, 19, 36, 8, 872, DateTimeKind.Utc).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 872, DateTimeKind.Utc).AddTicks(3245), new DateTime(2022, 7, 13, 19, 36, 8, 872, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 868, DateTimeKind.Utc).AddTicks(5606), new DateTime(2022, 7, 13, 19, 36, 8, 868, DateTimeKind.Utc).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448), new DateTime(2022, 7, 13, 19, 36, 8, 873, DateTimeKind.Utc).AddTicks(4448) });
        }
    }
}
