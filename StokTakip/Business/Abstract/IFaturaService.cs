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
        DataResult<Fatura> CreateSatısFatura(Sepet sepet, string faturaNo);
        DataResult<Fatura> CreateAlisFatura(Sepet sepet, string faturaNo);
        IDataResult<string> CreateFaturaNoWithGUID();
        IDataResult<List<Fatura>> GetAll();
        IDataResult<Fatura> getByFaturaNo(string FaturaNo);
         IDataResult<Fatura> getbyCariNo(string cariNo);
        IDataResult<decimal> getFaturaGenelToplam();
        IDataResult<int> getTotalSellCount();

    }
}
