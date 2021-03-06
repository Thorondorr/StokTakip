using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITahsilatService
    {
        IResult Add(Tahsilat tahsilat);
        IResult Update(Tahsilat tahsilat);
        IResult Delete(Tahsilat tahsilat);
        IResult CreateTahsilat(Fatura fatura);
        IDataResult<List<Tahsilat>> GetAll();
        DataResult<List<TahsilatDetailsDto>> GetTahsilatDetailsByCariNo(string cariNo);
        DataResult<List<TahsilatDetailsDto>> GetTahsilatDetailsByCariAd(string cariAdı);
        DataResult<List<TahsilatDetailsDto>> GetTahsilatDetails();
    }
}
