using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Tahsilat:IEntity
    {
        public string Tip { get; set; }
        public DateTime Tarih { get; set; }
        public string CariNo { get; set; }
        public decimal Tutar { get; set; }
        public string BelgeNo { get; set; }

    }
}
