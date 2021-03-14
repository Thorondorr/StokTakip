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
    public class TahsilatManager : ITahsilatService
    {
        ITahsilatDal _tahsilatDal;
        public TahsilatManager(ITahsilatDal tahsilatDal)
        {
            _tahsilatDal = tahsilatDal;
        }
        public IResult Add(Tahsilat tahsilat)
        {
            if(tahsilat != null)
            {
                _tahsilatDal.Add(tahsilat);
                return new SuccesResutl("Başarı ile eklendi.");
            }
            else
            {
                return new ErrorResult("Boş alanları doldurun");
            }          
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
            return new SuccesResutl("Başarı ile eklendi.");
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

        public DataResult<List<Tahsilat>> GetByCariNo(string cariNo)
        {
            return new SuccesDataResult<List<Tahsilat>>(_tahsilatDal.GetAll(t => t.CariNo.Contains(cariNo)));
        }
        public DataResult<List<TahsilatDetailsDto>> GetTahsilatDetails()
        {
            return new SuccesDataResult<List<TahsilatDetailsDto>>((List<TahsilatDetailsDto>)_tahsilatDal.GetTahsilatDetails());
        }
        public DataResult<List<TahsilatDetailsDto>> GetTahsilatDetailsByCariNo(string cariNo)
        {
            return new SuccesDataResult<List<TahsilatDetailsDto>>((List<TahsilatDetailsDto>)_tahsilatDal.GetTahsilatDetails().Where(n => n.CariNumarası == cariNo));
        }
        public DataResult<List<TahsilatDetailsDto>> GetTahsilatDetailsByCariAd(string cariAdı)
        {
            //bozuk
            return new SuccesDataResult<List<TahsilatDetailsDto>>((List<TahsilatDetailsDto>)_tahsilatDal.GetTahsilatDetails().Where(n => n.CariAdı.Contains(cariAdı)));
        }
    }
}
