using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblProjelerService
  {
      List<tblProjeler> GetAll();
      tblProjeler GetById(int id);
      void Add(tblProjeler entity);
      void Update(tblProjeler entity);
      void Delete(tblProjeler entity);
  }
}
