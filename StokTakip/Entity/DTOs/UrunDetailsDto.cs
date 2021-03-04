using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.DTOs
{
    public class UrunDetailsDto:IDto
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAdı { get; set; }
        public string UrunKodu { get; set; }
        public string CariNo { get; set; }
        public string Barkot { get; set; }
        public int KDV { get; set; }
        public decimal Fiyat { get; set; }
        public int Miktar { get; set; }
        public string UrunTipi { get; set; }
    }
}
