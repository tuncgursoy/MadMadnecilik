using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblResimProjeManager : ItblResimProjeService
  {
      ItblResimProjeDal _tblResimProjeDal;
      public tblResimProjeManager(ItblResimProjeDal tblResimProjeService)
      {
          _tblResimProjeDal = tblResimProjeService;
      }
      public void Add(tblResimProje entity)
      {
           _tblResimProjeDal.Insert(entity);
      }
       public void Delete(tblResimProje entity)
      {
           _tblResimProjeDal.Delete(entity);
      }
      public List<tblResimProje> GetAll()
      {
          return _tblResimProjeDal.GetList();
      }
      public tblResimProje GetById(int id)
      {
          return _tblResimProjeDal.Get(x => x.ProjeId == id);
      }
      public void Update(tblResimProje entity)
      {
          _tblResimProjeDal.Update(entity);
      }
  }
}
