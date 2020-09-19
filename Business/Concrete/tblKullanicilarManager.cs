using System.Collections.Generic;
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
      public List<tblKullanicilar> GetAll()
      {
          return _tblKullanicilarDal.GetList();
      }
      public tblKullanicilar GetById(int id)
      {
          return _tblKullanicilarDal.Get(x => x.Id == id);
      }
      public void Update(tblKullanicilar entity)
      {
          _tblKullanicilarDal.Update(entity);
      }
  }
}
