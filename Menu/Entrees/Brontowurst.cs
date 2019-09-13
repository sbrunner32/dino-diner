using System;
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool bun = true;
        private bool pepper = true;
        private bool onion = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (onion) ingredients.Add("Onion");
                if (pepper) ingredients.Add("Peppers");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldPeppers()
        {
            this.pepper = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public void HoldBun()
        {
            this.bun = false;
        }
    }
}


