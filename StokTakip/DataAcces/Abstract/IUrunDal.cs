using Core.DataAcces;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entity.DTOs;
using System.Linq.Expressions;
using Core.Entity;

namespace DataAcces.Abstract
{
    public interface IUrunDal : IEntityRepository<Urun>
    {
         List<UrunDetailsDto> GetUrunDetails();
    }
}
