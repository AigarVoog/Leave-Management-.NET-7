using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "666a7edf-e489-4abe-b790-0b87ababc284",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bd5aa673-71b3-4186-bc6b-d3767cdbb110", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELQuL3q6Bd89UPaXdJinmUIPWxQB6o+t/l/XFCAOxFGOe8lfdxYaLo3749JajmCtTw==", "071fccff-fa59-4bce-9c4c-10342e933f4a", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca293ce2-5d46-4071-907e-211128d0fc28",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9846d019-6345-4161-96e7-0cef991e0aa2", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEO4pth7JPDg/AmxqWNd2/96dyhvWk/FuTY7jZQ7BgRfpcePe0MvH9Z/0u4N1Jmq4AA==", "b4113e01-8c50-4cd8-9caa-5cda62076311", "user@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "666a7edf-e489-4abe-b790-0b87ababc284",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8841d69e-ba51-4aae-84dd-974d83992b92", false, null, "AQAAAAIAAYagAAAAEHToGEmacE3Y8rkIXHGZYrhw4V9/xFihqEOxLd/HCNj6dGiGoEPRR1mkHJn7sxsz0w==", "97c7ccaa-e88b-46cc-8bed-f4d2caeebba7", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca293ce2-5d46-4071-907e-211128d0fc28",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b47b4aba-87f9-47f2-8116-f29f9fd12f40", false, null, "AQAAAAIAAYagAAAAEOT0Bd1uistHHA5kaTZRFCPKfjpMv1uZ8YI68gMS9ekqz92X5zIMmCohGioFgrqt8g==", "e7c1c55d-2127-4bbd-96e8-18dfdab9a5dd", null });
        }
    }
}
