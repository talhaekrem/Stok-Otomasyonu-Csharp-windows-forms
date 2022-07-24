using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration; //app.config içinde oluşturduğumuz bağlantıyı işlemek için gerekli kütüphane, ConfigurationManageri içerir.
using System.Data.OleDb;//Access Kütüphanesi
using System.Data;      //ConnectionState için gerekli kütüphane

namespace VeriLibrary   //DATA ACCESS LAYER yani katmanlı mimarinin VERİ ERİŞİM KATMANI için bulunan kısım.
{
    public class VeriTabani //accese bağlanmanın birkaç yolu var ben daha kolaylık sağlayan ve daha güvenilir olan yolu seçtim. ConfigurationManager yolu.
    {   //Öncelikle bağlantımızı burada değil projenin ana dosyalarında(class librarylerde değil StokOtomasyonu içinde) bulunan "app.config" dosyasını içinde oluşturuyoruz.
        //ve içinde ConnectionStrings oluşturup bağlantı değerlerimizi oraya yazıyoruz ve bu kısımda da oradan sadece name=baglantiStr yi kullanarak baglantımızı yapıyoruz.
        private static OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["baglantiStr"].ConnectionString);

        public static OleDbConnection Baglanti  //static tanımlamamın sebebi diğer sınıflardan nesne oluşturmadan kolayca erişebilmek.
        {
            get { return baglanti;} //baglanti nesnesini get ve set et.
            set{baglanti = value;}
        }

        public static bool ExecuteNonQuery(OleDbCommand komut) //ExecuteNonQuery, insert update ve delete komutlarından etkilenen satır sayısını döndürür.
        {   //her sorgudan sonra kullanılır.

            try     //try-catch-finally. baglantı açık mı diye kontrolü sağlanır. eğer açıksa bir daha açmayı denerse hata verir.
            {   //bağlantı yoksa bağlantı aç
                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                return komut.ExecuteNonQuery() > 0;//bu kısımda yaptığım şey eğer ExecuteNonQuery çalıştığında etkilenen satır olursa(0 dan büyükse) true döndür demektir.
            }
            catch (Exception)   //ExecueNonQuery komutuyla etkilenen satır olmamışsa yani 0 dan küçük veya eşite geriye false döndür.
            {
                return false;
            }

            finally     //işlem bittiğinde bağlantı kapanmamışsa bağlantıyı kapa.
            {
                if (komut.Connection.State != ConnectionState.Closed)
                    komut.Connection.Close();
            }
        }
    }
}
/*app.config açıklamasını buraya yazıyorum...... 
öncelikle App.config içine deklediğimiz kısım sadece <connectionStrings> </connectionStrings> arasındaki bloktur.
bu arasına yazdığımız şey veritabanına bağlanmak için gerekli kodlardır
<add> diyip bağlantı ekleriz. bu add içine yazdığımız "name" dışardan erişmek istediğimizde kullanacağımız isimdir.
connectionstring ise veritabanına bağlanmak için gerekli yazıları içerir. sql server kullansaydık buraya adı ve şifreyi yazardık.
access kullandığımızdan dolayı buraya access yolumuzu ve veritabanımızın ismini yazıyoruz.
providername ise bağlantımızın sağlayıcısının adını yazdığımız kısım.
 */