using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblKullanicilarDal : EfEntityRepositoryBase<tblKullanicilar, DbmadmadencilikContext>, ItblKullanicilarDal
  {
  }
}
