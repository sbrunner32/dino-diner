using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class for Tyrannotea that inherits from the Drink class
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Protected property for whether or not the Tea is sweet. 
        /// </summary>
        protected bool sweet = false;

        /// <summary>
        /// Public getter and setter that stores whether or not the Tyrannotea is sweet, defaults to false
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                if (sweet)
                    this.Calories *= 2;
                else
                    this.Calories /= 2;
            }
        } 

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
                List<string> temp = new List<string>() { "Water", "Tea" };
                if (Lemon)
                    temp.Add("Lemon");
                if (Sweet)
                    temp.Add("Cane Sugar");
                return temp;
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
            this.Price = 0.99;
            this.Calories = 8;
            this.size = Size.Small;
        }

       
        /// <summary>
        /// Public method to add Lemon to the Tyrannotea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
