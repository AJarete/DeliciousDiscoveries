using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Recipes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9227));
        }
    }
}
