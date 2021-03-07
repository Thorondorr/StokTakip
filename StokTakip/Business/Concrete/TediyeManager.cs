using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TediyeManager : ITediyeService
    {
        ITediyeDal _tediyeDal;

        public TediyeManager(ITediyeDal tediyeDal)
        {
            _tediyeDal = tediyeDal;
        }
        public IResult Add(Tediye tediye)
        {
            _tediyeDal.Add(tediye);
            return new SuccesResutl();
        }

        public IResult CreateTediye(Fatura fatura)
        {
            _tediyeDal.Add(new Tediye
            {
                BelgeNo = fatura.FaturaNo,
                CariNo = fatura.CariNo,
                Tarih = fatura.Tarih,
                Tip = fatura.Tip,
                Tutar = fatura.GenelToplam
            });
            return new SuccesResutl();
        }

        public IResult Delete(Tediye tediye)
        {
            _tediyeDal.Delete(tediye);
            return new SuccesResutl();
        }

        public IDataResult<List<Tediye>> GetAll()
        {
            return new SuccesDataResult<List<Tediye>>(_tediyeDal.GetAll());
        }

        public IResult Update(Tediye tediye)
        {
            _tediyeDal.Update(tediye);
            return new SuccesResutl();
        }
    }
}
