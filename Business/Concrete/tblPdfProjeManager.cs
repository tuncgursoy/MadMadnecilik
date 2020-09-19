using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblPdfProjeManager : ItblPdfProjeService
  {
      ItblPdfProjeDal _tblPdfProjeDal;
      public tblPdfProjeManager(ItblPdfProjeDal tblPdfProjeService)
      {
          _tblPdfProjeDal = tblPdfProjeService;
      }
      public void Add(tblPdfProje entity)
      {
           _tblPdfProjeDal.Insert(entity);
      }
       public void Delete(tblPdfProje entity)
      {
           _tblPdfProjeDal.Delete(entity);
      }
      public List<tblPdfProje> GetAll()
      {
          return _tblPdfProjeDal.GetList();
      }
      public tblPdfProje GetById(int id)
      {
          return _tblPdfProjeDal.Get(x => x.ProjeId == id);
      }
      public void Update(tblPdfProje entity)
      {
          _tblPdfProjeDal.Update(entity);
      }
  }
}
