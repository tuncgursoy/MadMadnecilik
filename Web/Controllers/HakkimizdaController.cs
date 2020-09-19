using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HakkimizdaController : Controller
    {
         ItblKullanicilarService _IKullanicilarService;

         public HakkimizdaController(ItblKullanicilarService IKullanicilarService)
         {
             _IKullanicilarService = IKullanicilarService;
         }

         public IActionResult Index()
        {
           
            ModelHakkimizda model=new ModelHakkimizda();
            model.list = new List<tblKullanicilar>();
            foreach (var VARIABLE in _IKullanicilarService.GetAll())
            {
                
              model.list.Add(VARIABLE);
            }
            return View(model);
        }
    }
}
