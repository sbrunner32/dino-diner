using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for Sodasauras that inherits from the Drink class
    /// </summary>
    public class Sodasaurus : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing property for the flavor of this Sodasauras
        /// </summary>
        private SodasaurusFlavor flavor = SodasaurusFlavor.Cola;

        /// <summary>
        /// Property to store the flavor of this Sodasauras
        /// </summary>
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;                
                NotifyOfPropertyChange("Description");
            }

        }

        /// <summary>
        /// Public override property to set/get the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }


        /// <summary>
        /// Gets any special instructions for this menu item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();                
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
        
        /// <summary>
        /// Protected size quanity of this Sodasauras
        /// </summary>
        protected Size size;

        /// <summary>
        /// Override to get and set the size of the Sodasauras and the according calorie and price values
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Calories = 112;
                        this.Price = 1.50;
                        break;
                    case Size.Medium:
                        this.Calories = 156;
                        this.Price = 2.00;
                        break;
                    case Size.Large:
                        this.Calories = 208;
                        this.Price = 2.50;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Description");
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Public constructor for the Sodasauras class that sets default values and inherits from the drink constructor
        /// </summary>
        public Sodasaurus() : base()
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.size = Size.Small;

        }

        /// <summary>
        /// Override of the ToString method 
        /// </summary>
        /// <returns>The size, flavor, and name of this side item</returns>
        public override string ToString()
        {
            return ($"{size} {flavor} Sodasaurus");
        }


    }
}
