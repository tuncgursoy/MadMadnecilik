using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblBilgilerDal : EfEntityRepositoryBase<tblBilgiler, DbmadmadencilikContext>, ItblBilgilerDal
  {
  }
}
