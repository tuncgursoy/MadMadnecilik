using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class TblDuyuruManager : ITblDuyuruService
  {
      ITblDuyuruDal _TblDuyuruDal;
      public TblDuyuruManager(ITblDuyuruDal TblDuyuruService)
      {
          _TblDuyuruDal = TblDuyuruService;
      }
      public void Add(TblDuyuru entity)
      {
           _TblDuyuruDal.Insert(entity);
      }
       public void Delete(TblDuyuru entity)
      {
           _TblDuyuruDal.Delete(entity);
      }
      public List<TblDuyuru> GetAll()
      {
          return _TblDuyuruDal.GetList();
      }
      public TblDuyuru GetById(int id)
      {
          return _TblDuyuruDal.Get(x => x.Id == id);
      }
      public void Update(TblDuyuru entity)
      {
          _TblDuyuruDal.Update(entity);
      }
  }
}
