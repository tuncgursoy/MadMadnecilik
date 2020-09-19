using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblPdfProje : IEntity
    {
        public int PdfId { get; set; }
        public int ProjeId { get; set; }

        public virtual tblPdf Pdf { get; set; }
        public virtual tblProjeler Proje { get; set; }
    }
}
