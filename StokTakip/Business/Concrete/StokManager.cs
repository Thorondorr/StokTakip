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

        public IResult Update(Stok stok)
        {
            _stokDal.Update(stok);
            return new SuccesResutl();
        }


    }
}
