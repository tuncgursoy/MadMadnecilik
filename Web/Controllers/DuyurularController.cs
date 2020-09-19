using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Dto.Model;
using Business.Dto.Response;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class DuyurularController : Controller
    {
        ITblDuyuruService _ITblDuyuruService;
        ItblPdfService _ItblPdfService;
        ItblResimDuyuruService _ItblResimDuyuruService;
        ItblResimService _ItblResimService;
        ItblPdfDuyuruService _ItblPdfDuyuruService;
        public DuyurularController(ITblDuyuruService ITblDuyuruService, ItblPdfService ItblPdfService,
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
            DuyurularDtoResponse db = new DuyurularDtoResponse(_ItblResimDuyuruService,_ItblPdfDuyuruService,_ITblDuyuruService,_ItblResimService,_ItblPdfService);
            ModelDuyurular model = new ModelDuyurular();
            model.listDuyuru=new List<DuyurularDto>();

            for (int i = db.DuyuruList().Count-1; 0 <= i; i--)
            {
                model.listDuyuru.Add(db.DuyuruList()[i]);
            }
            return View(model);
        }
    }
}
