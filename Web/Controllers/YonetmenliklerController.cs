using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class YonetmenliklerController : Controller
    {
        ItblYonetmenlikService _yonetmenlik;

        public YonetmenliklerController(ItblYonetmenlikService yonetmenlik)
        {
            _yonetmenlik = yonetmenlik;
        }

         ModelYonet model;
        public IActionResult Index()
        {
            List<tblyonetmenlik> yonetmenliklist = _yonetmenlik.GetAll().ToList();
            model = new ModelYonet();
            model.yonetmenliklist = new List<tblyonetmenlik>();
            for (int i = yonetmenliklist.Count - 1; 0 <= i; i--)
            {
                if (yonetmenliklist[i].aktif==0)
                {
                model.yonetmenliklist.Add(yonetmenliklist[i]);

                }
            }
            return View(model);
        }
    }
}
