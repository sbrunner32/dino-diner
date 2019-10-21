using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the Brontowurst sandwich
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        private bool bun = true;
        private bool pepper = true;
        private bool onion = true;

        
        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!pepper) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onions");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Property used to get and set the list of ingredients on this Brontowurst sandwich.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (onion) ingredients.Add("Onion");
                if (pepper) ingredients.Add("Peppers");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor for Brontowurst that sets default price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Method to set this Brontowurst's pepper property to false.
        /// </summary>
        public void HoldPeppers()
        {
            this.pepper = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to set this Brontowurst's onion property to false.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Method to set this Brontowurst's bun property to false.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }

        /// <summary>
        /// Displays the name of the item
        /// </summary>
        /// <returns>The string value of the item name</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}


