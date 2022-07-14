﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPOC.Data.Migrations
{
    public partial class Updating_DeletedAt_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1254), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1592), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1597), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 146, DateTimeKind.Utc).AddTicks(6910), new DateTime(2022, 6, 6, 21, 35, 30, 146, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937), new DateTime(2022, 6, 6, 21, 35, 30, 149, DateTimeKind.Utc).AddTicks(9937) });
        }
    }
}
