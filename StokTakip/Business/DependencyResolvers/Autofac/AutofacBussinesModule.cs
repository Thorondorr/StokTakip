using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete;
using DataAcces.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   
}
//builder.RegisterType<TahsilatManager>().As<ITahsilatService>();
//builder.RegisterType<EfTahsilatDal>().As<ITahsilatDal>().SingleInstance();