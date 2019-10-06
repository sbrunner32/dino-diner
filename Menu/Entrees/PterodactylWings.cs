﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the PterodactylWings
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {
        
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
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };            
                return ingredients;
            }
        }

        /// <summary>
        /// Displays the name of the item
        /// </summary>
        /// <returns>The string value of the item name</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
