/* Side Selection Page
 * Author: Sam Brunner
*/

using DinoDiner.Menu;
using DinoDiner.Menu.Sides;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;
        private CretaceousCombo combo;

        public Side Side {
            get
            {
                return side;
            }
            set
            {
                side = value;                
            }
        }

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    this.combo.Side = side;
                    this.Side = side;
                }
                else
                {
                    order.Add(side);
                    this.Side = side;
                }
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if(Side != null)
            {
                if (combo != null)
                {
                    this.combo.Side.Size = size;
                }
                Side.Size = size;
            }
                
        }
        
        public void AddFryceritops(object sender, RoutedEventArgs args)
        {

            SelectSide(new Fryceritops());
            /*
            BtnAddFryceritops.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false
            */
        }

        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
            /*BtnAddFryceritops.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            */
        }

        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
            /*BtnAddFryceritops.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            */

        }

        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
            /*BtnAddFryceritops.IsEnabled = false;
            BtnAddTriceritots.IsEnabled = false;
            BtnAddMezzorellaSticks.IsEnabled = false;
            BtnAddMeteorMacAndCheese.IsEnabled = false;
            */
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

        private void OnDone(object sender, RoutedEventArgs args)
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


    }
}
