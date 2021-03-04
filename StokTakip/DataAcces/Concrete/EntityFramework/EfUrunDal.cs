using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfUrunDal : EfEntityRepositoryBase<Urun, CariAlimSatimContext>, IUrunDal
    {
        public List<UrunDetailsDto> GetUrunDetails()
        {
            using (CariAlimSatimContext context = new CariAlimSatimContext())
            {
                var result = from u in context.Urun
                             join s in context.Stok
                             on u.UrunKodu equals s.UrunKodu
                             select new UrunDetailsDto
                             {
                                 UrunId = u.UrunId,
                                 UrunAdı = u.UrunAdı,
                                 UrunKodu = u.UrunKodu,
                                 Barkot = u.Barkot,
                                 CariNo = s.CariNo,
                                 KDV = u.KDV,
                                 Fiyat = u.Fiyat,
                                 Miktar = s.Miktar,
                                 UrunTipi = u.UrunTipi
                             };
                return result.ToList();


               
            }

           
        }
    }
}
