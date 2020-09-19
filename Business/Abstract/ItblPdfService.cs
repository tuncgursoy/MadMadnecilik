using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblPdfService
  {
      List<tblPdf> GetAll();
      tblPdf GetById(int id);
      void Add(tblPdf entity);
      void Update(tblPdf entity);
      void Delete(tblPdf entity);
  }
}
