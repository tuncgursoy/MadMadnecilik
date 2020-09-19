using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Business.Dto.Model;
using Entity.Entities;

namespace Web.Models
{
    public class ModelDuyurular
    {
        public List<DuyurularDto> listDuyuru { get; set; }
    }
}
