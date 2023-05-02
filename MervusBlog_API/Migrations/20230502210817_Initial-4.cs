using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MervusBlog_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublishedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(900), new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(900), new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(850), new DateTime(2023, 5, 2, 21, 8, 17, 766, DateTimeKind.Utc).AddTicks(850) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 5, 2, 21, 5, 50, 467, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2023, 5, 2, 21, 5, 50, 467, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PublishedDate", "UpdatedDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 2, 21, 5, 50, 467, DateTimeKind.Utc).AddTicks(5650), new DateTime(2023, 5, 2, 21, 5, 50, 467, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RegisteredDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 2, 21, 5, 50, 467, DateTimeKind.Utc).AddTicks(5670), new DateTime(2023, 5, 2, 21, 5, 50, 467, DateTimeKind.Utc).AddTicks(5670) });
        }
    }
}
