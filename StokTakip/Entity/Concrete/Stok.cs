using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Stok:IEntity
    {
        public int StokId { get; set; }
        public string UrunAdı { get; set; }
        public string UrunKodu { get; set; }
        //public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string CariNo { get; set; }
        public string GirisCikis { get; set; }
        public decimal StokNetFiyatı { get; set; }
        public int KDV { get; set; }
        public int Miktar { get; set; }


    }
}
