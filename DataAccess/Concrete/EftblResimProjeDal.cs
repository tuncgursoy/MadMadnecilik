using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblResimProjeDal : EfEntityRepositoryBase<tblResimProje, DbmadmadencilikContext>, ItblResimProjeDal
  {
  }
}
