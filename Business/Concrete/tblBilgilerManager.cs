using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblBilgilerManager : ItblBilgilerService
  {
      ItblBilgilerDal _tblBilgilerDal;
      public tblBilgilerManager(ItblBilgilerDal tblBilgilerService)
      {
          _tblBilgilerDal = tblBilgilerService;
      }
      public void Add(tblBilgiler entity)
      {
           _tblBilgilerDal.Insert(entity);
      }
       public void Delete(tblBilgiler entity)
      {
           _tblBilgilerDal.Delete(entity);
      }
      public List<tblBilgiler> GetAll()
      {
          return _tblBilgilerDal.GetList();
      }
      public tblBilgiler GetById(int id)
      {
          return _tblBilgilerDal.Get(x => x.Id == id);
      }
      public void Update(tblBilgiler entity)
      {
          _tblBilgilerDal.Update(entity);
      }
  }
}
