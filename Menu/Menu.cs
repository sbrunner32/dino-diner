/* Menu Class
 * Author: Sam Brunner
*/

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class to represent the menu of the restaurant.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Public getter to return all the currently available Entree items on the menu.
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> temp = new List<IMenuItem>();
                temp.Add(new Brontowurst());
                temp.Add(new DinoNuggets());
                temp.Add(new PrehistoricPBJ());
                temp.Add(new PterodactylWings());
                temp.Add(new SteakosaurusBurger());
                temp.Add(new TRexKingBurger());
                temp.Add(new VelociWrap());
                return temp;
            }
        }

        /// <summary>
        /// Public getter to return all the currently available Side items on the menu.
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> temp = new List<IMenuItem>();
                temp.Add(new Fryceritops());
                temp.Add(new MeteorMacAndCheese());
                temp.Add(new MezzorellaSticks());
                temp.Add(new Triceritots());
                return temp;
            }
        }

        /// <summary>
        /// Public getter to return all the currently available Drink items on the menu.
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> temp = new List<IMenuItem>();
                temp.Add(new JurassicJava());
                temp.Add(new Sodasaurus());
                temp.Add(new Tyrannotea());
                temp.Add(new Water());
                return temp;
            }
        }

        /// <summary>
        /// Public getter to return all the currently available Combo items on the menu.
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> temp = new List<IMenuItem>();                  
                temp.Add(new CretaceousCombo(new Brontowurst()));
                temp.Add(new CretaceousCombo(new DinoNuggets()));
                temp.Add(new CretaceousCombo(new PrehistoricPBJ()));
                temp.Add(new CretaceousCombo(new PterodactylWings()));
                temp.Add(new CretaceousCombo(new SteakosaurusBurger()));
                temp.Add(new CretaceousCombo(new TRexKingBurger()));
                temp.Add(new CretaceousCombo(new VelociWrap()));
                return temp;
            }
        }

        /// <summary>
        /// Public getter to return all the currently available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> temp = new List<IMenuItem>();
                //Adding Entree to the list now
                foreach (IMenuItem i in AvailableEntrees)
                    temp.Add(i);
                //Adding Side items to the list now
                foreach (IMenuItem i in AvailableSides)
                    temp.Add(i);
                //Adding Drink items to the list now
                foreach (IMenuItem i in AvailableDrinks)
                    temp.Add(i);
                //Adding Combo items to the list now
                foreach (IMenuItem i in AvailableCombos)
                    temp.Add(i);
                return temp;
            }
        }

        /// <summary>
        /// Public Override of ToString method to display the full menu contents
        /// </summary>
        /// <returns>Full list of all menu items separated by new line characters. </returns>
        public override string ToString()
        {            
            List<string> final = new List<string>();
            foreach(IMenuItem i in AvailableMenuItems)
            {
                final.Add(i.ToString());
                final.Add("\n");
            }
            return final.ToString();
        }
    }
}
