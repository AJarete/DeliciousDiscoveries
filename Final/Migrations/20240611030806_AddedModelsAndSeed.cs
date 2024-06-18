using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final.Migrations
{
    /// <inheritdoc />
    public partial class AddedModelsAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeID);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Thai" },
                    { 2, "American" },
                    { 3, "Japanese" },
                    { 4, "Italian" },
                    { 5, "Mexican" },
                    { 6, "Mediterranean" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeID", "CategoryID", "DateTime", "Ingredients", "Instructions", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 10, 20, 8, 6, 95, DateTimeKind.Local).AddTicks(8599), "Rice noodles, tofu, shrimp, peanuts, green onions, bean sprouts, lime wedges, Thai sauce", "1. Cook rice noodles according to package instructions. 2. In a large skillet, heat oil and add tofu and shrimp. Cook until shrimp is pink and tofu is golden. 3. Add green onions and cook for another minute. 4. Stir in cooked noodles and Thai sauce, toss to coat. 5. Serve with peanuts, bean sprouts, and lime wedges.", "Pad Thai" },
                    { 2, 2, new DateTime(2024, 6, 10, 20, 8, 6, 95, DateTimeKind.Local).AddTicks(8646), "Beef patty, hamburger buns, cheddar cheese, lettuce, tomato, onion, pickles, ketchup, mustard", "1. Preheat grill to medium-high heat. 2. Grill beef patties for 4-5 minutes on each side until desired doneness. 3. During the last minute of cooking, place a slice of cheese on each patty and close the grill lid. 4. Toast hamburger buns on the grill for 1-2 minutes. 5. Assemble burgers by placing lettuce, tomato, onion, and pickles on the bottom bun. Add the beef patty with melted cheese and top with ketchup and mustard. Place the top bun on and serve.", "Cheeseburger" },
                    { 3, 3, new DateTime(2024, 6, 10, 20, 8, 6, 95, DateTimeKind.Local).AddTicks(8649), "Sushi rice, nori (seaweed sheets), fresh fish (tuna, salmon), cucumber, avocado, soy sauce, wasabi, pickled ginger", "1. Rinse sushi rice until the water runs clear, then cook according to package instructions. 2. Allow rice to cool slightly, then season with rice vinegar. 3. Place a sheet of nori on a bamboo sushi mat. Spread a thin layer of rice over the nori, leaving a small border at the top. 4. Place fish, cucumber, and avocado along the bottom edge of the nori. 5. Roll the sushi tightly using the bamboo mat. 6. Slice the sushi roll into bite-sized pieces. Serve with soy sauce, wasabi, and pickled ginger.", "Sushi" },
                    { 4, 4, new DateTime(2024, 6, 10, 20, 8, 6, 95, DateTimeKind.Local).AddTicks(8651), "Pizza dough, Tomato sauce, Fresh mozzarella cheese, Fresh basil leaves, Olive oil, Salt and pepper to taste", "1. Preheat the oven to 475°F (245°C). 2. Roll out the pizza dough and spread tomato sauce evenly. 3. Top with slices of fresh mozzarella and fresh basil leaves. 4. Drizzle with olive oil and season with salt and pepper. 5. Bake in the preheated oven for 12-15 minutes or until the crust is golden brown. 6. Slice and serve hot.", "Classic Margherita Pizza" },
                    { 5, 5, new DateTime(2024, 6, 10, 20, 8, 6, 95, DateTimeKind.Local).AddTicks(8653), "Chicken thighs, Diced mango, Finely chopped red onion, Chopped cilantro, Lime juice, Minced Jalapeño, Salt and pepper to taste, Cooked rice for serving", "1. Season chicken thighs with salt and pepper. 2. Grill or bake chicken until fully cooked. 3. In a bowl, combine diced mango, chopped red onion, cilantro, minced jalapeño, and lime juice. 4. Dice the cooked chicken and mix it with the mango salsa. 5. Serve over cooked rice.", "Mango Salsa Chicken" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryID",
                table: "Recipes",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
