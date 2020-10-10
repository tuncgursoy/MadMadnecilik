using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.MENU.Controllers
{
    public class KullaniciSilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
