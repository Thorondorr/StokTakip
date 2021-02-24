using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Kullanıcı:IEntity
    {
        public int KullanıcıId { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
    }
}
