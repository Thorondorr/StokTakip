using Business.Abstract;
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
        public List<Kullanıcı> GetAll()
        {
            return _kullanıcıDal.GetAll();
        }
    }
}
