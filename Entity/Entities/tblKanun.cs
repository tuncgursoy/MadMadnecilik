using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public partial class tblKanun : IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Url { get; set; }
    }
}
