using PartialViewsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewsDemo.HelperClasses
{
    public static class EntreeManager
    {
        public static List<Entree> GetAll()
        {
            List<Entree> entrees = new List<Entree>();
            entrees.Add(new Models.Entree()
            {
                ID = 1,
                Name = "Sopa",
                Ingredients = new List<Models.Ingredient>() {
                    new Models.Ingredient() { Name = "Pasta", Amount = 3, Unit = "Cups"},
                    new Models.Ingredient() { Name = "Tomato Sauce", Amount = 2, Unit = "Cups"},
                    new Models.Ingredient() { Name = "Ground Beef", Amount = 1, Unit = "Pound"},
                    new Models.Ingredient() { Name = "Cumin", Amount = 2, Unit = "Teaspoons"}
                }
            });
            entrees.Add(new Models.Entree()
            {
                ID = 2,
                Name = "Lazy Enchiladas",
                Ingredients = new List<Models.Ingredient>() {
                    new Models.Ingredient() { Name = "Corn Tortillas", Amount = 18, Unit = "Items"},
                    new Models.Ingredient() { Name = "Enchilada Sauce", Amount = 2.5M, Unit = "Cups"},
                    new Models.Ingredient() { Name = "Mexican Cheese", Amount = 0.75M, Unit = "Cups"},
                    new Models.Ingredient() { Name = "Green Chilis", Amount = 1, Unit = "Can"}
                }
            });
            entrees.Add(new Models.Entree()
            {
                ID = 2,
                Name = "Golden Chicken Bake",
                Ingredients = new List<Models.Ingredient>() {
                    new Models.Ingredient() { Name = "Chicken Breast", Amount = 4, Unit = "Items"},
                    new Models.Ingredient() { Name = "Cream of Chicken Soup", Amount = 10.5M, Unit = "Ounces"}
                }
            });

            return entrees;
        }
    }
}