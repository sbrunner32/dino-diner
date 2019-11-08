/* Customize DinoNuggets Page
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
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets dn;
        private CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());

        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }

        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.dn = (DinoNuggets)combo.Entree;
            this.combo = combo;
        }

        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            dn.AddNugget();
        }

        private void OnResetNuggetCount(object sender, RoutedEventArgs args)
        {
            dn.ResetNuggetCount();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
