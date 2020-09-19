using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class AnaSayfaController : Controller
    {
        ItblBilgilerService _ItblBilgilerService;

       
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
