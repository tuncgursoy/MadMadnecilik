using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Dto.Model;
using Business.Dto.Response;
using Entity.Entities;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.MENU.Models;
using Web.Models;
using Web.Utility;

namespace Web.Areas.MENU.Controllers
{
    public class DuyuruSilController : Controller
    {
        ITblDuyuruService _ITblDuyuruService;
        ItblPdfService _ItblPdfService;
        ItblResimDuyuruService _ItblResimDuyuruService;
        ItblResimService _ItblResimService;
        ItblKullanicilarService _IKullanicilarService;
        ItblPdfDuyuruService _ItblPdfDuyuruService;

        public DuyuruSilController(ITblDuyuruService ITblDuyuruService, ItblPdfService ItblPdfService,
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

            DuyurularDtoResponse db = new DuyurularDtoResponse(_ItblResimDuyuruService, _ItblPdfDuyuruService, _ITblDuyuruService, _ItblResimService, _ItblPdfService);
            ModelDuyurular model = new ModelDuyurular();
            model.listDuyuru = new List<DuyurularDto>();
            string Url = Request.GetDisplayUrl();
            string[] sub = Url.Split("/");
            int length = sub.Length;
            int id = Int32.Parse(sub[length - 1].Substring(0, 1));
            ModelUser modelDuyuru = new ModelUser();
            modelDuyuru.duyuru = new DuyurularDto();
            foreach (var VARIABLE in db.DuyuruList())
            {
                if (id == VARIABLE.id)
                {
                    modelDuyuru.duyuru = VARIABLE;
                }
            }

            modelDuyuru.duyuru.array = modelDuyuru.duyuru.aciklama.Split("<br>");
            modelDuyuru.name = tblKullanicilar.Isim;
            modelDuyuru.surname = tblKullanicilar.Soyisim;
            return View(modelDuyuru);
        }

        [HttpPost]
        public IActionResult Index(ModelUser model)
        {
           
            string Url = Request.GetDisplayUrl();
            string[] sub = Url.Split("/");
            int length = sub.Length;
            int id = Int32.Parse(sub[length - 1].Substring(0, 1));
            TblDuyuru temp = _ITblDuyuruService.GetById(id);
            if (temp.aktif==1)
            {
                temp.aktif = 0; 
            }
            else
            {
                temp.aktif = 1; 
            }
            _ITblDuyuruService.Update(temp);

            tblKullanicilar tblKullanicilar = _IKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser user = new ModelUser();
            user.name = tblKullanicilar.Isim;
            user.surname = tblKullanicilar.Soyisim;

            DuyurularDtoResponse db = new DuyurularDtoResponse(_ItblResimDuyuruService, _ItblPdfDuyuruService, _ITblDuyuruService, _ItblResimService, _ItblPdfService);
            ModelDuyurular model1 = new ModelDuyurular();
            model1.listDuyuru = new List<DuyurularDto>();
            string Url1 = Request.GetDisplayUrl();
            string[] sub1 = Url1.Split("/");
            int length1 = sub.Length;
            int id1 = Int32.Parse(sub1[length1 - 1].Substring(0, 1));
            ModelUser modelDuyuru = new ModelUser();
            modelDuyuru.duyuru = new DuyurularDto();
            foreach (var VARIABLE in db.DuyuruList())
            {
                if (id1 == VARIABLE.id)
                {
                    modelDuyuru.duyuru = VARIABLE;
                }
            }

            modelDuyuru.name = tblKullanicilar.Isim;
            modelDuyuru.surname = tblKullanicilar.Soyisim;

            modelDuyuru.duyuru.array = modelDuyuru.duyuru.aciklama.Split("<br>");
            return View(modelDuyuru);
        }
    }
}
