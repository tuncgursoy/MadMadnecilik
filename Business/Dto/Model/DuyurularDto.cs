using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto.Model
{
    public class DuyurularDto
    {
        public int id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string resimUrl { get; set; }
        public string PdfUrl { get; set; }
        public DateTime Date { get; set; }
    }
}
