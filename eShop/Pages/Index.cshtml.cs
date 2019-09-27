using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ServiceLayer;

namespace eShopWeb.Pages
{
    public class IndexModel : PageModel
    {
        public List<Phone> Phones { get; set; }
        
        public Phone PhoneCompanies { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string FirmaNavn { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortPhone { get; set; }

        public SelectList Firma { get; set; }

        public void OnGet([FromServices] IShopService _shopService)
        {
            Phones = _shopService.GetPhones().ToList();
        }
    }
}
