using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MervusBlog_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "PostComments");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Posts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                column: "CategoryId",
                value: 1);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PostComments",
                type: "text",
                nullable: false,
                defaultValue: "");

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
    }
}
