using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface that all menu items inherit from
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Getter / setter for the price of the menu item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Getter / setter for the calories of the menu item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Getter / setter for the Ingredients of the menu item. 
        /// </summary>
        List<string> Ingredients { get; }
  

    }
}
