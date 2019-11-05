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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger tb;
        public CustomizeTRexKingBurger(TRexKingBurger tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            tb.HoldBun();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            tb.HoldLettuce();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            tb.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            tb.HoldOnion();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            tb.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            tb.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            tb.HoldMustard();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            tb.HoldMayo();
        }


        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
