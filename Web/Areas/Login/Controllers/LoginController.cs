using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Utility;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        ItblKullanicilarService _kullanicilar;

        public LoginController(ItblKullanicilarService kullanicilar)
        {
            _kullanicilar = kullanicilar;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ModelLogin model)
        {
            model.iserror = false;
            int? id = _kullanicilar.LoginID(model.email, model.password);
            if (id!=null&&_kullanicilar.GetById(id).aktif==1)
            {
                StaticValues.LoginId = id; 
               return RedirectToAction("Index","Start", new { area = "MENU" });
            }
            else
            {
                model.iserror = true;
                return View(model);
            }
            
        }
    }
}
