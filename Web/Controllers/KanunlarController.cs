using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class KanunlarController : Controller
    {
        ItblKanunService _kanun;

        public KanunlarController(ItblKanunService kanun)
        {
            _kanun = kanun;
        }

        private ModelKanun model;
        public IActionResult Index()
        {
            List<tblKanun> kanunlist = _kanun.GetAll().ToList();
            model = new ModelKanun();
            model.kanunlist = new List<tblKanun>();
            for (int i = kanunlist.Count-1 ; 0<=i; i--)
            {
                model.kanunlist.Add(kanunlist[i]);
            }
            return View(model); 
        }
    }
}
