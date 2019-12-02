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

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

        [BindProperty]
        public float? minPrice { get; set; }

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

        }
    }
}