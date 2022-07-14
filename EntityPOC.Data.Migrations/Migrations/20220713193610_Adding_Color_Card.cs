using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPOC.Data.Migrations
{
    public partial class Adding_Color_Card : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Boards",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "color",
                table: "Boards");

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 704, DateTimeKind.Utc).AddTicks(3827), new DateTime(2022, 7, 13, 16, 55, 9, 704, DateTimeKind.Utc).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 704, DateTimeKind.Utc).AddTicks(4459), new DateTime(2022, 7, 13, 16, 55, 9, 704, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 704, DateTimeKind.Utc).AddTicks(4500), new DateTime(2022, 7, 13, 16, 55, 9, 704, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 700, DateTimeKind.Utc).AddTicks(2157), new DateTime(2022, 7, 13, 16, 55, 9, 700, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893), new DateTime(2022, 7, 13, 16, 55, 9, 705, DateTimeKind.Utc).AddTicks(5893) });
        }
    }
}
