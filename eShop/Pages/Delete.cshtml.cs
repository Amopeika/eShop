﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer;

namespace eShopWeb.Pages
{
    public class DeleteModel : PageModel
    {
        public Phone phone { get; set; }

        private readonly IShopService _shopService;
        public DeleteModel(IShopService shopService)
        {
            _shopService = shopService;
        }

        public IActionResult OnGet(int phoneid)
        {
            phone = _shopService.GetOnePhone(phoneid);

            return Page();
        }
    }
}