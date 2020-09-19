using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using DataAccess.Abstract;
using Entity;
using Entity.Entities;

namespace DataAccess.Concrete
{
   public class EftblyonetmenlikDal : EfEntityRepositoryBase<tblyonetmenlik, DbmadmadencilikContext>, ItblyonetmenlikDal
    {
    }
}
