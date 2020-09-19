using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
namespace Business.IOC
{
  public class AutofacBusinessModule: Module
  {
      protected override void Load(ContainerBuilder builder)
      {
           builder.RegisterType<tblBilgilerManager>().As<ItblBilgilerService>();
           builder.RegisterType<EftblBilgilerDal>().As<ItblBilgilerDal>();
           builder.RegisterType<TblDuyuruManager>().As<ITblDuyuruService>();
           builder.RegisterType<EfTblDuyuruDal>().As<ITblDuyuruDal>();
           builder.RegisterType<tblKanunManager>().As<ItblKanunService>();
           builder.RegisterType<EftblKanunDal>().As<ItblKanunDal>();
           builder.RegisterType<tblKullanicilarManager>().As<ItblKullanicilarService>();
           builder.RegisterType<EftblKullanicilarDal>().As<ItblKullanicilarDal>();
           builder.RegisterType<tblPdfManager>().As<ItblPdfService>();
           builder.RegisterType<EftblPdfDal>().As<ItblPdfDal>();
           builder.RegisterType<tblPdfDuyuruManager>().As<ItblPdfDuyuruService>();
           builder.RegisterType<EftblPdfDuyuruDal>().As<ItblPdfDuyuruDal>();
           builder.RegisterType<tblPdfProjeManager>().As<ItblPdfProjeService>();
           builder.RegisterType<EftblPdfProjeDal>().As<ItblPdfProjeDal>();
           builder.RegisterType<tblProjelerManager>().As<ItblProjelerService>();
           builder.RegisterType<EftblProjelerDal>().As<ItblProjelerDal>();
           builder.RegisterType<tblResimManager>().As<ItblResimService>();
           builder.RegisterType<EftblResimDal>().As<ItblResimDal>();
           builder.RegisterType<tblResimDuyuruManager>().As<ItblResimDuyuruService>();
           builder.RegisterType<EftblResimDuyuruDal>().As<ItblResimDuyuruDal>();
           builder.RegisterType<tblResimProjeManager>().As<ItblResimProjeService>();
           builder.RegisterType<EftblResimProjeDal>().As<ItblResimProjeDal>();
           builder.RegisterType<tblYonetmenlikManager>().As<ItblYonetmenlikService>();
           builder.RegisterType<EftblyonetmenlikDal>().As<ItblyonetmenlikDal>();
      }
  }
}
