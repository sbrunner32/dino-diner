using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Public class to represent the side dish Triceritops.
    /// </summary>
    public class Triceritots : Side, IMenuItem
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
        /// Protected member that holds the size of the side dish.
        /// </summary>
        protected Size size;

        /// <summary>
        /// Public Override to set/get size and change calories and price accordingly.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Calories = 352;
                        this.Price = 0.99;
                        break;
                    case Size.Medium:
                        this.Calories = 410;
                        this.Price = 1.45;
                        break;
                    case Size.Large:
                        this.Calories = 590;
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
        /// Public constructor for default order of Triceritops.
        /// </summary>
        public Triceritots() : base()
        {
            this.Price = 0.99;
            this.Calories = 352;

        }

        /// <summary>
        /// Override of the ToString method 
        /// </summary>
        /// <returns>The size and name of this side item</returns>
        public override string ToString()
        {
            return ($"{size} Triceritots");
        }
    }
}
