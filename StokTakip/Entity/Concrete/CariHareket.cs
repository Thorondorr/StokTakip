using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class CariHareket:IEntity
    {
        public int CariHareketId { get; set; }
        public string FaturaNo { get; set; }      
        public string CariNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BorcAlacak { get; set; }       
        public decimal Tutar { get; set; }
    }
}
