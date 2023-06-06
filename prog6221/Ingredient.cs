using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog6221
{

    public enum FOOD_GROUP
    {
        [Description("Starchy foods")]
        STARCHY_FOODS,
        [Description("Vegetables and fruits")]
        VEGETABLES_AND_FRUITS,
        [Description("Dry beans, peas, lentils and soya")]
        DRY_BEANS_PEAS_LENTILS_SOYA ,
        [Description("Chicken, fish, meat and eggs")]
        CHICKEN_FISH_MEAT_EGGS,
        [Description("Milk and dairy products")]
        MILK_AND_DAIRY,
        [Description("Fats and oil")]
        FATS_AND_OILS,
        [Description("Water")]
        WATER
    }

    public class Ingredient
    {
        public Ingredient(int id, string name, double quantity, string unitOfMeasurement,
            double numberOfCalories, FOOD_GROUP fOOD_GROUP)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
            NumberOfCalories = numberOfCalories;
            FOOD_GROUP = fOOD_GROUP;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public String UnitOfMeasurement { get; set; }
        public double NumberOfCalories { get; set; }

        public FOOD_GROUP FOOD_GROUP { get; set; }

    }
}
