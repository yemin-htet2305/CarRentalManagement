using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1417), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1427), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1429), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1429), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1543), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1543), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1544), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1545), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1594), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1595), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1596), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1596), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1597), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1598), new DateTime(2025, 12, 3, 14, 33, 36, 454, DateTimeKind.Local).AddTicks(1598), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
