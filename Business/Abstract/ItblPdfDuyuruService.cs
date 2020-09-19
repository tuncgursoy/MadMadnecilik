using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblPdfDuyuruService
  {
      List<tblPdfDuyuru> GetAll();
      tblPdfDuyuru GetById(int id);
      void Add(tblPdfDuyuru entity);
      void Update(tblPdfDuyuru entity);
      void Delete(tblPdfDuyuru entity);
  }
}
