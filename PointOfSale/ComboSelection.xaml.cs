/* Combo Selection Page
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo;        
        public ComboSelection()
        {
            InitializeComponent();
        }

        public ComboSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(entree);
                order.Add(combo);                
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                CretaceousCombo combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(combo));
            }            
        }

        public void AddVelociwrap(object sender, RoutedEventArgs args)
        {
                     
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                CretaceousCombo combo = new CretaceousCombo(vw);
                order.Add(combo); 
                NavigationService.Navigate(new CustomizeVelociwrap(combo));
            }
        }

        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {            
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                CretaceousCombo combo = new CretaceousCombo(dn);                
                order.Add(combo);
                NavigationService.Navigate(new CustomizeDinoNuggets(combo));
            }
        }

        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {          
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                CretaceousCombo combo = new CretaceousCombo(sb);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
            }
        }

        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger tb = new TRexKingBurger();
                CretaceousCombo combo = new CretaceousCombo(tb);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeTRexKingBurger(combo));
            }
        }

        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                CretaceousCombo combo = new CretaceousCombo(bw);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeBrontowurst(combo));
            }
        }





        private void CustomizeCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
