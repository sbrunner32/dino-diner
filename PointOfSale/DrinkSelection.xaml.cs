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
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {

        private Drink drink;

        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
            }
        }

        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            this.drink = drink;
            InitializeComponent();
            
        }
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }

        private void SelectDrink(Drink drink)
        {
            if(DataContext is Order order)
            {
                order.Add(drink);
                Drink = drink;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
                Drink.Size = size;
        }


        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Visible;
            btnHoldIce.Visibility = Visibility.Visible;
            btnAddLemon.Visibility = Visibility.Collapsed;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Collapsed;
            SelectDrink(new Sodasaurus());
        }

        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Visible;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Visible;
            SelectDrink(new Tyrannotea());
        }

        private void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Collapsed;
            btnAddIce.Visibility = Visibility.Visible;
            btnAddDecaf.Visibility = Visibility.Visible;
            btnAddSweet.Visibility = Visibility.Collapsed;
            SelectDrink(new JurassicJava());
        }

        private void SelectWater(object sender, RoutedEventArgs args)
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Visible;
            btnAddLemon.Visibility = Visibility.Visible;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Collapsed;
            SelectDrink(new Water());
        }

        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }


        protected void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
