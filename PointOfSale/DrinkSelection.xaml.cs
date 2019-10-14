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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Visible;
            btnHoldIce.Visibility = Visibility.Visible;
            btnAddLemon.Visibility = Visibility.Collapsed;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Collapsed;
        }

        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Visible;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Visible;
        }

        private void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Collapsed;
            btnAddIce.Visibility = Visibility.Visible;
            btnAddDecaf.Visibility = Visibility.Visible;
            btnAddSweet.Visibility = Visibility.Collapsed;
        }

        private void SelectWater(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Visible;
            btnAddLemon.Visibility = Visibility.Visible;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Collapsed;
        }
    }
}
