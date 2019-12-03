using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuPageModel : PageModel
    {
        private Menu _menu = new Menu();
        private List<IMenuItem> combos = new List<IMenuItem>();
        private List<IMenuItem> entrees = new List<IMenuItem>();
        private List<IMenuItem> sides = new List<IMenuItem>();
        private List<IMenuItem> drinks = new List<IMenuItem>();

        public List<IMenuItem> AvailableCombos
        {
            get
            {
                return combos;
            }
            set
            {
                combos = value;
            }
        }

        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                return entrees;
            }
            set
            {
                entrees = value;
            }
        }

        public List<IMenuItem> AvailableSides
        {
            get
            {
                return sides;
            }
            set
            {
                sides = value;
            }
        }

        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                return drinks;
            }
            set
            {
                drinks = value;
            }
        }


        public IEnumerable<IMenuItem> Items;

        [BindProperty]
        public string search { get; set; } = "";

        [BindProperty]
        public float? maxPrice { get; set; } = 10;

        [BindProperty]
        public float? minPrice { get; set; } = 0;

        [BindProperty]
        public List<string> selectedCategories { get; set; } = new List<string>();

        [BindProperty]
        public List<string> selectedIngredients { get; set; } = new List<string>();

        public Menu Menu
        {
            get
            {
                return _menu;
            }
        }

        public void OnGet()
        {
            Items = _menu.AvailableMenuItems;
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;
        }

        public void OnPost()
        {
            Items = _menu.AvailableMenuItems;
            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;
            List<IMenuItem> tempSorted = new List<IMenuItem>();

            if(search != null)
            {
                Items = Items.Where(item => item.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if(selectedCategories.Count > 0)
            {

                if (selectedCategories.Contains("Combo"))
                {
                    foreach (CretaceousCombo combo in AvailableCombos)
                        tempSorted.Add(combo);
                }
                if (selectedCategories.Contains("Entree"))
                {
                    foreach (IMenuItem entree in AvailableEntrees)
                        tempSorted.Add(entree);
                }
                if (selectedCategories.Contains("Side"))
                {
                    foreach (IMenuItem side in AvailableSides)
                        tempSorted.Add(side);
                }
                if (selectedCategories.Contains("Drink"))
                {
                    foreach (IMenuItem drink in AvailableDrinks)
                        tempSorted.Add(drink);
                }
                Items = tempSorted;
            }

            if(minPrice != null)
            {
                Items = Items.Where(item => item.Price >= minPrice);
            }
            if (maxPrice != null)
            {
                Items = Items.Where(item => item.Price <= maxPrice);
            }
        }

        
    }
}