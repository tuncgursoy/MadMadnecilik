using System.Collections.Generic;
using Entity.Entities;
using Business.Abstract;
using DataAccess.Abstract;
namespace Business.Concrete
{
  public class tblPdfDuyuruManager : ItblPdfDuyuruService
  {
      ItblPdfDuyuruDal _tblPdfDuyuruDal;
      public tblPdfDuyuruManager(ItblPdfDuyuruDal tblPdfDuyuruService)
      {
          _tblPdfDuyuruDal = tblPdfDuyuruService;
      }
      public void Add(tblPdfDuyuru entity)
      {
           _tblPdfDuyuruDal.Insert(entity);
      }
       public void Delete(tblPdfDuyuru entity)
      {
           _tblPdfDuyuruDal.Delete(entity);
      }
      public List<tblPdfDuyuru> GetAll()
      {
          return _tblPdfDuyuruDal.GetList();
      }
      public tblPdfDuyuru GetById(int id)
      {
          return _tblPdfDuyuruDal.Get(x => x.DuyuruId == id);
      }
      public void Update(tblPdfDuyuru entity)
      {
          _tblPdfDuyuruDal.Update(entity);
      }
  }
}
