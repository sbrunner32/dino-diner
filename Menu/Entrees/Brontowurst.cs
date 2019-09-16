using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the Brontowurst sandwich
    /// </summary>
    public class Brontowurst
    {
        private bool bun = true;
        private bool pepper = true;
        private bool onion = true;

        /// <summary>
        /// Property used to get and set the value of the price.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Property used to get and set the value of the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Property used to get and set the list of ingredients on this Brontowurst sandwich.
        /// </summary>
        public List<string> Ingredients
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
        }

        /// <summary>
        /// Method to set this Brontowurst's onion property to false.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// Method to set this Brontowurst's bun property to false.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
    }
}


