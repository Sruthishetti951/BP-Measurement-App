using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BPMeasurmentApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BPMeasurementSet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Systolic = table.Column<int>(type: "int", nullable: false),
                    Diastolic = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTaken = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPMeasurementSet", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "BPMeasurementSet",
                columns: new[] { "ID", "Category", "DateTaken", "Diastolic", "Position", "Systolic" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7709), 70, "", 110 },
                    { 2, "", new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7757), 12, "", 180 },
                    { 3, "", new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7759), 90, "", 140 },
                    { 4, "", new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7762), 85, "", 130 },
                    { 5, "", new DateTime(2024, 10, 4, 13, 15, 40, 17, DateTimeKind.Local).AddTicks(7764), 65, "", 121 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BPMeasurementSet");
        }
    }
}
