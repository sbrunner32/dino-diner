using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Public class that represents Mezzorella sticks
    /// </summary>
    public class MezzorellaSticks : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
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
                        this.Calories = 540;
                        this.Price = 0.99;
                        break;
                    case Size.Medium:
                        this.Calories = 610;
                        this.Price = 1.45;
                        break;
                    case Size.Large:
                        this.Calories = 720;
                        this.Price = 1.95;
                        break;
                }
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Public constructor for default order of Mezzorella sticks.
        /// </summary>
        public MezzorellaSticks() : base()
        {
            this.Price = 0.99;
            this.Calories = 540;
            this.Size = Size.Small;

        }

        /// <summary>
        /// Override of the ToString method 
        /// </summary>
        /// <returns>The size and name of this side item</returns>
        public override string ToString()
        {
            return ($"{size} Mezzorella Sticks");
        }
    }
}
