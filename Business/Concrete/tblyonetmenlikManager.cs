using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using Entity.Entities;

namespace Business.Concrete
{
    public class tblYonetmenlikManager : ItblYonetmenlikService
    {
        ItblyonetmenlikDal _tblyonetmenlikDal;
        public tblYonetmenlikManager(ItblyonetmenlikDal tblyonetmenlikDal)
        {
            _tblyonetmenlikDal = tblyonetmenlikDal;
        }
        public void Add(tblyonetmenlik entity)
        {
            _tblyonetmenlikDal.Insert(entity);
        }
        public void Delete(tblyonetmenlik entity)
        {
            _tblyonetmenlikDal.Delete(entity);
        }
        public List<tblyonetmenlik> GetAll()
        {
            return _tblyonetmenlikDal.GetList();
        }
        public tblyonetmenlik GetById(int id)
        {
            return _tblyonetmenlikDal.Get(x => x.Id == id);
        }
        public void Update(tblyonetmenlik entity)
        {
            _tblyonetmenlikDal.Update(entity);
        }
    }
}
