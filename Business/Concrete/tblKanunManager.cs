using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblKanunManager : ItblKanunService
  {
      ItblKanunDal _tblKanunDal;
      public tblKanunManager(ItblKanunDal tblKanunService)
      {
          _tblKanunDal = tblKanunService;
      }
      public void Add(tblKanun entity)
      {
           _tblKanunDal.Insert(entity);
      }
       public void Delete(tblKanun entity)
      {
           _tblKanunDal.Delete(entity);
      }
      public List<tblKanun> GetAll()
      {
          return _tblKanunDal.GetList();
      }
      public tblKanun GetById(int id)
      {
          return _tblKanunDal.Get(x => x.Id == id);
      }
      public void Update(tblKanun entity)
      {
          _tblKanunDal.Update(entity);
      }
  }
}
