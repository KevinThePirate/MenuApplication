using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MenuApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddingDishes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "https://assets.epicurious.com/photos/5c745a108918ee7ab68daf79/1:1/w_2560%2Cc_limit/Smashburger-recipe-120219.jpg", "Burger", 6.5 },
                    { 3, "https://www.allrecipes.com/thmb/5SdUVhHTMs-rta5sOblJESXThEE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/11691-tomato-and-garlic-pasta-ddmfs-3x4-1-bf607984a23541f4ad936b33b22c9074.jpg", "Pasta", 8.0 },
                    { 4, "https://www.acouplecooks.com/wp-content/uploads/2019/05/Chopped-Salad-001_1.jpg", "Salad", 5.5 }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Tomato Sauce");

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Beef Patty" },
                    { 4, "Lettuce" },
                    { 5, "Bun" },
                    { 6, "Pasta" },
                    { 7, "Garlic" },
                    { 8, "Olive Oil" },
                    { 9, "Cucumber" },
                    { 10, "Tomato" },
                    { 11, "Dressing" }
                });

            migrationBuilder.InsertData(
                table: "DishIngredients",
                columns: new[] { "DishId", "IngredientId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 4 },
                    { 4, 9 },
                    { 4, 10 },
                    { 4, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "DishIngredients",
                keyColumns: new[] { "DishId", "IngredientId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Sauce");
        }
    }
}
