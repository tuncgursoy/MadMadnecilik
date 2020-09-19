using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblResimService
  {
      List<tblResim> GetAll();
      tblResim GetById(int id);
      void Add(tblResim entity);
      void Update(tblResim entity);
      void Delete(tblResim entity);
  }
}
