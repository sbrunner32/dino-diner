using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Public class for the side item Fryceritops which inherits from the Side base class
    /// </summary>
    public class Fryceritops : Side, IMenuItem
    {   
        /// <summary>
        /// Overrides the side class implementation of ingredients to display the side's ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// Protected member that holds the size of the Meteor Mac and Cheese.
        /// </summary>
        protected Size size;

        /// <summary>
        /// Public Override to set/get size and change calories and price accordingly.
        /// </summary>
        public override Size Size
        {
            set{
                size = value;
                switch(size)
                {
                    case Size.Small:
                        this.Calories = 222;
                        this.Price = 0.99;
                        break;
                    case Size.Medium:
                        this.Calories = 365;
                        this.Price = 1.45;
                        break;
                    case Size.Large:
                        this.Calories = 480;
                        this.Price = 1.95;
                        break;
                    }
            }
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Public constructor for default order of Fryceritops.
        /// </summary>
        public Fryceritops(): base()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.size = Size.Small;            
        }

        /// <summary>
        /// Override of the ToString method 
        /// </summary>
        /// <returns>The size and name of this side item</returns>
        public override string ToString()
        {
            return ($"{size} Fryceritops");
        }
    }
}
