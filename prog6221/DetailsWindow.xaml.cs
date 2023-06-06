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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Ingredient ingredient1 = new Ingredient(0, "Flour", 100, "Grams", 200, FOOD_GROUP.STARCHY_FOODS);
            Recipe recipe = new Recipe(0, "Roti");
            recipe.AddIngredient(ingredient1);
            recipe.AddStep("Boil 100 grams of water and 10 grams of sodium");

            Container.Recipes.Add(recipe);

            this.DataContext= recipe;

            Trace.WriteLine(recipe.ToString());

            recipe.ScaleRecipe(2.0f);
            Trace.WriteLine(recipe.ToString());

            recipe.ScaleRecipe(3.0f);
            Trace.WriteLine(recipe.ToString());

            recipe.ResetScaleRecipe();
            Trace.WriteLine(recipe.ToString());

        }
    }
}
