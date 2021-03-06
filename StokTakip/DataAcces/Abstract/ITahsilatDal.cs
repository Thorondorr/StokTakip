using Core.DataAcces;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entity.DTOs;

namespace DataAcces.Abstract
{
    public interface ITahsilatDal : IEntityRepository<Tahsilat>
    {
        List<TahsilatDetailsDto> GetTahsilatDetails();
    }
}
