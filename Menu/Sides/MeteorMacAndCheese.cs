/* MeteorMacAndCheese Class
 * Author: Sam Brunner
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Public class for the side Meteor Mac and Cheese
    /// </summary>
    public class MeteorMacAndCheese : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Calories = 420;
                        this.Price = 0.99;
                        break;
                    case Size.Medium:
                        this.Calories = 490;
                        this.Price = 1.45;
                        break;
                    case Size.Large:
                        this.Calories = 520;
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
        /// Public constructor for default order of Meteor Mac and cheese.
        /// </summary>
        public MeteorMacAndCheese() : base()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Size = Size.Small; 

        }

        /// <summary>
        /// Override of the ToString method 
        /// </summary>
        /// <returns>The size and name of this side item</returns>
        public override string ToString()
        {
            return ($"{size} Meteor Mac and Cheese");
        }
    }
}
