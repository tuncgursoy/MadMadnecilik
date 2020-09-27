using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblKullanicilarService
  {
      List<tblKullanicilar> GetAll();
      tblKullanicilar GetById(int? id);
      void Add(tblKullanicilar entity);
      void Update(tblKullanicilar entity);
      void Delete(tblKullanicilar entity);

      int? LoginID(string email, string password);
  }
}
