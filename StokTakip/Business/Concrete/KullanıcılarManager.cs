using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KullanıcılarManager : IKullanıcıService
    {
        IKullanıcıDal _kullanıcıDal;

        public KullanıcılarManager(IKullanıcıDal kullanıcıDal)
        {
            _kullanıcıDal = kullanıcıDal;
        }

        public IResult Add(Kullanıcı kullanıcı)
        {
            _kullanıcıDal.Add(kullanıcı);
            return new Result(true, Messages.KullanıcıAdded);
        }

        public IResult Delete(Kullanıcı kullanıcı)
        {
            _kullanıcıDal.Delete(kullanıcı);
            return new Result(true, Messages.KullanıcıDeleted);
        }

        public IDataResult<List<Kullanıcı>> GetAll()
        {
            return new SuccesDataResult<List<Kullanıcı>>(_kullanıcıDal.GetAll());
        }

        public IResult Update(Kullanıcı kullanıcı)
        {
            _kullanıcıDal.Update(kullanıcı);
            return new SuccesResutl(Messages.KullanıcıUpdated);
        }

        public IResult UserAutenticacion(Kullanıcı kullanıcı)
        {
           var result = _kullanıcıDal.Get(p => p.KullanıcıAdı == kullanıcı.KullanıcıAdı
            && p.Sifre == kullanıcı.Sifre);
            if (result == null)
            {
              return  new ErrorResult(Messages.KullanıcıIsNotExist);
            }
            return new SuccesResutl(Messages.KullanıcıAutenticacionIsTrue);
        }
    }
}
