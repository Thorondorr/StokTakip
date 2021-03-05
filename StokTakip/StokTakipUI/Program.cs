using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete;
using DataAcces.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUI
{
    static class Program
    {
        public static IContainer Container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container = Configure();
            Application.Run(new Form1());
        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TahsilatManager>().As<ITahsilatService>();
            builder.RegisterType<EfTahsilatDal>().As<ITahsilatDal>().SingleInstance();

            builder.RegisterType<CariHareketlerManager>().As<ICariHareketService>();
            builder.RegisterType<EfCariHareketDal>().As<ICariHareketDal>().SingleInstance();

            builder.RegisterType<CariManager>().As<ICariService>();
            builder.RegisterType<EfCariDal>().As<ICariDal>().SingleInstance();

            builder.RegisterType<FaturaManager>().As<IFaturaService>();
            builder.RegisterType<EfFaturaDal>().As<IFaturaDal>().SingleInstance();

            builder.RegisterType<KullanıcılarManager>().As<IKullanıcıService>();
            builder.RegisterType<EfKullanıcıDal>().As<IKullanıcıDal>().SingleInstance();

            builder.RegisterType<StokManager>().As<IStokService>();
            builder.RegisterType<EfStokDal>().As<IStokDal>().SingleInstance();

            builder.RegisterType<UrunManager>().As<IUrunService>();
            builder.RegisterType<EfUrunDal>().As<IUrunDal>().SingleInstance();

            builder.RegisterType<Form1>();

            return builder.Build();
        }
    }
}
