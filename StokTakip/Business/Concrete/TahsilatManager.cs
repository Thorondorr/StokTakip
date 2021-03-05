using Business.Abstract;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TahsilatManager : ITahsilatService
    {
        ITahsilatDal _tahsilatDal;
        public TahsilatManager(ITahsilatDal tahsilatDal)
        {
            _tahsilatDal = tahsilatDal;
        }
        public IResult Add(Tahsilat tahsilat)
        {
            _tahsilatDal.Add(tahsilat);
            return new SuccesResutl();
        }

        public IResult CreateTahsilat(Fatura fatura)
        {
            _tahsilatDal.Add(new Tahsilat
            {
                BelgeNo = fatura.FaturaNo,
                CariNo = fatura.CariNo,
                Tarih = fatura.Tarih,
                Tip = fatura.Tip,
                Tutar = fatura.GenelToplam
            });
            return new SuccesResutl();
        }

        public IResult Delete(Tahsilat tahsilat)
        {
            _tahsilatDal.Delete(tahsilat);
            return new SuccesResutl();

        }

        public IDataResult<List<Tahsilat>> GetAll()
        {
            return new SuccesDataResult<List<Tahsilat>>(_tahsilatDal.GetAll());

        }

        public IResult Update(Tahsilat tahsilat)
        {
            _tahsilatDal.Update(tahsilat);
            return new SuccesResutl();
        }
    }
}
