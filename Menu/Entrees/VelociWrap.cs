using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent the Velociwrap
    /// </summary>
    public class VelociWrap : Entree, IMenuItem
    {

        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;


        /// <summary>
        /// Property used to get and set the list of ingredients on this Velociwrap.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" , "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor for this Velociwrap that sets default price and calories.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Method to set this Velociwrap's dressing property to false.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Method to set this Velociwrap's lettuce property to false.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Method to set this Velociwrap's cheese property to false.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }

        /// <summary>
        /// Displays the name of the item
        /// </summary>
        /// <returns>The string value of the item name</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

    }
}
