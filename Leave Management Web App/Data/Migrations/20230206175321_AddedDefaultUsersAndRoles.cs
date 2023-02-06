using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "585a7edf-e489-474e-b790-0b8741abc284", null, "Administrator", "ADMINISTRATOR" },
                    { "58aa48df-ef80-474e-b790-0b8bce89c284", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "666a7edf-e489-4abe-b790-0b87ababc284", 0, "8841d69e-ba51-4aae-84dd-974d83992b92", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEHToGEmacE3Y8rkIXHGZYrhw4V9/xFihqEOxLd/HCNj6dGiGoEPRR1mkHJn7sxsz0w==", null, false, "97c7ccaa-e88b-46cc-8bed-f4d2caeebba7", null, false, null },
                    { "ca293ce2-5d46-4071-907e-211128d0fc28", 0, "b47b4aba-87f9-47f2-8116-f29f9fd12f40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEOT0Bd1uistHHA5kaTZRFCPKfjpMv1uZ8YI68gMS9ekqz92X5zIMmCohGioFgrqt8g==", null, false, "e7c1c55d-2127-4bbd-96e8-18dfdab9a5dd", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "585a7edf-e489-474e-b790-0b8741abc284", "666a7edf-e489-4abe-b790-0b87ababc284" },
                    { "58aa48df-ef80-474e-b790-0b8bce89c284", "ca293ce2-5d46-4071-907e-211128d0fc28" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "585a7edf-e489-474e-b790-0b8741abc284", "666a7edf-e489-4abe-b790-0b87ababc284" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "58aa48df-ef80-474e-b790-0b8bce89c284", "ca293ce2-5d46-4071-907e-211128d0fc28" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "585a7edf-e489-474e-b790-0b8741abc284");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58aa48df-ef80-474e-b790-0b8bce89c284");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "666a7edf-e489-4abe-b790-0b87ababc284");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca293ce2-5d46-4071-907e-211128d0fc28");
        }
    }
}
