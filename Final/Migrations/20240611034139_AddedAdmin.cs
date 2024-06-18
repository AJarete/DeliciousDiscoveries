using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8055));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 36, 17, 143, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 36, 17, 143, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 36, 17, 143, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 36, 17, 143, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 6, 10, 20, 36, 17, 144, DateTimeKind.Local).AddTicks(1));
        }
    }
}
