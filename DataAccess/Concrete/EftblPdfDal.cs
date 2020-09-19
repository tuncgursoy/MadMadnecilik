using Core.DataAccess;
using Entity.Entities;
using DataAccess.Abstract;
namespace DataAccess.Concrete
{
  public class EftblPdfDal : EfEntityRepositoryBase<tblPdf, DbmadmadencilikContext>, ItblPdfDal
  {
  }
}
