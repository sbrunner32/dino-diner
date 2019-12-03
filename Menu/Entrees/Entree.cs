/* Entree Class
 * Author: Sam Brunner
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class representing a side item from the menu
    /// </summary>
    /// <summary>
    /// Class representing an entree item from the menu with calories and price
    /// </summary>
    public abstract class Entree : INotifyPropertyChanged, IOrderItem, IMenuItem
    {
        /// <summary>
        /// The PropertyChanged Event handler; notifies
        /// of changes to the Price, Description, and 
        /// Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper function for notifying of property changes
        /// </summary>
        /// <param name="propertyName">Name of property changed</param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

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
        /// Gets the text description of the menu item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Virtual property for all the special instructions. 
        /// </summary>
        public virtual string[] Special { get; }

        
    }
}
