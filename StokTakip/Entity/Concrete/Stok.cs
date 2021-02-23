using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Stok:IEntity
    {
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string CariNo { get; set; }
        public string GirisCikis { get; set; }
        public string StokNetFiyatı { get; set; }
        public int KDV { get; set; }
        public int Miktar { get; set; }


    }
}
