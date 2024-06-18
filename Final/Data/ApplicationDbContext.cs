using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Final.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Thai" },
                new Category { CategoryID = 2, Name = "American" },
                new Category { CategoryID = 3, Name = "Japanese" },
                new Category { CategoryID = 4, Name = "Italian" },
                new Category { CategoryID = 5, Name = "Mexican" },
                new Category { CategoryID = 6, Name = "Mediterranean" }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    RecipeID = 1,
                    Title = "Pad Thai",
                    Ingredients = "Rice noodles, tofu, shrimp, peanuts, green onions, bean sprouts, lime wedges, Thai sauce",
                    Instructions = "1. Cook rice noodles according to package instructions. 2. In a large skillet, heat oil and add tofu and shrimp. Cook until shrimp is pink and tofu is golden. 3. Add green onions and cook for another minute. 4. Stir in cooked noodles and Thai sauce, toss to coat. 5. Serve with peanuts, bean sprouts, and lime wedges.",
                    Category = "Thai"
                },
                new Recipe
                {
                    RecipeID = 2,
                    Title = "Cheeseburger",
                    Ingredients = "Beef patty, hamburger buns, cheddar cheese, lettuce, tomato, onion, pickles, ketchup, mustard",
                    Instructions = "1. Preheat grill to medium-high heat. 2. Grill beef patties for 4-5 minutes on each side until desired doneness. 3. During the last minute of cooking, place a slice of cheese on each patty and close the grill lid. 4. Toast hamburger buns on the grill for 1-2 minutes. 5. Assemble burgers by placing lettuce, tomato, onion, and pickles on the bottom bun. Add the beef patty with melted cheese and top with ketchup and mustard. Place the top bun on and serve.",
                    Category = "American"
                },
                new Recipe
                {
                    RecipeID = 3,
                    Title = "Sushi",
                    Ingredients = "Sushi rice, nori (seaweed sheets), fresh fish (tuna, salmon), cucumber, avocado, soy sauce, wasabi, pickled ginger",
                    Instructions = "1. Rinse sushi rice until the water runs clear, then cook according to package instructions. 2. Allow rice to cool slightly, then season with rice vinegar. 3. Place a sheet of nori on a bamboo sushi mat. Spread a thin layer of rice over the nori, leaving a small border at the top. 4. Place fish, cucumber, and avocado along the bottom edge of the nori. 5. Roll the sushi tightly using the bamboo mat. 6. Slice the sushi roll into bite-sized pieces. Serve with soy sauce, wasabi, and pickled ginger.",
                    Category = "Japanese"
                },
                new Recipe
                {
                    RecipeID = 4,
                    Title = "Classic Margherita Pizza",
                    Ingredients = "Pizza dough, Tomato sauce, Fresh mozzarella cheese, Fresh basil leaves, Olive oil, Salt and pepper to taste",
                    Instructions = "1. Preheat the oven to 475°F (245°C). 2. Roll out the pizza dough and spread tomato sauce evenly. 3. Top with slices of fresh mozzarella and fresh basil leaves. 4. Drizzle with olive oil and season with salt and pepper. 5. Bake in the preheated oven for 12-15 minutes or until the crust is golden brown. 6. Slice and serve hot.",
                    Category = "Italian"
                },
                new Recipe
                {
                    RecipeID = 5,
                    Title = "Mango Salsa Chicken",
                    Ingredients = "Chicken thighs, Diced mango, Finely chopped red onion, Chopped cilantro, Lime juice, Minced Jalapeño, Salt and pepper to taste, Cooked rice for serving",
                    Instructions = "1. Season chicken thighs with salt and pepper. 2. Grill or bake chicken until fully cooked. 3. In a bowl, combine diced mango, chopped red onion, cilantro, minced jalapeño, and lime juice. 4. Dice the cooked chicken and mix it with the mango salsa. 5. Serve over cooked rice.",
                    Category = "Mexican"
                }
            );

            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Comments)
                .WithOne(c => c.Recipe)
                .HasForeignKey(c => c.RecipeID);
        }
    }
}
