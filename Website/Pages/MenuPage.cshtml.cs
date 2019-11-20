﻿using System;
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