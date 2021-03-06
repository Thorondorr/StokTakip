using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFaturaService
    {
        IResult Add(Fatura fatura);
        IResult Update(Fatura fatura);
        IResult Delete(Fatura fatura);
        IResult CreateFatura(Sepet sepet);
        IDataResult<List<Fatura>> GetAll();
        IDataResult<Fatura> getByFaturaNo(string FaturaNo);
         IDataResult<Fatura> getbyCariNo(string cariNo);
        IDataResult<decimal> getFaturaGenelToplam();
        IDataResult<int> getTotalSellCount();

    }
}
