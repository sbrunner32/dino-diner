using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the Prehistoric PBJ sandwich.
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem 
    {
        private bool peanutButter = true;
        private bool jelly = true;

       
        /// <summary>
        /// Property used to get and set the list of ingredients on this Prehistoric PBJ sandwich.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor for PrehistoricPBJ that sets default price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Method to set this PrehistoricPBJ's peanutButter property to false.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Method to set this PrehistoricPBJ's jelly property to false.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }

        /// <summary>
        /// Displays the name of the item
        /// </summary>
        /// <returns>The string value of the item name</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
