using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeetingOrganizer.API.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Participants",
                table: "Meetings",
                type: "text",
                nullable: false,
                oldClrType: typeof(List<string>),
                oldType: "text[]");

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "EndTime", "Participants", "StartTime", "Subject" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7710), new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7710), "A,B,C", new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7710), "Interview" },
                    { 2, new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7720), "A,D,C", new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7720), "Interview1" },
                    { 3, new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7720), "A,D,E", new DateTime(2024, 2, 20, 22, 54, 36, 297, DateTimeKind.Utc).AddTicks(7720), "Interview2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<List<string>>(
                name: "Participants",
                table: "Meetings",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
