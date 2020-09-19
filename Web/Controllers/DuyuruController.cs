using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Dto.Model;
using Business.Dto.Response;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{

    public class DuyuruController : Controller
    {
        ITblDuyuruService _ITblDuyuruService;
        ItblPdfService _ItblPdfService;
        ItblResimDuyuruService _ItblResimDuyuruService;
        ItblResimService _ItblResimService;
        ItblPdfDuyuruService _ItblPdfDuyuruService;
        public DuyuruController(ITblDuyuruService ITblDuyuruService, ItblPdfService ItblPdfService,
            ItblResimDuyuruService ItblresimDuyuruService,
            ItblResimService ItblResimService,
            ItblPdfDuyuruService ItblPdfDuyuruService)
        {
            _ITblDuyuruService = ITblDuyuruService;
            _ItblPdfService = ItblPdfService;
            _ItblPdfDuyuruService = ItblPdfDuyuruService;
            _ItblResimService = ItblResimService;
            _ItblResimDuyuruService = ItblresimDuyuruService;
        }
        public IActionResult Index()
        {
            DuyurularDtoResponse db = new DuyurularDtoResponse(_ItblResimDuyuruService, _ItblPdfDuyuruService, _ITblDuyuruService, _ItblResimService, _ItblPdfService);
            ModelDuyurular model = new ModelDuyurular();
            model.listDuyuru = new List<DuyurularDto>();
            string Url = Request.GetDisplayUrl();
            string[] sub = Url.Split("/");
            int length = sub.Length;
            int id = Int32.Parse(sub[length - 1].Substring(0, 1));
            ModelDuyuru modelDuyuru = new ModelDuyuru();
            modelDuyuru.duyuru = new DuyurularDto();
            foreach (var VARIABLE in db.DuyuruList())
            {
                if (id==VARIABLE.id)
                {
                    modelDuyuru.duyuru = VARIABLE;
                }
            }
            return View(modelDuyuru);
        }
    }
}
