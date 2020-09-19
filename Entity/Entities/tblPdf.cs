using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblPdf : IEntity
    {
        public tblPdf()
        {
            TblPdfDuyuru = new HashSet<tblPdfDuyuru>();
            TblPdfProje = new HashSet<tblPdfProje>();
        }

        public int Id { get; set; }
        public string PdfUrl { get; set; }

        public virtual ICollection<tblPdfDuyuru> TblPdfDuyuru { get; set; }
        public virtual ICollection<tblPdfProje> TblPdfProje { get; set; }
    }
}
