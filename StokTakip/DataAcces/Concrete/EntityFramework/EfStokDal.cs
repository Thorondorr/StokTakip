﻿using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfStokDal : EfEntityRepositoryBase<Stok, CariAlimSatimContext>, IStokDal
    {
    }
}
