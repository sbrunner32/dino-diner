/* DinoNuggets Class
 * Author: Sam Brunner
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the DinoNuggets entree.
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {        
        private int nuggetCount { get; set; }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggetCount > 6) special.Add($"{nuggetCount-6} Extra Nuggets");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Property used to get and set the list of ingredients on this order of DinoNuggets.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i=0; i< nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Default constructor for DinoNuggets which sets the default price, calories, and nuggetCount. 
        /// </summary>
        public DinoNuggets()
        {
            this.nuggetCount = 6;
            this.Price = 4.25;
            this.Calories = (uint)(59 * nuggetCount);
        }

        /// <summary>
        /// Method to add one to the nuggetCount, as well as update the price, calories, and ingredients accordingly.
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount++;
            this.Price += 0.25;
            this.Calories += 59;
            this.Ingredients.Add("Chicken Nugget");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
            NotifyOfPropertyChange("Calories");
            NotifyOfPropertyChange("Price");
        }

        /// <summary>
        /// Displays the name of the item
        /// </summary>
        /// <returns>The string value of the item name</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Resets the nugget count to 6
        /// </summary>
        public void ResetNuggetCount()
        {
            int temp = this.nuggetCount;
            if(temp != 6)
            {
                this.nuggetCount = 6;
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
            }
            
            
            
        }

       

    }
}
    
