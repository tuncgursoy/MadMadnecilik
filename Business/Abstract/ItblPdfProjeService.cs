using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblPdfProjeService
  {
      List<tblPdfProje> GetAll();
      tblPdfProje GetById(int id);
      void Add(tblPdfProje entity);
      void Update(tblPdfProje entity);
      void Delete(tblPdfProje entity);
  }
}
