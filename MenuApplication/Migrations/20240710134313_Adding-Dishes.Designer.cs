﻿// <auto-generated />
using MenuApplication.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MenuApplication.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20240710134313_Adding-Dishes")]
    partial class AddingDishes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MenuApplication.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://www.foodandwine.com/thmb/Wd4lBRZz3X_8qBr69UOu2m7I2iw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/classic-cheese-pizza-FT-RECIPE0422-31a2c938fc2546c9a07b7011658cfd05.jpg",
                            Name = "Pizza",
                            Price = 7.5
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://assets.epicurious.com/photos/5c745a108918ee7ab68daf79/1:1/w_2560%2Cc_limit/Smashburger-recipe-120219.jpg",
                            Name = "Burger",
                            Price = 6.5
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://www.allrecipes.com/thmb/5SdUVhHTMs-rta5sOblJESXThEE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/11691-tomato-and-garlic-pasta-ddmfs-3x4-1-bf607984a23541f4ad936b33b22c9074.jpg",
                            Name = "Pasta",
                            Price = 8.0
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "https://www.acouplecooks.com/wp-content/uploads/2019/05/Chopped-Salad-001_1.jpg",
                            Name = "Salad",
                            Price = 5.5
                        });
                });

            modelBuilder.Entity("MenuApplication.Models.DishIngredients", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("DishId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("DishIngredients");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            IngredientId = 1
                        },
                        new
                        {
                            DishId = 1,
                            IngredientId = 2
                        },
                        new
                        {
                            DishId = 2,
                            IngredientId = 3
                        },
                        new
                        {
                            DishId = 2,
                            IngredientId = 4
                        },
                        new
                        {
                            DishId = 2,
                            IngredientId = 5
                        },
                        new
                        {
                            DishId = 3,
                            IngredientId = 6
                        },
                        new
                        {
                            DishId = 3,
                            IngredientId = 1
                        },
                        new
                        {
                            DishId = 3,
                            IngredientId = 7
                        },
                        new
                        {
                            DishId = 3,
                            IngredientId = 8
                        },
                        new
                        {
                            DishId = 4,
                            IngredientId = 4
                        },
                        new
                        {
                            DishId = 4,
                            IngredientId = 9
                        },
                        new
                        {
                            DishId = 4,
                            IngredientId = 10
                        },
                        new
                        {
                            DishId = 4,
                            IngredientId = 11
                        });
                });

            modelBuilder.Entity("MenuApplication.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tomato Sauce"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cheese"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Beef Patty"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lettuce"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bun"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Pasta"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Garlic"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Olive Oil"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cucumber"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Tomato"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Dressing"
                        });
                });

            modelBuilder.Entity("MenuApplication.Models.DishIngredients", b =>
                {
                    b.HasOne("MenuApplication.Models.Dish", "Dish")
                        .WithMany("DishIngredients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MenuApplication.Models.Ingredient", "Ingredient")
                        .WithMany("DishIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("MenuApplication.Models.Dish", b =>
                {
                    b.Navigation("DishIngredients");
                });

            modelBuilder.Entity("MenuApplication.Models.Ingredient", b =>
                {
                    b.Navigation("DishIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
