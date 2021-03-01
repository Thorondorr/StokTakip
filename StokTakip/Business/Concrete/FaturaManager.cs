using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaDal;
        public FaturaManager(IFaturaDal faturaDal)
        {
            _faturaDal = faturaDal;
        }
        public IResult Add(Fatura fatura)
        {
            _faturaDal.Add(fatura);
            return new SuccesResutl();
        }

        public IResult Delete(Fatura fatura)
        {
            _faturaDal.Add(fatura);
            return new SuccesResutl();
        }

        public IDataResult<List<Fatura>> GetAll()
        {
            return new SuccesDataResult<List<Fatura>>(_faturaDal.GetAll());
        }

        public IResult Update(Fatura fatura)
        {
            _faturaDal.Update(fatura);
            return new SuccesResutl();
        }
    }
}
