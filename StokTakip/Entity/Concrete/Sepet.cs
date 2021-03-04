using Core.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Sepet : IEntity
    {       
        public int UrunId { get; set; }
        public string UrunAdı { get; set; }
        public string UrunKodu { get; set; }
        public string CariNo { get; set; }
        public string Barkot { get; set; }
        public int KDV { get; set; }
        public decimal Fiyat { get; set; }
        public int Miktar { get; set; }
        public string UrunTipi { get; set; }
        public string SatısTipi { get; set; }
        public decimal BürütTutar { get; set; }
        public string Aciklama { get; set; }
        public string BorcAlacak { get; set; }
    }
}
