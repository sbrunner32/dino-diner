/* Triceritots Class
 * Author: Sam Brunner
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Public class to represent the side dish Triceritops.
    /// </summary>
    public class Triceritots : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

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
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Description");
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
            this.Size = Size.Small;
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
