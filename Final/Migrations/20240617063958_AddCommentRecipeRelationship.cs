using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentRecipeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryID",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryID",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Recipes");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    RecipeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { "Thai", new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { "American", new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { "Japanese", new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 4,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { "Italian", new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 5,
                columns: new[] { "Category", "DateTime" },
                values: new object[] { "Mexican", new DateTime(2024, 6, 16, 23, 39, 57, 649, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RecipeID",
                table: "Comments",
                column: "RecipeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1,
                columns: new[] { "CategoryID", "DateTime" },
                values: new object[] { 1, new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2,
                columns: new[] { "CategoryID", "DateTime" },
                values: new object[] { 2, new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3,
                columns: new[] { "CategoryID", "DateTime" },
                values: new object[] { 3, new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 4,
                columns: new[] { "CategoryID", "DateTime" },
                values: new object[] { 4, new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 5,
                columns: new[] { "CategoryID", "DateTime" },
                values: new object[] { 5, new DateTime(2024, 6, 10, 20, 41, 39, 99, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryID",
                table: "Recipes",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryID",
                table: "Recipes",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
