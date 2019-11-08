/* CretacuousCombo Class
 * Author: Sam Brunner
*/


using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class for a CretaceousCombo
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event Handler for property changes, notifies when a combo property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The entree item of the combo
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// The drink item of the combo, defaults to Sodasaurus
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();
        /// <summary>
        /// The side item of the combo, defaults to Fryceritops
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        private Size size = Size.Small;
        /// <summary>
        /// The getter which sets the size of the items in the combo to ths size of the combo.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }

        /// <summary>
        /// The price of the combo getter, returns the price of all items -0.25
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }            
        }

        /// <summary>
        /// The getter of the combo's calories, returns the calories of entree + drink + side.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Entree.Calories + Side.Calories;
            }
        }

        /// <summary>
        /// The getter of the ingredients of the combo. 
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// The public override to return the contents of the combo as a string. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ($"{Entree} Combo");
        }

        private CretaceousCombo() { }

        /// <summary>
        /// Public constructor for CretaceousCombo which sets the entree while using default side and drink values.
        /// </summary>
        /// <param name="entree">The entree item to set for this CretaceousCombo</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;           
        }

        /// <summary>
        /// Description of the combo item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        
        /// <summary>
        /// List of special instructions for the combo item.
        /// </summary>
        public string[] Special
        {
            get
            {
                //Add all the side's specials to the list, then add drink special
                //Add special functionality to menu items to add commented code back
                //Can replace .ToString() calls with Description once Description is implemented. 
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }


    }
}
