using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Cari:IEntity
    {
        public int CariId { get; set; }
        public string CariNo { get; set; }
        public string CariAdı { get; set; }
        public string CariAdres { get; set; }
        public string CariIl { get; set; }
        public string CariIlce { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
    }
}
