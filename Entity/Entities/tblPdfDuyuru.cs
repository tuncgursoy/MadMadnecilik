using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblPdfDuyuru : IEntity
    {
        public int PdfId { get; set; }
        public int DuyuruId { get; set; }

        public virtual TblDuyuru Duyuru { get; set; }
        public virtual tblPdf Pdf { get; set; }
    }
}
