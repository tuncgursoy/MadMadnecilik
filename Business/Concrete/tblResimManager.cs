using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblResimManager : ItblResimService
  {
      ItblResimDal _tblResimDal;
      public tblResimManager(ItblResimDal tblResimService)
      {
          _tblResimDal = tblResimService;
      }
      public void Add(tblResim entity)
      {
           _tblResimDal.Insert(entity);
      }
       public void Delete(tblResim entity)
      {
           _tblResimDal.Delete(entity);
      }
      public List<tblResim> GetAll()
      {
          return _tblResimDal.GetList();
      }
      public tblResim GetById(int id)
      {
          return _tblResimDal.Get(x => x.Id == id);
      }
      public void Update(tblResim entity)
      {
          _tblResimDal.Update(entity);
      }
  }
}
