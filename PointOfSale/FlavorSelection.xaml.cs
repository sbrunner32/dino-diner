/* Flavor Selection Page
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private SodasaurusFlavor flavorBacking;

        private Sodasaurus soda;
        
        public Sodasaurus Soda
        {
            get
            {
                return soda;
            }
        }

        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavorBacking;
            }
            set
            {
                flavorBacking = value;
            }
        }

        private void SelectFlavor(SodasaurusFlavor flavor)
        {
            if (DataContext is Order order)
            {
                soda.Flavor = flavor;
                Flavor = flavor;
                NavigationService.GoBack();
            }
        }

        public FlavorSelection()
        {
            InitializeComponent();
        }

        public FlavorSelection(Sodasaurus sodasaurus)
        {
            InitializeComponent();
            soda = sodasaurus;
        }
        

        public void SelectCherry(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
        }

        public void SelectChocolate(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Chocolate);
        }

        public void SelectCola(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cola);
        }

        public void SelectLime(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Lime);
        }

        public void SelectOrange(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Orange);
        }

        public void SelectRootBeer(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.RootBeer);
        }

        public void SelectVanilla(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Vanilla);
        }

    }
}
