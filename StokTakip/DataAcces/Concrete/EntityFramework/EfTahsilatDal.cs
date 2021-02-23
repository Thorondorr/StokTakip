using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete
{
    public class EfTahsilatDal : EfEntityRepositoryBase<Tahsilat, CariAlimSatimContext>, ITahsilatDal
    {
    }
}
