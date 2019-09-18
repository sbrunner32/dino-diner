using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        protected Size size;
        public override Size Size
        {
            set{
                size = value;
                switch(size)
                {
                    case Size.Small:
                        this.Calories = 222;
                        this.Price = 0.99;
                        break;
                    case Size.Medium:
                        this.Calories = 365;
                        this.Price = 1.45;
                        break;
                    case Size.Large:
                        this.Calories = 480;
                        this.Price = 1.95;
                        break;
                    }
            }
            get
            {
                return size;
            }
        }
        public Fryceritops(): base()
        {
            this.Price = 0.99;
            this.Calories = 222;            
            
        }
    }
}
