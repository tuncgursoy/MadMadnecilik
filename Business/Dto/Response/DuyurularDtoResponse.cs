using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Dto.Model;
using Entity.Entities;

namespace Business.Dto.Response
{
    public class DuyurularDtoResponse
    {
        ItblResimDuyuruService _ItblResimDuyuruService;
        ItblPdfDuyuruService _ItblPdfDuyuruService;
        ITblDuyuruService _ITblDuyuruService;
        ItblResimService _ItblResimService;
        ItblPdfService _ItblPdfService;

        public DuyurularDtoResponse(
            ItblResimDuyuruService ItblResimDuyuruService,
        ItblPdfDuyuruService ItblPdfDuyuruService,
        ITblDuyuruService ITblDuyuruService,
        ItblResimService ItblResimService,
        ItblPdfService ItblPdfService)
        {
            _ITblDuyuruService = ITblDuyuruService;
            _ItblPdfDuyuruService = ItblPdfDuyuruService;
            _ItblResimDuyuruService = ItblResimDuyuruService;
            _ItblResimService = ItblResimService;
            _ItblPdfService = ItblPdfService;
        }

        public List<DuyurularDto> DuyuruList()
        {
            List<DuyurularDto> list = new List<DuyurularDto>();
            DuyurularDto duyuru;
            List<TblDuyuru> duyurulist = _ITblDuyuruService.GetAll().ToList();
            foreach (var tblDuyuru in duyurulist)
            {
                duyuru=new DuyurularDto();
                if ((_ItblPdfDuyuruService.GetById(tblDuyuru.Id)==null))
                {
                    duyuru.PdfUrl = null;
                }else
                {
                    duyuru.PdfUrl = _ItblPdfService.GetById(_ItblPdfDuyuruService.GetById(tblDuyuru.Id).PdfId).PdfUrl;

                }

                if (_ItblResimDuyuruService.GetById(tblDuyuru.Id)==null)
                {
                    duyuru.resimUrl = "images/duyuru.jpg";
                }
                else
                {
                    duyuru.resimUrl = _ItblResimService.GetById(_ItblResimDuyuruService.GetById(tblDuyuru.Id).ResimId).ResimUrl;
                }
                duyuru.aciklama = tblDuyuru.İcerik;
                duyuru.baslik = tblDuyuru.Baslik;
                duyuru.id = tblDuyuru.Id;
                duyuru.Date = tblDuyuru.UploadTime;
                duyuru.aktif = tblDuyuru.aktif;
                list.Add(duyuru);
            }

            return list;    
        }

    }

}
