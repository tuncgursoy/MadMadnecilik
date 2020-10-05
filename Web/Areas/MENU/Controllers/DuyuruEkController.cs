using System;
using System.Collections.Generic;
using System.IO;
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
    public class DuyuruEkController : Controller
    {
         ItblResimService _itblResimService;
         ItblResimDuyuruService _itResimDuyuruService;
         ITblDuyuruService _itbkDuyuruService;
         ItblPdfDuyuruService _itblpdfDuyuruService;
         ItblPdfService _itblPdfService;
         ItblKullanicilarService _ItblKullanicilarService;
         private readonly IHostingEnvironment _hostingEnvironment;

        public DuyuruEkController(ItblResimService itblResimService,
             ItblResimDuyuruService itResimDuyuruService,
             ITblDuyuruService itbkDuyuruService,
             ItblPdfDuyuruService itblpdfDuyuruService,
             ItblPdfService itblPdfService, ItblKullanicilarService ItblKullanicilarService, IHostingEnvironment hostingEnvironment)
         {
             _itblPdfService = itblPdfService;
             _itResimDuyuruService = itResimDuyuruService;
             _itblResimService = itblResimService;
             _itbkDuyuruService = itbkDuyuruService;
             _itblpdfDuyuruService = itblpdfDuyuruService;
             _ItblKullanicilarService = ItblKullanicilarService;
             _hostingEnvironment = hostingEnvironment;
         }
         
        public IActionResult Index()
        {
            try
            {
                tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
                ModelUser user = new ModelUser();
                user.name = tblKullanicilar.Isim;
                user.surname = tblKullanicilar.Soyisim;
                return View(user);
            }
            catch (Exception e)
            {
                return  Redirect("Giris");
            }
            
        }

        [HttpPost]
        public IActionResult Index(ModelUser model)
        {
            tblKullanicilar tblKullanicilar = _ItblKullanicilarService.GetById(StaticValues.LoginId);
            ModelUser user = new ModelUser();
            user.name = tblKullanicilar.Isim;
            user.surname = tblKullanicilar.Soyisim;
            List<TblDuyuru> duyurlar = _itbkDuyuruService.GetAll().ToList();
            
            string e = model.icerik.Replace(Environment.NewLine, "<br>");

            int temp = duyurlar.Count + 1; ; 

           
            _itbkDuyuruService.Add(new TblDuyuru()
            {
                Baslik = model.baslik,
                Id = duyurlar.Count + 1,
                UploadTime = DateTime.Now,
                İcerik = e,
                aktif = 0

            });

            if (model.resimUrl != null)
            {
                var fileName = _hostingEnvironment.WebRootPath + @"\Main\images\resimler\";
                model.resimUrl.CopyTo(new FileStream(fileName + (_itblResimService.GetAll().ToList().Count + 1) + ".jpg", FileMode.Create));
                string ResimUrl = "images/resimler/" + (_itblResimService.GetAll().ToList().Count + 1) + ".jpg";
                int temp1 = _itblResimService.GetAll().ToList().Count + 1;
                _itblResimService.Add(new tblResim()
                {
                    Id=_itblResimService.GetAll().ToList().Count+1,
                    ResimUrl = ResimUrl

                });
                _itResimDuyuruService.Add(new tblResimDuyuru()
                {
                    DuyuruId = temp,
                    ResimId = temp1
                });
            }
            

            if (model.dosyaUrl != null)
            {
                var fileName = _hostingEnvironment.WebRootPath + @"\Main\pdfs\";
                model.dosyaUrl.CopyTo(new FileStream(fileName + (_itblPdfService.GetAll().ToList().Count + 1) + ".pdf",
                    FileMode.Create));
                string pdfurl = "pdfs/" + (_itblPdfService.GetAll().ToList().Count + 1) + ".pdf";

                int temp1 = _itblPdfService.GetAll().ToList().Count + 1;
                _itblPdfService.Add(new tblPdf()
                {
                    Id = _itblPdfService.GetAll().ToList().Count + 1,
                    PdfUrl = pdfurl
                });
                _itblpdfDuyuruService.Add(new tblPdfDuyuru()
                {
                    DuyuruId = temp,
                    PdfId = temp1
                });
            }

            user.isSuccessfull = true;

            return View(user);
        }
    }
}
