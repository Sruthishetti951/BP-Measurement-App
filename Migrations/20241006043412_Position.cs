using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BPMeasurmentApp.Migrations
{
    /// <inheritdoc />
    public partial class Position : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "BPMeasurementSet");

            migrationBuilder.AddColumn<int>(
                name: "PositionID",
                table: "BPMeasurementSet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionID);
                });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateTaken", "PositionID" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 34, 12, 59, DateTimeKind.Local).AddTicks(9712), 1 });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateTaken", "PositionID" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 34, 12, 59, DateTimeKind.Local).AddTicks(9766), 2 });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateTaken", "PositionID" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 34, 12, 59, DateTimeKind.Local).AddTicks(9768), 3 });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateTaken", "PositionID" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 34, 12, 59, DateTimeKind.Local).AddTicks(9809), 1 });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateTaken", "PositionID" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 34, 12, 59, DateTimeKind.Local).AddTicks(9813), 2 });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "PositionID", "PositionName" },
                values: new object[,]
                {
                    { 1, "Sitting" },
                    { 2, "Standing" },
                    { 3, "Lying Down" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropColumn(
                name: "PositionID",
                table: "BPMeasurementSet");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "BPMeasurementSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateTaken", "Position" },
                values: new object[] { new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7709), "" });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateTaken", "Position" },
                values: new object[] { new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7757), "" });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateTaken", "Position" },
                values: new object[] { new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7759), "" });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateTaken", "Position" },
                values: new object[] { new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7762), "" });

            migrationBuilder.UpdateData(
                table: "BPMeasurementSet",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateTaken", "Position" },
                values: new object[] { new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7764), "" });
        }
    }
}
