using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class to represent Water which inherits from the Drink class
    /// </summary>
    public class Water : Drink, IMenuItem
    {
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
                List<string> temp = new List<string>() { "Water" };
                if (Lemon)
                    temp.Add("Lemon");                
                return temp;
            }
        }

        /// <summary>
        /// Override to get and set the Size of the water. Defaults to the value of Small
        /// </summary>
        public override Size Size { get; set; } = Size.Small;


        /// <summary>
        /// Base constructor for Water which sets default Price and Calories
        /// </summary>
        public Water() : base()
        {
            this.Price = 0.10;
            this.Calories = 0;
            this.Size = Size.Small;
        }

        /// <summary>
        /// Public method to add Lemon to the Water
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

        /// <summary>
        /// Override of the ToString method 
        /// </summary>
        /// <returns>The size and name of this side item</returns>
        public override string ToString()
        {
            return ($"{Size} Water");
        }

    }
}
