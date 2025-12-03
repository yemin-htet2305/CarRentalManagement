using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(886), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(897), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1092), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1094), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1154), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1156), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1157), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1159), new DateTime(2025, 12, 3, 15, 49, 9, 431, DateTimeKind.Local).AddTicks(1159) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1474), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1486), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1610), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1612), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1666), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1667), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1669), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1670), new DateTime(2025, 12, 3, 15, 36, 26, 83, DateTimeKind.Local).AddTicks(1670) });
        }
    }
}
