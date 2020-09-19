using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblResimDal : EfEntityRepositoryBase<tblResim, DbmadmadencilikContext>, ItblResimDal
  {
  }
}
