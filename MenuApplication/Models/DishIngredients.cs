﻿namespace MenuApplication.Models
{
    public class DishIngredients
    {
        public int DishId { get; set; }
        //public string Name { get; set; }
        public Dish Dish { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
