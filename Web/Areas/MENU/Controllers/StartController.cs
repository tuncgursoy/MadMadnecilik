using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.MENU.Models;
using Web.Utility;

namespace Web.Areas.MENU.Controllers
{
    public class StartController : Controller
    { 
        ItblKullanicilarService _ItblKullanicilarService;

        public StartController(ItblKullanicilarService kul)
        {
            _ItblKullanicilarService = kul; 
        }
        public IActionResult Index()
        {
            if (StaticValues.LoginId==null)
            {
                StaticValues.LoginId = null;
                return Redirect("Giris"); 
            }

            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser user= new ModelUser();
            user.name = tblKullanicilar.Isim;
            user.surname = tblKullanicilar.Soyisim; 
            return View(user);
        }
        [HttpPost]
        public IActionResult logout()
        {
            
            StaticValues.LoginId = null;
            return RedirectToAction("Index", "AnaSayfa",new {area=""});
        }
    }
}
