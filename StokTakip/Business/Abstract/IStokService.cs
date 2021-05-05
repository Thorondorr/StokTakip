using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStokService
    {
        IResult Add(Stok stok);
        IResult Update(Stok stok);
        IResult Delete(Stok stok);
        IResult AddPurchasedNewStok(Sepet sepet);
        IResult UpdateStokQuantity(Sepet sepet,int eksilenStok);
        IDataResult<List<Stok>> GetByStokName(string stokAdı);
        IDataResult<List<Stok>> GetAll();
        IDataResult<Stok> UrunGetByUrunKodu(string urunKodu);
        IResult CheckHaveStock(string urunKodu, int eksilenStok);


    }
}
