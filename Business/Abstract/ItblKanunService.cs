using System.Collections.Generic;
using Entity.Entities;
namespace Business.Abstract
{
  public interface ItblKanunService
  {
      List<tblKanun> GetAll();
      tblKanun GetById(int id);
      void Add(tblKanun entity);
      void Update(tblKanun entity);
      void Delete(tblKanun entity);
  }
}
