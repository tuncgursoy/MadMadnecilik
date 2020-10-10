using System.Collections.Generic;
using System.Linq;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblKullanicilarManager : ItblKullanicilarService
  {
      ItblKullanicilarDal _tblKullanicilarDal;
      public tblKullanicilarManager(ItblKullanicilarDal tblKullanicilarService)
      {
          _tblKullanicilarDal = tblKullanicilarService;
      }
      public void Add(tblKullanicilar entity)
      {
           _tblKullanicilarDal.Insert(entity);
      }
       public void Delete(tblKullanicilar entity)
      {
           _tblKullanicilarDal.Delete(entity);
      }

       public int? LoginID(string email, string password)
       {
           int? id=null;
           foreach (var VARIABLE in GetAll().ToList())
           {
               if (VARIABLE.Mail==email&&VARIABLE.Sifre==password)
               {
                   id = VARIABLE.Id;
               }
           }

           return id;
       }

       public tblKullanicilar? FindbyMail(string email,string name)
       {
           foreach (var VARIABLE in GetAll().ToList())
           {
               if (VARIABLE.Mail == email && VARIABLE.Isim.ToLower() == name.ToLower())
               {
                   return VARIABLE;
               }
           }

           return null; 
       }

       public List<tblKullanicilar> GetAll()
      {
          return _tblKullanicilarDal.GetList();
      }
      public tblKullanicilar GetById(int? id)
      {
          return _tblKullanicilarDal.Get(x => x.Id == id);
      }
      public void Update(tblKullanicilar entity)
      {
          _tblKullanicilarDal.Update(entity);
      }
  }
}
