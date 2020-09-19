using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblProjelerDal : EfEntityRepositoryBase<tblProjeler, DbmadmadencilikContext>, ItblProjelerDal
  {
  }
}
