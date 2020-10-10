using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.MENU.Models;
using Web.Utility;

namespace Web.Areas.MENU.Controllers
{
    public class KullaniciSilController : Controller
    {
        ItblKullanicilarService _ItblKullanicilarService;

        public KullaniciSilController(ItblKullanicilarService kul)
        {
            _ItblKullanicilarService = kul;
        }
        public IActionResult Index()
        {
            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser user = new ModelUser();
            user.name = tblKullanicilar.Isim;
            user.surname = tblKullanicilar.Soyisim;
            return View(user);
        }

        [HttpPost]
        public IActionResult Index(ModelUser user)
        {
            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser model = new ModelUser();
            model.name = tblKullanicilar.Isim;
            model.surname = tblKullanicilar.Soyisim;
            tblKullanicilar kull = _ItblKullanicilarService.FindbyMail(user.kull.mail,user.icerik);
            if (kull==null)
            {
                model.isSuccessfull = false;
            }
            else
            {
                model.isSuccessfull = true; 
                if (kull.aktif==1)
                {
                    kull.aktif = 0; 
                }
                else
                {
                    kull.aktif = 1;
                }
                _ItblKullanicilarService.Update(kull);
            }

            return View(model);
        }
    }
}
