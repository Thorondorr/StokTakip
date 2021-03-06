using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.DTOs
{
    public class TahsilatDetailsDto:IDto
    {
        [Key]
        public string FaturaNo { get; set; }
        public string CariAdı { get; set; }
        public string CariNumarası { get; set; }
        public string UrunAdı { get; set; }
        public int Miktar { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public string BorcAlacak { get; set; }
        public decimal GenelToplam { get; set; }
        public string UrunKodu { get; set; }
    }
}
