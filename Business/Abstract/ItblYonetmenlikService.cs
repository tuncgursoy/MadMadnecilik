using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business.Abstract
{
    public interface ItblYonetmenlikService
    {
        List<tblyonetmenlik> GetAll();
        tblyonetmenlik GetById(int id);
        void Add(tblyonetmenlik entity);
        void Update(tblyonetmenlik entity);
        void Delete(tblyonetmenlik entity);
    }
}
