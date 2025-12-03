using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleUserUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b2c9f95c-bc5c-4c96-8c46-441e8b18ba67", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENWmQIK+B8YqjroZL8CSzs5Ysfvy39zq93RYN/fydpXg9703aIQ+InQiUZpXm6avyg==", null, false, "0239a9ba-c5d0-42ac-b87f-4d7049470494", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1859), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1872), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1985), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1986), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2049), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2050), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2051), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2077), new DateTime(2025, 12, 3, 15, 59, 56, 244, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
    }
}
