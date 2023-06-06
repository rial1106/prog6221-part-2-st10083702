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

            recipe = Container.Recipes.Find(x => x.Id == RecipeId);
            recipe.AboveThreshold -= Details_AboveThreshold;
            recipe.AboveThreshold += Details_AboveThreshold;

            this.DataContext= recipe;

        }

        private void Details_AboveThreshold(double value)
        {
            MessageBox.Show($"The total calories for this recipe is above 300, it is currently {value}!");
            // Unsubscribe from the event to prevent resubscribing
            recipe.AboveThreshold -= Details_AboveThreshold;
        }
    }
}
