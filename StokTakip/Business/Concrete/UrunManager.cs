using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }
        public IResult Add(Urun urun)
        {
            _urunDal.Add(urun);
            return new SuccesResutl();
        }
        public IResult AddUrunFromSepet(Sepet sepet)
        {
            _urunDal.Add(new Urun
            {
                Barkot = sepet.Barkot,
                Fiyat = sepet.Fiyat,
                KDV = sepet.KDV,
                Miktar = sepet.Miktar,
                UrunKodu = sepet.UrunKodu,
                UrunAdı = sepet.UrunAdı,
                UrunTipi = sepet.UrunTipi
            });

            return new SuccesResutl();
        }

        public IDataResult<string> CreateBarkot()
        {
            Random random = new Random();

            return new SuccesDataResult<string>(random.Next(1, 10000).ToString());
        }

        public IResult Delete(Urun urun)
        {
            _urunDal.Delete(urun);
            return new SuccesResutl();
        }

        public IDataResult<List<Urun>> GetAll()
        {
            return new SuccesDataResult<List<Urun>>(_urunDal.GetAll());
        }

        public IDataResult<UrunDetailsDto> GetUrunDetails(string urunKodu)
        {

            foreach (var urun in _urunDal.GetUrunDetails())
            {
                if (urun.UrunKodu == urunKodu) 
                {
                    return new SuccesDataResult<UrunDetailsDto>(urun);
                }
            }
            return new ErrorDataResult<UrunDetailsDto>("Urun bulunamadı.");
           
        }

        
        public IResult Update(Urun urun)
        {
            _urunDal.Update(urun);
            return new SuccesResutl();
        }
    }
}
