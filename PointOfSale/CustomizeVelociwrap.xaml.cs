/* Customize VelociWrap Page
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
    /// Interaction logic for CustomizeVelociwrap.xaml
    /// </summary>
    public partial class CustomizeVelociwrap : Page
    {
        private VelociWrap vw;
        private CretaceousCombo combo = new CretaceousCombo(new VelociWrap());

        public CustomizeVelociwrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        public CustomizeVelociwrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.vw = (VelociWrap)combo.Entree;
            this.combo = combo;
        }

        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
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
