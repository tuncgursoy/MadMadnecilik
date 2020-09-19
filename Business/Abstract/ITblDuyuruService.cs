using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ITblDuyuruService
  {
      List<TblDuyuru> GetAll();
      TblDuyuru GetById(int id);
      void Add(TblDuyuru entity);
      void Update(TblDuyuru entity);
      void Delete(TblDuyuru entity);
  }
}
