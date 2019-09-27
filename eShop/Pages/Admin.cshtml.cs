using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceLayer;

namespace eShopWeb.Pages
{
    public class AdminModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; }
        public int Count { get; set; }
        public int PageSize { get; set; } = 5;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public List<Phone> Phones { get; set; }

        public void OnGet([FromServices] IShopService _shopService)
        {
            Phones = _shopService.GetPhones().ToList();
        }
    }
}