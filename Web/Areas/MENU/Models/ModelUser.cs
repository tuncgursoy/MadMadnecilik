using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dto.Model;
using Entity;
using Entity.Entities;
using Microsoft.AspNetCore.Http;

namespace Web.Areas.MENU.Models
{
    public class ModelUser
    {
        public  string name { get; set; }
        public string surname { get; set; }
        public string password1 { get; set; }
        public string password2 { get; set; }
        public bool? isSuccessfull { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string url { get; set; }
        public int cat { get; set; }
        public IFormFile dosyaUrl { get; set; }
        public IFormFile resimUrl { get; set; }
        public List<TblDuyuru> listDuyuru { get; set; }
        public List<TblDuyuru> newList { get; set; }
        public DuyurularDto duyuru { get; set; }
        public string id { get; set; }
        public bool aktif { get; set; }
        public tblKanun kanun { get; set; }
        public tblyonetmenlik yonetmenlik { get; set; }
        public List<tblKanun> kanunlist { get; set; }
        public List<tblyonetmenlik> yonetmenliklist { get; set; }
        public int Value { get; set; }
        public ModelKullanici kull { get; set; }
    }
}
