using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAcces.Concrete
{
    public class EfTahsilatDal : EfEntityRepositoryBase<Tahsilat, CariAlimSatimContext>, ITahsilatDal
    {
        public List<TahsilatDetailsDto> GetTahsilatDetails()
        {
            using (CariAlimSatimContext context = new CariAlimSatimContext())
            {
                var result = from ch in context.CariHareket
                             join f in context.Fatura on ch.FaturaNo equals f.FaturaNo
                             join c in context.Cari on ch.CariNo equals c.CariNo
                             select new TahsilatDetailsDto
                             {
                                 FaturaNo = f.FaturaNo,
                                 CariAdı = c.CariAdı,
                                 CariNumarası = ch.CariNo,
                                 UrunAdı = f.UrunAdı,
                                 UrunKodu = f.UrunKodu,
                                 Aciklama = ch.Aciklama,
                                 Tarih = f.Tarih,
                                 BorcAlacak = ch.BorcAlacak,
                                 GenelToplam = f.GenelToplam,
                                 Miktar = f.Miktar

                             };
                return result.ToList();
                              
            }
        }
    }
}
