using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for JurrasicJava that inherits from the Drink class
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Public property to determine if the coffee is decaf or not, default value of false
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Public property that determines if there is room for cream in this coffee, default value of false.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Public override property to set/get the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
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
                        this.Calories = 2;
                        this.Price = 0.59;
                        break;
                    case Size.Medium:
                        this.Calories = 4;
                        this.Price = 0.99;
                        break;
                    case Size.Large:
                        this.Calories = 8;
                        this.Price = 1.49;
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
        public JurrasicJava() : base()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
            this.size = Size.Small;
        }

        /// <summary>
        /// Public method to set the Ice property to true (requesting Ice with the coffee)
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }

        /// <summary>
        /// Method to leave room for cream by setting the RoomForCream property to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
    }
}
