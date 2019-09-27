using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;

namespace eShopWeb.Pages
{
    public class CreateModel : PageModel
    {

        [TempData]
        public string TempTest { get; set; }

        [BindProperty]
        public Phone Phone { get; set; }

        public SelectList Firma { get; set; }

    }
}