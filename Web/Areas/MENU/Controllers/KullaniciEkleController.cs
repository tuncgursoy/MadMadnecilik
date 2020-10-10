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
    public class KullaniciEkleController : Controller
    {
        private ItblKullanicilarService kull;

        public KullaniciEkleController(ItblKullanicilarService kull1)
        {
            kull = kull1;

        }
        public IActionResult Index()
        {
            tblKullanicilar kullanici = kull.GetById(StaticValues.LoginId);
            ModelUser model = new ModelUser();
            model.name = kullanici.Isim;
            model.surname = kullanici.Soyisim; 
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ModelUser user)
        {
            tblKullanicilar kullanici = kull.GetById(StaticValues.LoginId);
            ModelUser model = new ModelUser();
            model.name = kullanici.Isim;
            model.surname = kullanici.Soyisim;

            tblKullanicilar temp = new tblKullanicilar();
            temp.Soyisim = user.kull.surname;
            temp.Isim = user.kull.name;
            temp.Id = kull.GetAll().ToList().Count + 1;
            temp.Sifre = "123456";
            temp.rol = user.kull.rolu;
            temp.Mail = user.kull.mail;
            temp.aktif = 1; 
            kull.Add(temp);
            model.isSuccessfull = true;
            return View(model);
        }
    }
}
