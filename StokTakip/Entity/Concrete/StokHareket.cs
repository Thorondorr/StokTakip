using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class StokHareket:IEntity
    {
        public string FaturaNo { get; set; }
        public string CariNo { get; set; }
        public DateTime Tarih { get; set; }
        public int KDV { get; set; }
        public decimal Tutar { get; set; }
        public string GirisCikis { get; set; }
        public int Id { get; set; }
    }
}
