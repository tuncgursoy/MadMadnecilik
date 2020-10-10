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
    public class MezuatSil1Controller : Controller
    {
        ItblKullanicilarService _IKullanicilarService;
        ItblKanunService        _IKanunService;
        ItblYonetmenlikService _ITblYonetmenlikService;

        public MezuatSil1Controller(ItblKullanicilarService ItKullanicilarService,
            ItblKanunService ItKanunService,
            ItblYonetmenlikService ItTblYonetmenlikService)
        {
            _IKullanicilarService = ItKullanicilarService;
            _IKanunService = ItKanunService;
            _ITblYonetmenlikService = ItTblYonetmenlikService;
        }       
        public IActionResult Index()
        {
            string Url = Request.GetDisplayUrl();
            string[] sub = Url.Split("/");
            int length = sub.Length;
            int id = Int32.Parse(sub[length - 1].Substring(0, 1));
            tblKullanicilar tblKullanicilar = _IKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser model = new ModelUser();
            if (StaticValues.isİtKanun==1)
            {
                foreach (var VARIABLE in _IKanunService.GetAll().ToList())
                {
                    if (id == VARIABLE.Id)
                    {
                        model.kanun = VARIABLE;
                    }
                }
            }else if (StaticValues.isİtKanun == 2)
            {
                foreach (var VARIABLE in _ITblYonetmenlikService.GetAll().ToList())
                {
                    if (id == VARIABLE.Id)
                    {
                        model.yonetmenlik = VARIABLE;
                    }
                }
            }
          

            model.name = tblKullanicilar.Isim;
            model.surname = tblKullanicilar.Soyisim;
            model.isSuccessfull = null;
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(ModelUser user)
        {
            ModelUser model = new ModelUser();
            tblKullanicilar tblKullanicilar = _IKullanicilarService.GetById(StaticValues.LoginId);
            string Url = Request.GetDisplayUrl();
            string[] sub = Url.Split("/");
            int length = sub.Length;
            int id = Int32.Parse(sub[length - 1].Substring(0, 1));
            if (StaticValues.isİtKanun == 1)
            {
                foreach (var VARIABLE in _IKanunService.GetAll().ToList())
                {
                    if (id == VARIABLE.Id)
                    {
                        model.kanun = VARIABLE;
                    }
                }
            }
            else if (StaticValues.isİtKanun == 2)
            {
                foreach (var VARIABLE in _ITblYonetmenlikService.GetAll().ToList())
                {
                    if (id == VARIABLE.Id)
                    {
                        model.yonetmenlik = VARIABLE;
                    }
                }
            }

            if (model.kanun.aktif==0)
            {
                if (StaticValues.isİtKanun == 1)
                {
                    model.kanun.aktif = 1;
                }
                else if (StaticValues.isİtKanun == 2)
                {
                    model.yonetmenlik.aktif = 1;
                }
            }else 
            {
                if (StaticValues.isİtKanun == 1)
                {
                    model.kanun.aktif = 0;
                }
                else if (StaticValues.isİtKanun == 2)
                {
                    model.yonetmenlik.aktif = 0;
                }
            }
            if (StaticValues.isİtKanun == 1)
            {
                _IKanunService.Update(model.kanun);
            }
            else if (StaticValues.isİtKanun == 2)
            {
                _ITblYonetmenlikService.Update(model.yonetmenlik);
            }

            model.name = tblKullanicilar.Isim;
            model.surname = tblKullanicilar.Soyisim;
            return View(model); 
        }
    }
   

}
