using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.MENU.Models;
using Web.Utility;

namespace Web.Areas.MENU.Controllers
{

    public class DüzenleDuyuruController : Controller
    {
        ITblDuyuruService _ITblDuyuruService;
        ItblPdfService _ItblPdfService;
        ItblResimDuyuruService _ItblResimDuyuruService;
        ItblResimService _ItblResimService;
        ItblPdfDuyuruService _ItblPdfDuyuruService;
        ItblKullanicilarService _IKullanicilarService;
        public DüzenleDuyuruController(ITblDuyuruService ITblDuyuruService, ItblPdfService ItblPdfService,
            ItblResimDuyuruService ItblresimDuyuruService,
            ItblResimService ItblResimService,
            ItblPdfDuyuruService ItblPdfDuyuruService, ItblKullanicilarService IKullanicilarService)
        {
            _ITblDuyuruService = ITblDuyuruService;
            _ItblPdfService = ItblPdfService;
            _ItblPdfDuyuruService = ItblPdfDuyuruService;
            _ItblResimService = ItblResimService;
            _ItblResimDuyuruService = ItblresimDuyuruService;
            _IKullanicilarService = IKullanicilarService;
        }

        public IActionResult Index()
        {
            tblKullanicilar tblKullanicilar = _IKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser user = new ModelUser();
            user.name = tblKullanicilar.Isim;
            user.surname = tblKullanicilar.Soyisim;
            user.listDuyuru = _ITblDuyuruService.GetAll().ToList();
            return View(user);
        }

       
    }
}
