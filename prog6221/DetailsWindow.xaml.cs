using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prog6221
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        public DetailsWindow(int RecipeId)
        {
            InitializeComponent();

            /*            Ingredient ingredient1 = new Ingredient(0, "Flour", 100, "Grams", 200, FOOD_GROUP.STARCHY_FOODS);
                        Recipe recipe = new Recipe(0, "Roti");
                        recipe.AddIngredient(ingredient1);
                        recipe.AddStep("Boil 100 grams of water and 10 grams of sodium");

                        Container.Recipes.Add(recipe);*/

            Recipe recipe = Container.Recipes.Find(x => x.Id == RecipeId);
            recipe.AboveThreshold += Details_AboveThreshold;

            this.DataContext= recipe;

        }

        private void Details_AboveThreshold(double value)
        {
            MessageBox.Show($"The total calories for this recipe is above 300, it is currently {value}!");
        }
    }
}
