using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICariHareketService
    {
        IResult Add(CariHareket cariHareket);
        IResult Update(CariHareket cariHareket);
        IResult Delete(CariHareket cariHareket);
        IResult BorcCreateCariHareket(string faturaNo, Sepet sepet);
        IDataResult<decimal> GetAllBorcWithCariNo(string cariNo);
        IDataResult<decimal> GetAllOdenenBorcWithCariNo(string cariNo);
        IDataResult<decimal> GetAllKalanBorcWithCariNo(string cariNo);
        IDataResult<List<CariHareket>> GetAll();
    }
}
