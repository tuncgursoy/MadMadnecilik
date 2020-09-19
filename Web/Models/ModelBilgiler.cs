using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace Web.Models
{
    public class ModelBilgiler
    {
        [Required]
        public string   adres { get; set; }
        [Required]
        public string tel { get; set; }
        [Required]
        public string tel2 { get; set; }
        [Required]
        public string mail { get; set; }
    }
}
