using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblPdfManager : ItblPdfService
  {
      ItblPdfDal _tblPdfDal;
      public tblPdfManager(ItblPdfDal tblPdfService)
      {
          _tblPdfDal = tblPdfService;
      }
      public void Add(tblPdf entity)
      {
           _tblPdfDal.Insert(entity);
      }
       public void Delete(tblPdf entity)
      {
           _tblPdfDal.Delete(entity);
      }
      public List<tblPdf> GetAll()
      {
          return _tblPdfDal.GetList();
      }
      public tblPdf GetById(int id)
      {
          return _tblPdfDal.Get(x => x.Id == id);
      }
      public void Update(tblPdf entity)
      {
          _tblPdfDal.Update(entity);
      }
  }
}
