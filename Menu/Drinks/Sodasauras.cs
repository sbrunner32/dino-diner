using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for Sodasauras that inherits from the Drink class
    /// </summary>
    public class Sodasauras : Drink
    {
        /// <summary>
        /// Private backing property for the flavor of this Sodasauras
        /// </summary>
        private SodasaurasFlavor flavor = SodasaurasFlavor.Cola;

        /// <summary>
        /// Property to store the flavor of this Sodasauras
        /// </summary>
        public SodasaurasFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
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
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Public constructor for the Sodasauras class that sets default values and inherits from the drink constructor
        /// </summary>
        public Sodasauras() : base()
        {
            this.Price = 1.50;
            this.Calories = 112;

        }

        
    }
}
