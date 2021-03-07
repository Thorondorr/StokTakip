using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStokHareketService
    {
        IResult Add(StokHareket stokHareket);
        IResult Update(StokHareket stokHareket);
        IResult Delete(StokHareket stokHareket);
        IDataResult<List<StokHareket>> GetAll();
        IResult Cikis(Sepet sepet);
        IResult Giris(Sepet sepet);





    }
}
