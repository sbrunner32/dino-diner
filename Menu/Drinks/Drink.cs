using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{    
    /// <summary>
    /// Abstract class to denote a drink item from the menu.
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged, IOrderItem
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
        /// Whether or not the drink contains Ice, default value = true
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Public method to set the Ice property to false (requesting no Ice on a drink)
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }

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
