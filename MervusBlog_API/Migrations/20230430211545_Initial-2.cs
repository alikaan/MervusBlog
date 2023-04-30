using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MervusBlog_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 4, 30, 21, 15, 45, 396, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2023, 4, 30, 21, 15, 45, 396, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 21, 15, 45, 396, DateTimeKind.Utc).AddTicks(2720), new DateTime(2023, 4, 30, 21, 15, 45, 396, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 21, 15, 45, 396, DateTimeKind.Utc).AddTicks(2740), new DateTime(2023, 4, 30, 21, 15, 45, 396, DateTimeKind.Utc).AddTicks(2740) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 21, 6, 43, 205, DateTimeKind.Utc).AddTicks(5550), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 30, 21, 6, 43, 205, DateTimeKind.Utc).AddTicks(5570), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
