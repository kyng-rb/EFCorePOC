using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPOC.Data.Migrations
{
    public partial class Adding_DeletedAt_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Cards",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Boards",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "BoardColumns",
                type: "datetime(6)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Boards");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "BoardColumns");

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(4952), new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5590), new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "BoardColumns",
                keyColumn: "Id",
                keyValue: 1502,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5597), new DateTime(2022, 6, 2, 21, 44, 7, 90, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1500,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 86, DateTimeKind.Utc).AddTicks(6027), new DateTime(2022, 6, 2, 21, 44, 7, 86, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231), new DateTime(2022, 6, 2, 21, 44, 7, 92, DateTimeKind.Utc).AddTicks(3231) });
        }
    }
}
