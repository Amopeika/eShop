using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer;

namespace eShop.Pages
{
    public class DetailModel : PageModel
    {
        public Phone phone { get; set; }

        [TempData]
        public string Message { get; set; }

        private readonly IShopService _shopService;

        public DetailModel(IShopService shopService)
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