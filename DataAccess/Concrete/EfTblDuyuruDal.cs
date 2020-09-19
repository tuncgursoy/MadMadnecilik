using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EfTblDuyuruDal : EfEntityRepositoryBase<TblDuyuru, DbmadmadencilikContext>, ITblDuyuruDal
  {
  }
}
