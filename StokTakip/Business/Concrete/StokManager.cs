using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StokManager : IStokService
    {
        IStokDal _stokDal;
        
        public StokManager(IStokDal stokDal)
        {
            _stokDal = stokDal;
            
        }

        public IResult Add(Stok stok)
        {

          //  stok.UrunKodu = GenerateGUID().Message;
            _stokDal.Add(stok);
            
            return new SuccesResutl();
        }

        public IResult Delete(Stok stok)
        {
            _stokDal.Delete(stok);
            return new SuccesResutl();
        }

        public IDataResult<List<Stok>> GetAll()
        {
            return new DataResult<List<Stok>>(_stokDal.GetAll(), true);
        }

        public IDataResult<Stok> GetByUrunAdı(string ürünAdı)
        {
            return new SuccesDataResult<Stok>(_stokDal.Get(s => s.UrunAdı == ürünAdı));
        }

        public IResult Update(Stok stok)
        {
            _stokDal.Update(stok);
            return new SuccesResutl();
        }

        private IDataResult<string> GenerateGUID()
        {
            string NewGUID = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();

            return new SuccesDataResult<string>(NewGUID);
        }

        public IDataResult<Stok> UrunGetByUrunKodu(string urunKodu)
        {                    
            return new SuccesDataResult<Stok>(_stokDal.Get(u => u.UrunKodu == urunKodu));   
        }

        public IDataResult<List<Stok>> GetByStokName(string stokAdı)
        {
            return new SuccesDataResult<List<Stok>>(_stokDal.GetAll(s => s.UrunAdı.Contains(stokAdı)));
        }

        public IResult UpdateStokQuantity(Sepet sepet,int eksilenStok)
        {
           var result= UrunGetByUrunKodu(sepet.UrunKodu);

          var checkResult = CheckIsStokEmty(sepet.UrunKodu, eksilenStok);
            if (checkResult.Succes)
            {
                _stokDal.Update(new Stok
                {
                    UrunAdı = result.Data.UrunAdı,
                    CariNo = result.Data.CariNo,
                    UrunKodu = result.Data.UrunKodu,
                    // GirisCikis = result.Data.GirisCikis,
                    KDV = result.Data.KDV,
                    Miktar = result.Data.Miktar - eksilenStok,
                    StokId = result.Data.StokId,
                    StokNetFiyatı = result.Data.StokNetFiyatı,
                    Tarih = result.Data.Tarih
                });

                return new SuccesResutl();
            }
            else
            {
                return new ErrorResult(checkResult.Message);
            }

           
        }

        public IResult AddPurchasedNewStok(Sepet sepet)
        {
            _stokDal.Add(new Stok
            {
                CariNo = sepet.CariNo,
                KDV = sepet.KDV,
                Miktar = sepet.Miktar,
                StokNetFiyatı = sepet.Fiyat,
                Tarih = DateTime.Now,
                UrunAdı = sepet.UrunAdı,
                UrunKodu = sepet.UrunKodu
            });
            return new SuccesResutl();
        }
        //iş kodu
        private IDataResult<int> CheckIsStokEmty(string urunKodu,int eksilenStok)
        {
            var result = UrunGetByUrunKodu(urunKodu);
            if (result.Data.Miktar < eksilenStok)
            {
                return new ErrorDataResult<int>(result.Data.Miktar, "Yeteri kadar stok yok.");
            }
            return new SuccesDataResult<int>();
        }

        public IResult CheckHaveStock(string urunKodu, int eksilenStok)
        {
            var result = UrunGetByUrunKodu(urunKodu);
            if (result.Data.Miktar < eksilenStok)
            {
                return new ErrorDataResult<int>(result.Data.Miktar, "Yeteri kadar stok yok.");
            }
            return new SuccesDataResult<int>();
        }
    }
}
