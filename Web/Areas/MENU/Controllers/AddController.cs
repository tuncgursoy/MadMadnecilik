using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.MENU.Models;
using Web.Utility;

namespace Web.Areas.MENU.Controllers
{
    public class AddController : Controller
    {
        ItblYonetmenlikService _ItblYonetmenlikService;
        ItblKanunService _ItblKanunService;
        ItblKullanicilarService _ItblKullanicilarService;

        public AddController(ItblYonetmenlikService ItblYonetmenlikService,
            ItblKanunService ItblKanunService, ItblKullanicilarService ItblKullanicilarService)
        {
            _ItblKanunService = ItblKanunService;
            _ItblYonetmenlikService = ItblYonetmenlikService;
            _ItblKullanicilarService = ItblKullanicilarService;
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
        public IActionResult Index(ModelUser model)
        {
            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser user = new ModelUser();
            user.name = tblKullanicilar.Isim;
            user.surname = tblKullanicilar.Soyisim;
            if (model.cat == 1)
            {
                tblKanun temp = new tblKanun();
                temp.Adi = model.baslik;
                temp.Id = _ItblKanunService.GetAll().ToList().Count + 1;
                temp.Url = model.url;
                temp.aktif = 0;
                _ItblKanunService.Add(temp);
                model.isSuccessfull = true;
                
            }
            else if (model.cat == 2)
            {
                tblyonetmenlik temp = new tblyonetmenlik();
                temp.Adi = model.baslik;
                temp.Id = _ItblYonetmenlikService.GetAll().ToList().Count + 1;
                temp.Url = model.url;
                _ItblYonetmenlikService.Add(temp);
                temp.aktif = 0;
                model.isSuccessfull = true;

            }
            else
            {
                user.isSuccessfull = false;

            }

            return View(user);
        }
    }
}
