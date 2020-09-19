using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblResim : IEntity
    {
        public tblResim()
        {
            TblResimDuyuru = new HashSet<tblResimDuyuru>();
            TblResimProje = new HashSet<tblResimProje>();
        }

        public int Id { get; set; }
        public string ResimUrl { get; set; }

        public virtual ICollection<tblResimDuyuru> TblResimDuyuru { get; set; }
        public virtual ICollection<tblResimProje> TblResimProje { get; set; }
    }
}
