﻿using Business.Abstract;
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
        ITahsilatService _tahsilatService;
        ICariHareketService _cariHareketService;
        public FaturaManager(IFaturaDal faturaDal,ITahsilatService tahsilatService)
        {
           // _cariHareketDal = cariHareket;
            _faturaDal = faturaDal;
            _tahsilatService = tahsilatService;
           // _cariHareketService = cariHareketService;
        }
          
        public IResult Add(Fatura fatura)
        {
            _faturaDal.Add(fatura);
            return new SuccesResutl();
        }

        public IResult CreateFatura(Sepet sepet)
        {
            Fatura fatura = new Fatura
            {
                BürütTutar = sepet.BürütTutar,
                CariNo = sepet.CariNo,
                FaturaNo = CreateFaturaNoWithGUID().Message,
                GenelToplam = sepet.Fiyat,
                KDV = sepet.KDV,
                Tarih = DateTime.Now,
                Tip = sepet.SatısTipi,
                UrunAdı = sepet.UrunAdı,
                UrunKodu = sepet.UrunKodu,
              
            };

            _faturaDal.Add(fatura);
            _tahsilatService.CreateTahsilat(fatura);

            //var result = getByFaturaNo(fatura.FaturaNo);
            //_cariHareketService.CreateCariHareket();

            return new SuccesResutl();
        }

        public IResult Delete(Fatura fatura)
        {
            fatura.FaturaNo = CreateFaturaNoWithGUID().Message;
            _faturaDal.Add(fatura);
            return new SuccesResutl();
        }

        IDataResult<Fatura> getByFaturaNo(string FaturaNo)
        {

            return new SuccesDataResult<Fatura>(_faturaDal.Get(f => f.FaturaNo == FaturaNo));
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

        private IDataResult<string> CreateFaturaNoWithGUID()
        {
            
            
                string NewGUID = System.Guid.NewGuid().ToString().Replace("-", "").ToUpper();
                return new SuccesDataResult<string>(NewGUID);
            
        }

        
    }
}
