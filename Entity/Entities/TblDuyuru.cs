using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class TblDuyuru : IEntity
    {
        public TblDuyuru()
        {
            TblPdfDuyuru = new HashSet<tblPdfDuyuru>();
            TblResimDuyuru = new HashSet<tblResimDuyuru>();
        }

        public int Id { get; set; }
        public DateTime UploadTime { get; set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }

        public virtual ICollection<tblPdfDuyuru> TblPdfDuyuru { get; set; }
        public virtual ICollection<tblResimDuyuru> TblResimDuyuru { get; set; }
    }
}
