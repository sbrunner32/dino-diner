using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Public class for a CretaceousCombo
    /// </summary>
    public class CretaceousCombo : IMenuItem
    {
        /// <summary>
        /// The entree item of the combo
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// The drink item of the combo
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// The side item of the combo
        /// </summary>
        public Side Side { get; set; }

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
            return (Entree.ToString() + " Combo");
        }

        private CretaceousCombo() { }

        /// <summary>
        /// Public constructor for CretaceousCombo which sets the entree while using default side and drink values.
        /// </summary>
        /// <param name="entree">The entree item to set for this CretaceousCombo</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }




    }
}
