using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ModelLogin
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool iserror { get; set; }
    }
}
