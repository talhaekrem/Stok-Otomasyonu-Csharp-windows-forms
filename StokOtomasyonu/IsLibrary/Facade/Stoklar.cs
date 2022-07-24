using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IsLibrary;    //is katmanımın olduğu IsLibrary 'yi ekliyorum.
using VeriLibrary;  //veri katmanımın olduğu VeriLibrary i ekliyorum.
using System.Data.OleDb;    //Access komutları için gerekli kütüphane
using System.Data;          //DataTable kullanabilmek için gerekli kütüphane

namespace IsLibrary.Facade  //katmanlı mimarinin BLL(business logic layer) kısmının kısaca iş katmanındaki facade...
{   //... yani sorguların yapıldığı iş yükünün olduğun kısımdayız. burda veritabanımızdan LİSTELE,EKLE,SİL,GÜNCELLE...
    //sorgularını yapacağız.
    public class Stoklar
    {
        public static DataTable Select() //listele işlemi
        { //static tanımlamamın sebebi bağlantı nesnemizin de static olmasıdır.
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM Stok", VeriLibrary.VeriTabani.Baglanti); //adapter tanımı selectte kullanılır, parametre...
            DataTable DT = new DataTable(); //...olarak sorgu cümlesi ve bağlantıyı alır. //datatable ise çektiği verileri koyacağı tablodur. DS adında nesne oluşturuyoruz.
            adp.Fill(DT);   //bu tablomuzu sorgudan gelen verilerle dolduruyoruz.
            return DT; //ve sonucu geriye döndürüyoruz (return ediyoruz).
        }

        public static DataTable SelectMarkaSorgu(IsLibrary.Entity.Stok sorgu) //sorgu için gerekli listele işlemi
        {   //bu kısımda markasorgusu yapacağız.ürün sorgula için.
            string srg = sorgu.UrunMarkasi;     //entitydeki UrunMarkasi değerini alıyoruz.
            string sorgustringi = "SELECT ID, UrunMarkasi, UrunAdi, Adet FROM Stok WHERE UrunMarkasi Like '"+ srg +"'"; //sorgumuzda alacağımız sütunlar ve neyi aratacağımızı söylüyoruz.
            OleDbDataAdapter adp = new OleDbDataAdapter(sorgustringi, VeriLibrary.VeriTabani.Baglanti); //select için adapter tanımlaması (sorgu,baglanti) parametreleri şeklinde gerçekleşir.
            DataTable DT = new DataTable(); //datatable ise çektiği verileri koyacağı tablodur. DS adında nesne oluşturuyoruz.
            adp.Fill(DT); //bu tablomuzu sorgudan gelen verilerle dolduruyoruz.
            return DT; //ve sonucu geriye döndürüyoruz (return ediyoruz).
        }

        public static DataTable SelectadSorgu(IsLibrary.Entity.Stok sorgu)  //sorgu için gerekli listele işlemi
        {   //bu kısımda ad sorgusu yapacağız.ürün sorgula için.
            string srg = sorgu.UrunAdi;     //entitydeki UrunAdi bilgisini alıyoruz.
            string sorgustringi = "SELECT ID, UrunMarkasi, UrunAdi, Adet FROM Stok WHERE UrunAdi Like '" + srg + "'"; //sorgumuzda alacağımız sütunlar ve neyi aratacağımızı söylüyoruz.
            OleDbDataAdapter adp = new OleDbDataAdapter(sorgustringi, VeriLibrary.VeriTabani.Baglanti); //select için adapter tanımlaması (sorgus,baglanti) parametreleri şeklinde gerçekleşir.
            DataTable DT = new DataTable(); //datatable ise çektiği verileri koyacağı tablodur. DS adında nesne oluşturuyoruz.
            adp.Fill(DT); //bu tablomuzu sorgudan gelen verilerle dolduruyoruz. 
            return DT; //ve sonucu geriye döndürüyoruz (return ediyoruz).
        }

