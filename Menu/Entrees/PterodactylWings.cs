using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the PterodactylWings
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Property used to get and set the value of the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Property used to get and set the value of the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Default constructor for PterodactylWings that sets default price and calories.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Property used to get and set the list of ingredients of the PterodactylWings
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };            
                return ingredients;
            }
        }
    }
}
