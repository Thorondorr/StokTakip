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
    public class CariHareketlerManager : ICariHareketService
    {
        ICariHareketDal _cariHareketDal;
        IFaturaService _faturaService;

        public CariHareketlerManager(ICariHareketDal cariHareketDal)
        {
            _cariHareketDal = cariHareketDal;
           // _faturaService = faturaService;
        }
        public IResult Add(CariHareket cariHareket)
        {
            _cariHareketDal.Add(cariHareket);
            return new SuccesResutl();
        }

        public IResult BorcCreateCariHareket(string faturaNo,Sepet sepet)
        {
            
            CariHareket cariHareket = new CariHareket
            {
                FaturaNo = faturaNo,
                CariNo = sepet.CariNo,
                Tarih = DateTime.Now,
                Tutar = sepet.Fiyat,
                Aciklama = sepet.Aciklama,
                BorcAlacak = "B",
            };

            _cariHareketDal.Add(cariHareket);

            return new SuccesResutl();
        }

        public IResult Delete(CariHareket cariHareket)
        {
            _cariHareketDal.Delete(cariHareket);
            return new SuccesResutl();
        }

        public IDataResult<List<CariHareket>> GetAll()
        {
            return new SuccesDataResult<List<CariHareket>>(_cariHareketDal.GetAll());
        }

        public IResult Update(CariHareket cariHareket)
        {
            _cariHareketDal.Update(cariHareket);
            return new SuccesResutl();
        }

        public IDataResult<decimal> GetAllBorcWithCariNo(string cariNo)
        {
            var result = _cariHareketDal.GetAll(ch => ch.CariNo == cariNo).Where(ch=>ch.BorcAlacak=="B");
            var totalBorc = result.Sum(x => x.Tutar);
            
            

            return new SuccesDataResult<decimal>(totalBorc,"Toplam borç hesaplandı.");
        }
        public IDataResult<decimal> GetAllOdenenBorcWithCariNo(string cariNo)
        {
            var result = _cariHareketDal.GetAll(ch => ch.CariNo == cariNo).Where(ch => ch.BorcAlacak == "B");
            var resul2= _cariHareketDal.GetAll(ch => ch.CariNo == cariNo).Where(ch => ch.BorcAlacak == "A");
            var totalBorc =resul2.Sum(x=>x.Tutar);           
            return new SuccesDataResult<decimal>(totalBorc, "Toplam borç hesaplandı.");
        }
        public IDataResult<decimal> GetAllKalanBorcWithCariNo(string cariNo)
        {
            var result = _cariHareketDal.GetAll(ch => ch.CariNo == cariNo).Where(ch => ch.BorcAlacak == "B");
            var resul2 = _cariHareketDal.GetAll(ch => ch.CariNo == cariNo).Where(ch => ch.BorcAlacak == "A");
            var totalBorc = result.Sum(x=>x.Tutar)-resul2.Sum(x => x.Tutar);
            return new SuccesDataResult<decimal>(totalBorc, "Toplam borç hesaplandı.");
        }

        

    }
}
