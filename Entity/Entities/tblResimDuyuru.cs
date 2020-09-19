using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblResimDuyuru : IEntity
    {
        public int ResimId { get; set; }
        public int DuyuruId { get; set; }

        public virtual TblDuyuru Duyuru { get; set; }
        public virtual tblResim Resim { get; set; }
    }
}
