using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblKullanicilar : IEntity
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public string rol { get; set; }
    }
}
