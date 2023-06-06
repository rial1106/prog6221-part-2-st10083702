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

        Recipe recipe = null!;
        public DetailsWindow(int RecipeId)
        {
            InitializeComponent();

            // Only the Id is passed to this window for performance
            // So find the actual object from that.
            recipe = Container.Recipes.Find(x => x.Id == RecipeId);

            // Remove delegate (To prevent duplicates)
            recipe.AboveThreshold -= Details_AboveThreshold;
            // Register Delegate
            recipe.AboveThreshold += Details_AboveThreshold;

            // Set the context for the UI.
            this.DataContext= recipe;

        }

        // Implement Delegate
        private void Details_AboveThreshold(double value)
        {
            MessageBox.Show($"The total calories for this recipe is above 300, it is currently {value}!");
            // Unsubscribe from the event to prevent resubscribing
            recipe.AboveThreshold -= Details_AboveThreshold;
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            recipe.ResetScaleRecipe();
        }

        private void HalfScaleBtn_Click(object sender, RoutedEventArgs e)
        {
            recipe.ScaleRecipe(0.5);
        }

        private void DoubleScaleBtn_Click(object sender, RoutedEventArgs e)
        {
            recipe.ScaleRecipe(2.0);
        }

        private void TripleScaleBtn_Click(object sender, RoutedEventArgs e)
        {
            recipe.ScaleRecipe(3.0);
        }
    }
}
