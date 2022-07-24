using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IsLibrary; //is katmanımın olduğu IsLibrary i ekliyorum.

namespace IsLibrary.Entity  //bu kısımda veritabanımızdaki değişkenleri get ve set edilebilir şekilde ayarlamasını yapıyorum.
{
    public class Stok
    {
        public int ID { get; set; } //veritabanımdaki her tablo değişkenini int, string, double neyse ona göre tanımlıyorum.
        public string UrunMarkasi { get; set; }
        public string UrunAdi { get; set; }
        public string UrunKategorisi { get; set; }
        public string SonKullanmaTarihi { get; set; }
        public int Adet { get; set; }
        public double BirimFiyat { get; set; }
        public Stok() { }   //nesne oluşturmak için parametresiz constructor bloğu.alttaki aynı isimli constructor ile overload işlemi gerçekleşir.
        //bunu yapmamın sebebi nesne oluşturulur oluşturulmaz propertylere değerler gönderilebilsin diye.
        public Stok(int ID, string UrunMarkasi, string UrunAdi, string UrunKategorisi, string SonKullanmaTarihi, int Adet, double BirimFiyat)
        {   //bu kısımda Stok içinde tüm değerlerin parametre olarak geldiğini ve gelen ID bu sınıftaki(this) karşılığını(this.id = id gibi) olduğunu belirtiyorum.
            this.ID = ID;   //her biri için aynı işlem değişen bir şey yok
            this.UrunMarkasi = UrunMarkasi;
            this.UrunAdi = UrunAdi;
            this.UrunKategorisi = UrunKategorisi;
            this.SonKullanmaTarihi = SonKullanmaTarihi;
            this.Adet = Adet;
            this.BirimFiyat = BirimFiyat;
        }
    }
}
