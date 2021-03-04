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
                if (urun.UrunKodu == urun.UrunKodu) 
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
