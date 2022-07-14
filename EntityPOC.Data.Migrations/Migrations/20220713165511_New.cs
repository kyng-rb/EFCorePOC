using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPOC.Data.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(686), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(1010), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(1015), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 693, DateTimeKind.Utc).AddTicks(9524), new DateTime(2022, 6, 6, 21, 45, 18, 693, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272), new DateTime(2022, 6, 6, 21, 45, 18, 696, DateTimeKind.Utc).AddTicks(7272) });
        }
    }
}