        public static bool Insert(IsLibrary.Entity.Stok entity) //ürün ekleme işlemi.
        { //staticin sebebini yukarına söylemiştim farklı birşey var o da bool olması. bunun sebebi. işlem sonunda eklendi veya eklenmedi diye 2 değer döndürcek. buna en uygun tanımlama bool olacaktır.
            OleDbCommand komut = new OleDbCommand("INSERT INTO Stok(UrunMarkasi,UrunAdi,UrunKategorisi,SonKullanmaTarihi,Adet,BirimFiyat) values(@m,@ad,@k,@skt,@adet,@bf)", VeriLibrary.VeriTabani.Baglanti);
            //bu sefer adapter değil komut tanımlıyoruz çünkü bu kısımda table'a veri aktarmayacağız. komut parametre olarak(sorgu,baglanti) alır. tablomdaki her bir değer için SIRAYLA değişken tanımlıyorum.
            komut.Parameters.AddWithValue("@m", entity.UrunMarkasi); //eklencek @m değişkeni benim entitydeki UrunMarkasi kısmım
            komut.Parameters.AddWithValue("@ad", entity.UrunAdi); //eklencek @ad değişkeni benim entitydeki UrunAdi kısmım
            komut.Parameters.AddWithValue("@k", entity.UrunKategorisi); //eklencek @k değişkeni benim entitydeki UrunKategorisi kısmım
            komut.Parameters.AddWithValue("@skt", entity.SonKullanmaTarihi); //eklencek @skt değişkeni benim entitydeki SonKullanmaTarihi kısmım
            komut.Parameters.AddWithValue("@adet", entity.Adet); //eklencek @adet değişkeni benim entitydeki Adet kısmım
            komut.Parameters.AddWithValue("@bf", entity.BirimFiyat); //eklencek @bf değişkeni benim entitydeki BirimFiyat kısmım

            return VeriLibrary.VeriTabani.ExecuteNonQuery(komut); //bağlantı sınıfımdaki executeNonQuery classını çağırıyorum. her insert delete update sorgusundan sonra kullanılır.
        }

        public static bool Delete(IsLibrary.Entity.Stok entity) //ürün silme işlemi.
        {   //komut tanımlaması yine aynı (sorgu,baglanti) şeklinde burda sorgumuzu değişmeyen değer olan ID ye göre yapıyoruz. silme işleminde referansımız ID dir.
            OleDbCommand komut = new OleDbCommand("DELETE from Stok WHERE ID=@id", VeriLibrary.VeriTabani.Baglanti);
            komut.Parameters.AddWithValue("@id", entity.ID);  //silinecek satır için @id değişkeni benim entitydeki ID kısmım
            return VeriLibrary.VeriTabani.ExecuteNonQuery(komut); //veriLibraryden executeNonQuery return et.
        }

        public static bool Update(IsLibrary.Entity.Stok entity) //ürün güncelleme işlemi.
        { //güncelle sorgusu ekleden farklı olarak referans olarak id alıyoruz ve yeni değerlerin parametrelerini hemen yanına eşittir olarak yazpıyoruz. komut parametreleri aynı(sorgu,baglanti) şeklinde.
            OleDbCommand komut = new OleDbCommand("UPDATE Stok set UrunMarkasi=@m,UrunAdi=@ad,UrunKategorisi=@k,SonKullanmaTarihi=@skt,Adet=@adet,BirimFiyat=@bf WHERE ID=@id", VeriLibrary.VeriTabani.Baglanti);
            komut.Parameters.AddWithValue("@m", entity.UrunMarkasi); //güncellenecek @m değişkeni benim entitydeki UrunMarkasi kısmım
            komut.Parameters.AddWithValue("@ad", entity.UrunAdi); //güncellenecek @ad değişkeni benim entitydeki UrunAdi kısmım
            komut.Parameters.AddWithValue("@k", entity.UrunKategorisi); //güncellenecek @k değişkeni benim entitydeki UrunKategorisi kısmım
            komut.Parameters.AddWithValue("@skt", entity.SonKullanmaTarihi); //güncellenecek @skt değişkeni benim entitydeki SonKullanmaTarihi kısmım
            komut.Parameters.AddWithValue("@adet", entity.Adet); //güncellenecek @adet değişkeni benim entitydeki Adet kısmım
            komut.Parameters.AddWithValue("@bf", entity.BirimFiyat); //güncellenecek @bf değişkeni benim entitydeki BirimFiyat kısmım
            komut.Parameters.AddWithValue("@id", entity.ID); //referans alacağımız @id değişkeni benim entitydeki ID kısmım

            return VeriLibrary.VeriTabani.ExecuteNonQuery(komut); //ExecuteNonQuery işlemi çağırılır. etkilenen satır döndürülür.
        }
    }
}
