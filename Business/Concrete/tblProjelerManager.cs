using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblProjelerManager : ItblProjelerService
  {
      ItblProjelerDal _tblProjelerDal;
      public tblProjelerManager(ItblProjelerDal tblProjelerService)
      {
          _tblProjelerDal = tblProjelerService;
      }
      public void Add(tblProjeler entity)
      {
           _tblProjelerDal.Insert(entity);
      }
       public void Delete(tblProjeler entity)
      {
           _tblProjelerDal.Delete(entity);
      }
      public List<tblProjeler> GetAll()
      {
          return _tblProjelerDal.GetList();
      }
      public tblProjeler GetById(int id)
      {
          return _tblProjelerDal.Get(x => x.Id == id);
      }
      public void Update(tblProjeler entity)
      {
          _tblProjelerDal.Update(entity);
      }
  }
}
