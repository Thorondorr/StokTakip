using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Fatura:IEntity
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public string UrunAdı { get; set; }
        public string UrunKodu { get; set; }   
        public DateTime Tarih { get; set; }
        public string CariNo { get; set; }
        public decimal BürütTutar { get; set; }
        public int KDV { get; set; }
        public decimal GenelToplam { get; set; }
        public string Tip { get; set; }
        public int Miktar { get; set; }
        //  public string Aciklama { get; set; }
        //  public string BorcAlacak { get; set; }
    }
}
