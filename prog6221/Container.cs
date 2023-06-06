using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6221
{
    static class Container
    {
        public static List<Recipe> Recipes = new List<Recipe>()
        {
            new Recipe(0, "Bread")
            {
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(0, "Flour", 100, "Grams", 150, FOOD_GROUP.STARCHY_FOODS)
                },
                
                Steps = new List<string>
                {
                    new string("Add 100 litres of water into the pot.")
                }
            },
            new Recipe(1, "Pasta")
            {
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(1, "Flour", 150, "Grams", 50, FOOD_GROUP.STARCHY_FOODS),
                    new Ingredient(2, "Water", 2, "Litres", 0, FOOD_GROUP.WATER),
                    new Ingredient(3, "Sunflower Oil", 0.4, "Litres", 1000, FOOD_GROUP.FATS_AND_OILS)
                },

                Steps = new List<string>
                {
                    new string("Add 150 grams of Flour to a pot."),
                    new string("Add 2 litres of water to that."),
                    new string("Add 400 ml of oil and allow to cook.")
                }
            }
        };
    }

}
