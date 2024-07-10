using Microsoft.EntityFrameworkCore;
using MenuApplication.Models;

namespace MenuApplication.Models.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext( DbContextOptions<MenuContext> options) :base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredients>().HasKey(di => new { di.DishId, di.IngredientId });
            modelBuilder.Entity<DishIngredients>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredients>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Dish>().HasData(
                new Dish { Id = 1, Name = "Pizza", Price = 7.50, ImageUrl = "https://www.foodandwine.com/thmb/Wd4lBRZz3X_8qBr69UOu2m7I2iw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/classic-cheese-pizza-FT-RECIPE0422-31a2c938fc2546c9a07b7011658cfd05.jpg" },
                new Dish { Id = 2, Name = "Burger", Price = 6.50, ImageUrl = "https://assets.epicurious.com/photos/5c745a108918ee7ab68daf79/1:1/w_2560%2Cc_limit/Smashburger-recipe-120219.jpg" },
                new Dish { Id = 3, Name = "Pasta", Price = 8.00, ImageUrl = "https://www.allrecipes.com/thmb/5SdUVhHTMs-rta5sOblJESXThEE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/11691-tomato-and-garlic-pasta-ddmfs-3x4-1-bf607984a23541f4ad936b33b22c9074.jpg" },
                new Dish { Id = 4, Name = "Salad", Price = 5.50, ImageUrl = "https://www.acouplecooks.com/wp-content/uploads/2019/05/Chopped-Salad-001_1.jpg" }
            );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Tomato Sauce" },
                new Ingredient { Id = 2, Name = "Cheese" },
                new Ingredient { Id = 3, Name = "Beef Patty" },
                new Ingredient { Id = 4, Name = "Lettuce" },
                new Ingredient { Id = 5, Name = "Bun" },
                new Ingredient { Id = 6, Name = "Pasta" },
                new Ingredient { Id = 7, Name = "Garlic" },
                new Ingredient { Id = 8, Name = "Olive Oil" },
                new Ingredient { Id = 9, Name = "Cucumber" },
                new Ingredient { Id = 10, Name = "Tomato" },
                new Ingredient { Id = 11, Name = "Dressing" }
            );

            modelBuilder.Entity<DishIngredients>().HasData(
                new DishIngredients { DishId = 1, IngredientId = 1 },
                new DishIngredients { DishId = 1, IngredientId = 2 },
                new DishIngredients { DishId = 2, IngredientId = 3 },
                new DishIngredients { DishId = 2, IngredientId = 4 },
                new DishIngredients { DishId = 2, IngredientId = 5 },
                new DishIngredients { DishId = 3, IngredientId = 6 },
                new DishIngredients { DishId = 3, IngredientId = 1 },
                new DishIngredients { DishId = 3, IngredientId = 7 },
                new DishIngredients { DishId = 3, IngredientId = 8 },
                new DishIngredients { DishId = 4, IngredientId = 4 },
                new DishIngredients { DishId = 4, IngredientId = 9 },
                new DishIngredients { DishId = 4, IngredientId = 10 },
                new DishIngredients { DishId = 4, IngredientId = 11 }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredients> DishIngredients { get; set; }


    }
}
