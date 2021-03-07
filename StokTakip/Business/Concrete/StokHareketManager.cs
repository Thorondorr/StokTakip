using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StokHareketManager : IStokHareketService
    {
        IStokHareketDal _stokHareketDal;
        public StokHareketManager(IStokHareketDal stokHareketDal)
        {
            _stokHareketDal = stokHareketDal;
        }
        public IResult Add(StokHareket stokHareket)
        {

            _stokHareketDal.Add(stokHareket);
            return new SuccesResutl("Stok hareket eklendi.");
        }
        public IResult Giris(Sepet sepet)
        {
            _stokHareketDal.Add(new StokHareket
            {
                CariNo = sepet.CariNo,
                FaturaNo = sepet.CariNo,
                GirisCikis = "Giris",
                KDV = sepet.KDV,
                Tarih = DateTime.Now,
                Tutar = sepet.Fiyat,


            });

            return new SuccesResutl("Sepet Hareketi eklendi.");
        }

        public IResult Cikis(Sepet sepet)
        {
            _stokHareketDal.Add(new StokHareket
            {
                CariNo = sepet.CariNo,
                FaturaNo = sepet.CariNo,
                GirisCikis = "Cikis",
                KDV = sepet.KDV,
                Tarih = DateTime.Now,
                Tutar = sepet.Fiyat,
            });

            return new SuccesResutl("Sepet Hareketi eklendi.");
        }

        public IResult Delete(StokHareket stokHareket)
        {
            _stokHareketDal.Delete(stokHareket);
            return new SuccesResutl("Stok hareket silindi.");
        }

        public IDataResult<List<StokHareket>> GetAll()
        {
            return new SuccesDataResult<List<StokHareket>>(_stokHareketDal.GetAll(),"Stok hareketler listelendi.");

        }

        public IResult Update(StokHareket stokHareket)
        {
            _stokHareketDal.Update(stokHareket);
            return new SuccesResutl("Stok hareket güncellendi.");
        }
    }
}
