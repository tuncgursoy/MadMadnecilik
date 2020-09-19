using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblBilgilerService
  {
      List<tblBilgiler> GetAll();
      tblBilgiler GetById(int id);
      void Add(tblBilgiler entity);
      void Update(tblBilgiler entity);
      void Delete(tblBilgiler entity);
  }
}
