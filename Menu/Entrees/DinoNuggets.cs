﻿using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Public class for the DinoNuggets entree.
    /// </summary>
    public class DinoNuggets
    {
        private int nuggetCount { get; set; }

        /// <summary>
        /// Property used to get and set the value of the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Property used to get and set the value of the calories.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Property used to get and set the list of ingredients on this order of DinoNuggets.
        /// </summary>
        public List<string> Ingredients
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
        }

        
        
    }
}
    
