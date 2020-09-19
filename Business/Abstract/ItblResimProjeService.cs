using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblResimProjeService
  {
      List<tblResimProje> GetAll();
      tblResimProje GetById(int id);
      void Add(tblResimProje entity);
      void Update(tblResimProje entity);
      void Delete(tblResimProje entity);
  }
}
