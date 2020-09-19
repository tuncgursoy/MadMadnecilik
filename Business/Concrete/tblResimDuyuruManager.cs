using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblResimDuyuruManager : ItblResimDuyuruService
  {
      ItblResimDuyuruDal _tblResimDuyuruDal;
      public tblResimDuyuruManager(ItblResimDuyuruDal tblResimDuyuruService)
      {
          _tblResimDuyuruDal = tblResimDuyuruService;
      }
      public void Add(tblResimDuyuru entity)
      {
           _tblResimDuyuruDal.Insert(entity);
      }
       public void Delete(tblResimDuyuru entity)
      {
           _tblResimDuyuruDal.Delete(entity);
      }
      public List<tblResimDuyuru> GetAll()
      {
          return _tblResimDuyuruDal.GetList();
      }
      public tblResimDuyuru GetById(int id)
      {
          return _tblResimDuyuruDal.Get(x => x.DuyuruId == id);
      }
      public void Update(tblResimDuyuru entity)
      {
          _tblResimDuyuruDal.Update(entity);
      }
  }
}
