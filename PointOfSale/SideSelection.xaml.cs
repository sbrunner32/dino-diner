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

        /// <summary>
        /// public getter and setter for the side
        /// </summary>
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

        /// <summary>
        /// Empty constructor for SideSelection class
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for SideSelection class which passes in a side as an argument.
        /// </summary>
        /// <param name="side">The side to be used</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        /// <summary>
        /// Constructor for the SideSelection class that takes a combo to select the side of the combo
        /// </summary>
        /// <param name="combo">Combo to have it's side selected</param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            this.side = combo.Side;
        }
  
        /// <summary>
        /// Helper function to choose the side item
        /// </summary>
        /// <param name="side">The side to be chosen</param>
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

        /// <summary>
        /// Helper function to select the size of the side item.
        /// </summary>
        /// <param name="size">The size for the selected side</param>
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
        
        /// <summary>
        /// Event for the Add Fryceritops click on button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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

        /// <summary>
        /// Click event to make side large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Click event to make side medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Click event to make side small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// Click event to finish the side selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
