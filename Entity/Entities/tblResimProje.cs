﻿using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblResimProje : IEntity
    {
        public int ResimId { get; set; }
        public int ProjeId { get; set; }

        public virtual tblProjeler Proje { get; set; }
        public virtual tblResim Resim { get; set; }
    }
}
