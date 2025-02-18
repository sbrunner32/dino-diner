﻿/* Drink Selection Page
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
                if (Drink is Sodasaurus soda)
                {
                    SodasaurusButtons();
                }
                if (Drink is JurassicJava java)
                {
                    JurassicJavaButtons();
                }
                if (Drink is Tyrannotea tea)
                {
                    TyrannoteaButtons();
                }
                if (Drink is Water water)
                {
                    WaterButtons();
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
            btnRoomForCream.Visibility = Visibility.Collapsed;
        }

        private void TyrannoteaButtons()
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Visible;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Visible;
            btnRoomForCream.Visibility = Visibility.Collapsed;
        }

        private void JurassicJavaButtons()
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Collapsed;
            btnAddLemon.Visibility = Visibility.Collapsed;
            btnAddIce.Visibility = Visibility.Visible;
            btnAddDecaf.Visibility = Visibility.Visible;
            btnAddSweet.Visibility = Visibility.Collapsed;
            btnRoomForCream.Visibility = Visibility.Visible;
        }

        private void WaterButtons()
        {
            btnSelectFlavor.Visibility = Visibility.Collapsed;
            btnHoldIce.Visibility = Visibility.Visible;
            btnAddLemon.Visibility = Visibility.Visible;
            btnAddIce.Visibility = Visibility.Collapsed;
            btnAddDecaf.Visibility = Visibility.Collapsed;
            btnAddSweet.Visibility = Visibility.Collapsed;
            btnRoomForCream.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Click event to add lemon to the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void onAddLemon(object sender, RoutedEventArgs args)
        {
            if(Drink is Tyrannotea tea)
            {
                tea.AddLemon();
            }
            else if (Drink is Water water)
            {
                water.AddLemon();
            }

        }

        /// <summary>
        /// Click event to hold ice from the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void onHoldIce(object sender, RoutedEventArgs args)
        {
            if (Drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }            
            if (Drink is Water water)
            {
                water.HoldIce();
            }
            if (Drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
        }

        /// <summary>
        /// Click event to add ice to the JurassicJava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void onAddIce(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.AddIce();
            }
        }

        /// <summary>
        /// Click event to make the tea into sweet tea. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void onAddSweet(object sender, RoutedEventArgs args)
        {
            if (Drink is Tyrannotea tea)
            {
                tea.AddSweet();
            }
        }

        /// <summary>
        /// Sets the Jurassic Java to decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void onAddDecaf(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.AddDecaf();          
            }
        }

        /// <summary>
        /// Leaves room for cream for the Jurassic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void onAddRoomForCream(object sender, RoutedEventArgs args)
        {
            if (Drink is JurassicJava java)
            {
                java.LeaveRoomForCream();
            }
        }


    }
}
