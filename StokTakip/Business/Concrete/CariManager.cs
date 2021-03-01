using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using System.Linq;

namespace Business.Concrete
{
    public class CariManager : ICariService
    {
        ICariDal _cariDal;

        public CariManager(ICariDal cariDal)
        {
            _cariDal = cariDal;
        }
        public IResult Add(Cari cari)
        {
            _cariDal.Add(cari);            
            return new Result(true, Messages.CariAdded);
        }

        public IResult Delete(Cari cari)
        {
            _cariDal.Delete(cari);
            return new Result(true, Messages.CariDeleted);
        }

        public IResult Get(Cari cari)
        {
            return new SuccesDataResult<Cari>(_cariDal.Get(c => c.CariNo == cari.CariNo));
        }

        public IDataResult<List<Cari>> GetAll()
        {
            return new SuccesDataResult<List<Cari>>(_cariDal.GetAll());
        }

        public IDataResult<List<Cari>> Search(Cari cari)
        {
            return new SuccesDataResult<List<Cari>>(_cariDal.GetAll(c=>c.CariAdı.Contains(cari.CariAdı)));
          
        }

        public IResult Update(Cari cari)
        {
            _cariDal.Update(cari);
            return new Result(true, Messages.CariUpdated);

           
        }
    }
}
