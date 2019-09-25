using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Public getter and setter that stores whether or not the Tyrannotea has lemon, defaults to false
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Public override property to set/get the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Tea" };
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
                        this.Price = 0.99;
                        this.Calories = 8;
                        if (Sweet)
                            this.Calories *= 2;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        if (Sweet)
                            this.Calories *= 2;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        if (Sweet)
                            this.Calories *= 2;
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
        public Tyrannotea() : base()
        {
            this.Price = 1.50;
            this.Calories = 112;

        }

        /// <summary>
        /// Public method to set the Ice property to false (requesting no Ice on a drink)
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
