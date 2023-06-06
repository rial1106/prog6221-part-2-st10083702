using System;
using System.Collections.Generic;
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
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    /// 
    public partial class ListWindow : Window
    {
        public ListWindow()
        {
            InitializeComponent();
            LstRecipes.ItemsSource = Container.Recipes;

        }

        private void OnSelected(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected item from the ListBox
            Recipe selectedItem = (Recipe)(sender as ListBox).SelectedItem;

            // Create a new instance of the new window
            var newWindow = new DetailsWindow(selectedItem.Id);

            // Show the new window
            newWindow.Show();
        }
    }
}
