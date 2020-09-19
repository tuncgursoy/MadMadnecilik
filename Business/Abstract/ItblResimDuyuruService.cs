using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblResimDuyuruService
  {
      List<tblResimDuyuru> GetAll();
      tblResimDuyuru GetById(int id);
      void Add(tblResimDuyuru entity);
      void Update(tblResimDuyuru entity);
      void Delete(tblResimDuyuru entity);
  }
}
