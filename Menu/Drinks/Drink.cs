using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{    
    /// <summary>
    /// Abstract class to denote a drink item from the menu.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        
        /// <summary>
        /// Whether or not the drink contains Ice, default value = true
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
    }
}
