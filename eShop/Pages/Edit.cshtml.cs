using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace eShopWeb.Pages
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Phone Phone { get; set; }
        public SelectList Firma { get; set; }

    }
}