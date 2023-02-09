using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "666a7edf-e489-4abe-b790-0b87ababc284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6c93451-1870-4dc8-bbdb-67fdcf634d01", "AQAAAAIAAYagAAAAEI7QKVSwpeeIIbaRHPJpTB2rBhi9O4ztQCNlGO2or8Lv/5vSIX3RO8Mzbpn0TUEGIw==", "063cd146-dffb-4763-8ae1-f61146231c94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca293ce2-5d46-4071-907e-211128d0fc28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29d6d8ba-aabc-42f8-909e-dd56c652773c", "AQAAAAIAAYagAAAAEBHgqV96Sc9ahNRoF2f6r0x9zD0yguaxlAJK3PHRoJXJfFg+Qc9Dt5tEPMDmNA26Ug==", "d9b475b7-2b5a-4098-ac83-640f8d18064a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "666a7edf-e489-4abe-b790-0b87ababc284",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd5aa673-71b3-4186-bc6b-d3767cdbb110", "AQAAAAIAAYagAAAAELQuL3q6Bd89UPaXdJinmUIPWxQB6o+t/l/XFCAOxFGOe8lfdxYaLo3749JajmCtTw==", "071fccff-fa59-4bce-9c4c-10342e933f4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca293ce2-5d46-4071-907e-211128d0fc28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9846d019-6345-4161-96e7-0cef991e0aa2", "AQAAAAIAAYagAAAAEO4pth7JPDg/AmxqWNd2/96dyhvWk/FuTY7jZQ7BgRfpcePe0MvH9Z/0u4N1Jmq4AA==", "b4113e01-8c50-4cd8-9caa-5cda62076311" });
        }
    }
}
