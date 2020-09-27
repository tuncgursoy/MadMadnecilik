using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.MENU.Models
{
    public class ModelUser
    {
        public  string name { get; set; }
        public string surname { get; set; }
        public string password1 { get; set; }
        public string password2 { get; set; }
        public bool? isSuccessfull { get; set; }
    }
}
