using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBussinesModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TahsilatManager>().As<ITahsilatService>();
            builder.RegisterType<EfTahsilatDal>().As<ITahsilatDal>().SingleInstance();


            //builder.RegisterType<TahsilatManager>().As<ITahsilatService>();
            //builder.RegisterType<EfTahsilatDal>().As<ITahsilatDal>().SingleInstance();
        }
    }
}
