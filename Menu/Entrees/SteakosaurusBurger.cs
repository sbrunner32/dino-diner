using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the SteakosaurasBurger entree.
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem 
    {
        private bool bun = true;        
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Property used to get and set the list of ingredients on this SteakosaurasBurger.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");                
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor for SteakosaurasBurger that sets the default price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Method to set this SteakosaurasBurger's bun property to false.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Method to set this SteakosaurasBurger's pickle property to false.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Method to set this SteakosaurasBurger's ketchup property to false.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Method to set this SteakosaurasBurger's mustard property to false.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }

        /// <summary>
        /// Displays the name of the item
        /// </summary>
        /// <returns>The string value of the item name</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

    }
}
