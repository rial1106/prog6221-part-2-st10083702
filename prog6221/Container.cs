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
            new Recipe(1, "Bread")
            {
                Ingredients = new List<Ingredient>
                {
                    new Ingredient(0, "Flour", 100, "Grams", 150, FOOD_GROUP.STARCHY_FOODS)
                },
                
                Steps = new List<string>
                {
                    new string("Add 100 litres of water into the pot.")
                }
            }
        };
    }

}
