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
    public class MezuatSilController : Controller
    {
        ItblKanunService ITblKanunService;
        ItblYonetmenlikService _ItblYonetmenlikService;
        ItblKullanicilarService _ItblKullanicilarService;

        public MezuatSilController(ItblKanunService kanun, ItblYonetmenlikService yonet, ItblKullanicilarService ItblKullanicilarService)
        {
            ITblKanunService = kanun;
            _ItblYonetmenlikService = yonet;
            _ItblKullanicilarService = ItblKullanicilarService;
        }
        public IActionResult Index()
        {
            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser model = new ModelUser();

            model.name = tblKullanicilar.Isim;
            model.surname = tblKullanicilar.Soyisim;
            model.isSuccessfull = null;
            model.yonetmenliklist = _ItblYonetmenlikService.GetAll();
            model.kanunlist = ITblKanunService.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ModelUser mod)
        {
            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);

            ModelUser model = new ModelUser();

            model.name = tblKullanicilar.Isim;
            model.surname = tblKullanicilar.Soyisim;
            model.isSuccessfull = null;
            StaticValues.isİtKanun = mod.Value;
            model.yonetmenliklist = _ItblYonetmenlikService.GetAll();
            model.kanunlist = ITblKanunService.GetAll();
            return View(model);
        }
    }
}
