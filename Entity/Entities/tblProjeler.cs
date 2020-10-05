using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblProjeler : IEntity
    {
        public tblProjeler()
        {
            TblPdfProje = new HashSet<tblPdfProje>();
            TblResimProje = new HashSet<tblResimProje>();
        }

        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public int? aktif { get; set; }


        public virtual ICollection<tblPdfProje> TblPdfProje { get; set; }
        public virtual ICollection<tblResimProje> TblResimProje { get; set; }
    }
}
