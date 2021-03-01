using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CariHareketlerManager : ICariHareketService
    {
        ICariHareketDal _cariHareketDal;

        public CariHareketlerManager(ICariHareketDal cariHareketDal)
        {
            _cariHareketDal = cariHareketDal;
        }
        public IResult Add(CariHareket cariHareket)
        {
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
    }
}
