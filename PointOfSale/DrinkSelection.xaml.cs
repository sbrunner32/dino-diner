/* Drink Selection Page
 * Author: Sam Brunner
*/

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
        private CretaceousCombo combo;
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
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    this.combo.Drink = drink;
                    this.Drink = drink;
                }
                else
                {
                    Drink = drink;
                    order.Add(drink);                    
                }
            }

        }

        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.drink = combo.Drink;
            this.combo = combo;
            if (Drink is Sodasaurus soda)
            {
                SodasaurusButtons();
            }
            if (Drink is Tyrannotea tea)
            {
                TyrannoteaButtons();
            }
            if (Drink is JurassicJava java)
            {
                JurassicJavaButtons();
            }
            if (Drink is Water water)
            {
                WaterButtons();
            }


        }

        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }

        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    this.combo.Drink = drink;
                    this.Drink = drink;
                }
                else
                {
                    order.Add(drink);
                    Drink = drink;
                }
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                if (combo != null)
                {
                    this.combo.Drink.Size = size;
                }
                else
                {
                    Drink.Size = size;
                }
            }
        }


        private void SelectSodasaurus(object sender, RoutedEventArgs args)
        {
            SodasaurusButtons();
            SelectDrink(new Sodasaurus());
        }

        private void SelectTyrannotea(object sender, RoutedEventArgs args)
        {
            TyrannoteaButtons();
            SelectDrink(new Tyrannotea());
        }

        private void SelectJurassicJava(object sender, RoutedEventArgs args)
        {
            JurassicJavaButtons();
            SelectDrink(new JurassicJava());
        }

        private void SelectWater(object sender, RoutedEventArgs args)
        {
            WaterButtons();
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
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void SodasaurusButtons()
        {
            btnSelectFlavor.Visibility = Visibility.Visible;
            btnHoldIce.Visibility = Visibility.Visible;
            btnAddLemon.Visibility = Visibility.Collapsed;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Collapsed;
        }

        private void TyrannoteaButtons()
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Visible;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Visible;
        }

        private void JurassicJavaButtons()
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Collapsed;
            btnAddIce.Visibility = Visibility.Visible;
            btnAddDecaf.Visibility = Visibility.Visible;
            btnAddSweet.Visibility = Visibility.Collapsed;
        }

        private void WaterButtons()
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
