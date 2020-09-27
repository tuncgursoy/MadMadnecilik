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
    public class PasswordChangeController : Controller
    {
        ItblKullanicilarService _ItblKullanicilarService;

        public PasswordChangeController(ItblKullanicilarService kul)
        {
            _ItblKullanicilarService = kul;
        }
        public IActionResult Index()
        {
            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser user = new ModelUser();
            user.name = tblKullanicilar.Isim;
            user.surname = tblKullanicilar.Soyisim;
            user.isSuccessfull = null;
            return View(user);
        }
        [HttpPost]
        public IActionResult Index(ModelUser model)
        {
            ModelUser user = new ModelUser();

            tblKullanicilar change = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            if (model.password1==model.password2&&model.password1!=null&&model.password1!="")
            {
            change.Sifre = model.password1;
            _ItblKullanicilarService.Update(change);
            user.isSuccessfull = true;

            }
            else
            {
                user.isSuccessfull = false; 
            }
            user.name = change.Isim;
            user.surname = change.Soyisim;
            return View(user);
        }
    }
}
