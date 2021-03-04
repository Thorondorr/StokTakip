using Business.Concrete;
using DataAcces.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // KullanıcılarManager kullanıcıManager = new KullanıcılarManager(new EfKullanıcıDal());
           // StokManager stokManager = new StokManager(new EfStokDal());
           // UrunManager urunManager = new UrunManager(new EfUrunDal());
           // FaturaManager faturaManager = new FaturaManager(new EfFaturaDal());
           // CariHareketlerManager cariHareketlerManager = new CariHareketlerManager(new EfCariHareketDal());
           // TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
           // CariManager cariManager = new CariManager(new EfCariDal());

           // Urun hıyarlar = new Urun
           // {   UrunId=7,
           //     UrunAdı = "Hıyar",
           //     UrunTipi = "yiyecek",
           //     Barkot = "123",
           //     Fiyat = 20,
           //     Miktar = 50,
           //     KDV =1
           // };
            

           // Cari fahri = new Cari
           // {
           //     CariAdı = "FAHRİCAN KAÇAN",
           //     CariAdres = "SELCUKLU MAHALLESİ KOLAY SOKAK 2/3",
           //     CariIl = "ANKARA",
           //     CariIlce = "SİNCAN",
           //     CariNo = "123",
           //     Eposta = "fahrican.kcn@gmail.com",
           //     TcKimlikNo = "54559146504",
           //     Telefon = "5416065233",
           //     VergiDairesi = "SİNCAN",
           //     VergiNo = "1234"

           // };
        
           //// cariManager.Add(fahri);

           // /********************************SATIŞ İŞLEMİ***********************************************/
           // Fatura fatura1 = new Fatura
           // {
           //     FaturaId=1,
           //   //  Barkot=hıyarlar.Fiyat.ToString(),
           //     UrunAdı=hıyarlar.UrunAdı,
           //     BürütTutar = hıyarlar.Fiyat,
           //     KDV = hıyarlar.KDV,
           //     CariNo = fahri.CariNo,
           //     FaturaNo = "f1",
           //     GenelToplam = ((5 * hıyarlar.Fiyat) * hıyarlar.KDV) / 100, // 5 adet hıyar genel fiyatı
           //     Tarih = DateTime.Now,
           //     Tip = "satış"
           // };


           // CariHareket cariHareket = new CariHareket
           // {
           //     CariNo = fahri.CariNo,
           //     Tarih = DateTime.Now,
           //     Aciklama = "ilk alışveriş hayırlı olsun",
           //     BorcAlacak = $"{fatura1.GenelToplam} TL ödendi.",
           //     FaturaNo = fatura1.FaturaNo
           // };

           // Tahsilat tahsilat = new Tahsilat
           // {
           //     BelgeNo = fatura1.FaturaNo,
           //     CariNo = fahri.CariNo,
           //     Tarih = DateTime.Now,
           //     Tip = "nakit",
           //     Tutar = fatura1.GenelToplam
           // };

           // hıyarlar.Miktar = -5;
           // //urunManager.Update(hıyarlar);


           // //urunManager.Add(hıyarlar);
           // //cariHareketlerManager.Add(cariHareket);
           // //faturaManager.Update(fatura1);
           // //tahsilatManager.Add(tahsilat);

           // var resul1 = cariHareketlerManager.GetAll();
           // var resul2 = faturaManager.GetAll();
           // var resul3 = tahsilatManager.GetAll();

           // foreach( var rsl1 in resul1.Data)
           // {
           //     Console.WriteLine($"Cari ID {rsl1.CariHareketId}//Cari No {rsl1.CariNo} //FaturaNo {rsl1.FaturaNo} //Açıklama {rsl1.Aciklama} //Tarih {rsl1.Tarih} //Tutar {rsl1.Tutar} ");
           // }
           // foreach (var rsl2 in resul2.Data)
           // {
           //     Console.WriteLine($"//Cari no {rsl2.CariNo} //fatura no {rsl2.FaturaNo} //FaturaId {rsl2.FaturaId} //KDV {rsl2.KDV} //Tarih {rsl2.Tarih} //Genel Toplam {rsl2.GenelToplam} ");
           // }
           // foreach (var rsl3 in resul3.Data)
           // {
           //     Console.WriteLine($"Belge No {rsl3.BelgeNo}//Cari No {rsl3.CariNo} //TahsilatID {rsl3.TahsilatId} //Tarih {rsl3.Tarih} //Tip {rsl3.Tip} //Tutar {rsl3.Tutar} ");
           // }







           // //kullanıcıManager.Add(new Entity.Concrete.Kullanıcı {
           // //    KullanıcıAdı = "fako",
           // //    Sifre = "123",
           // //    Eposta = "fahrican.kcn@gmail.com" });

           // //var result = kullanıcıManager.GetAll();

           // //foreach(var kullanıcı in result)
           // //{
           // //    Console.WriteLine($"KullanıcıAdı:{kullanıcı.KullanıcıAdı} Sifre : {kullanıcı.Sifre}  Email : {kullanıcı.Eposta}"  );
           // //}



            //Entity.Concrete.Urun hıyar = new Entity.Concrete.Urun
            //{
            //    UrunId=6,
            //    Barkot = "123",
            //    Fiyat = 10,
            //    KDV = 5,
            //    Miktar = 10,
            //    UrunAdı = "hıyar",
            //    UrunTipi = "sebze"
            //};

            //urunManager.Delete(hıyar);
            //stokManager.Delete(new Entity.Concrete.Stok
            //{
            //    StokId = 6,
            //    Barkot = hıyar.Barkot,
            //    UrunAdı = hıyar.UrunAdı,
            //    CariNo = "kendisi",
            //    FaturaNo = "kendisi",
            //    GirisCikis = "giris",
            //    KDV = hıyar.KDV,
            //    Miktar = hıyar.Miktar,
            //    StokNetFiyatı = hıyar.Fiyat,
            //    Tarih = DateTime.Now
            //});

            //var result = stokManager.GetAll();
            //foreach(var a in result.Data)
            //{
            //    Console.WriteLine($"{a.UrunAdı} {a.Miktar} {a.KDV}");
            //}

            //Console.WriteLine("--------------------------");
            ////Console.WriteLine(stokManager.GetAll().Data.ToString());



        }
    }
}
