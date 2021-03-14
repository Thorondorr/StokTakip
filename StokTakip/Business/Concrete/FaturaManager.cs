using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Business.Concrete
{
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaDal;
        ITahsilatService _tahsilatService;
        ICariHareketService _cariHareketService;
        public FaturaManager(IFaturaDal faturaDal,ICariHareketService cariHareketService)
        {          
            _faturaDal = faturaDal;            
            _cariHareketService = cariHareketService;
        }
          
        public IResult Add(Fatura fatura)
        {
            _faturaDal.Add(fatura);
            return new SuccesResutl();
        }

        public DataResult<Fatura> CreateSatısFatura(Sepet sepet,string faturaNo)
        {
            Fatura fatura = new Fatura
            {
                BürütTutar = sepet.BürütTutar,
                CariNo = sepet.CariNo,
                FaturaNo =faturaNo,
                GenelToplam = sepet.Fiyat,
                KDV = sepet.KDV,
                Tarih = DateTime.Now,
                Tip = "Satış",
                UrunAdı = sepet.UrunAdı,
                UrunKodu = sepet.UrunKodu,
                Miktar=sepet.Miktar,
              
            };

            _faturaDal.Add(fatura);
            //_cariHareketService.BorcCreateCariHareket(fatura.FaturaNo, sepet);
            

            return new SuccesDataResult<Fatura>(fatura);
        }

        public DataResult<Fatura> CreateAlisFatura(Sepet sepet, string faturaNo)
        {
            Fatura fatura = new Fatura
            {
                BürütTutar = sepet.BürütTutar,
                CariNo = sepet.CariNo,
                FaturaNo = faturaNo,
                GenelToplam = sepet.Fiyat,
                KDV = sepet.KDV,
                Tarih = DateTime.Now,
                Tip = "Alış",
                UrunAdı = sepet.UrunAdı,
                UrunKodu = sepet.UrunKodu,
                Miktar = sepet.Miktar,

            };

            _faturaDal.Add(fatura);
            //_cariHareketService.BorcCreateCariHareket(fatura.FaturaNo, sepet);


            return new SuccesDataResult<Fatura>(fatura);
        }



        public IResult Delete(Fatura fatura)
        {
            fatura.FaturaNo = CreateFaturaNoWithGUID().Message;
            _faturaDal.Add(fatura);
            return new SuccesResutl();
        }
     
        public IDataResult<List<Fatura>> GetAll()
        {
            return new SuccesDataResult<List<Fatura>>(_faturaDal.GetAll());
        }

        public IDataResult<Fatura> getbyCariNo(string cariNo)
        {
            return new SuccesDataResult<Fatura>(_faturaDal.Get(c=>c.CariNo == cariNo));
        }

        public IDataResult<Fatura> getByFaturaNo(string FaturaNo)
        {
            return new SuccesDataResult<Fatura>(_faturaDal.Get(f => f.FaturaNo == FaturaNo));
        }

        public IResult Update(Fatura fatura)
        {
            _faturaDal.Update(fatura);          
            return new SuccesResutl();
        }

        public IDataResult<string> CreateFaturaNoWithGUID()
        {
            
            
                string NewGUID = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
                return new SuccesDataResult<string>(NewGUID);
            
        }

        public IDataResult<decimal> getFaturaGenelToplam()
        {
            var result = _faturaDal.GetAll();
            decimal genelToplam = (from x in result where x.Tip=="Satış" select x.GenelToplam ).Sum();

            return new SuccesDataResult<decimal>(genelToplam);
            
        }

       public IDataResult<int> getTotalSellCount()
        {

            var result = _faturaDal.GetAll();
            int totalSellCount = (from x in result where x.Tip == "Satış" select x.Miktar).Sum();

            return new SuccesDataResult<int>(totalSellCount);
        }


        public IDataResult<decimal> getFaturaAlışGenelToplam()
        {
            var result = _faturaDal.GetAll();
            decimal genelToplam = (from x in result where x.Tip == "Alış" select x.GenelToplam).Sum();

            return new SuccesDataResult<decimal>(genelToplam);

        }

        public IDataResult<int> getTotalBuyCount()
        {

            var result = _faturaDal.GetAll();
            int totalSellCount = (from x in result where x.Tip == "Alış" select x.Miktar).Sum();

            return new SuccesDataResult<int>(totalSellCount);
        }

        public IDataResult<List<Fatura>> SearchGetByStokAd(string stokAdı)
        {
            return new SuccesDataResult<List<Fatura>>(_faturaDal.GetAll(f => f.UrunAdı.Contains(stokAdı)));
        }
        public IDataResult<List<Fatura>> SearchGetByCariNo(string cariNo)
        {
            return new SuccesDataResult<List<Fatura>>(_faturaDal.GetAll(f => f.CariNo.Contains(cariNo)));
        }
        public IDataResult<List<Fatura>> SearchGetByFaturaTipi(string faturaTipi)
        {
            return new SuccesDataResult<List<Fatura>>(_faturaDal.GetAll(f => f.Tip.Contains(faturaTipi)));
        }

        public IDataResult<List<Fatura>> SearchByTarih(DateTime date)
        {
            var result = _faturaDal.GetAll();

            List<Fatura> list2 = new List<Fatura>();

            foreach (var fatura in result)
            {
                if (fatura.Tarih == date)
                {
                    list2.Add(fatura);
                }
            }

            return new SuccesDataResult<List<Fatura>>(list2);
        }

    }
}
