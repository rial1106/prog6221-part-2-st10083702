using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6221
{

    // Holds the list of all Recipes.
    static class Container
    {
        // The list with some default values.
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
            new Recipe(1, "Tea")
            {
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(4, "Tea Bag", 5, "Grams", 10, FOOD_GROUP.DRY_BEANS_PEAS_LENTILS_SOYA),
                    new Ingredient(5, "Water", 250, "Millilitres", 0, FOOD_GROUP.WATER),
                    new Ingredient(6, "Milk", 0.1, "Litres", 100, FOOD_GROUP.MILK_AND_DAIRY)
                },

                Steps = new List<string>
                {
                    new string("Add 5 grams of tea bags to the cup."),
                    new string("Add 250 mililitres of boiling water to that."),
                    new string("Add 100 ml of milk and stir thoroughly.")
                }
            },
            new Recipe(2, "Pasta")
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
