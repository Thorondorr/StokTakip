using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Kullanıcı:IEntity
    {
        public string KullanıcıAdı { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
    }
}
