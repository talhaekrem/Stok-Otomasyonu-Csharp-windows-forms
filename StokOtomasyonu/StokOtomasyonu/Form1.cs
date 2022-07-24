using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    //Access veritabanı bağlantısı için gerekli kütüphane
using IsLibrary;            //İş class kütüphanesini ekliyorum
using IsLibrary.Facade;     //İş kütüphanesine ait facade klasörünü ekliyorum
using IsLibrary.Entity;     //İş kütüphanesine ait entity klasörünü ekliyorum

namespace StokOtomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Bu kısım aslında katmanlı mimarimizin görünüm katmanıdır. kullanıcının göreceği ayarlar burada yapılır.
        {                                       //programımda saat olsun istedim form1 load olduğunda saatim çalışmaya başlasın
            saat.Enabled = true;
            veriGorunum.DataSource = Stoklar.Select();  //formum ilk açıldığında datagridviewimdeki veriler gözükmeye başlasın komutu.
            veriGorunum.ClearSelection();   //form başladığında datagridviewde satır seçili gelmesin komutu. satır seçili olunca textboxlar dolu gözüküyordu. hoş bir görüntü olmuyordu.
            ekleBtn.Image = btnResimleri.Images[0]; //form çalışmaya başladığında resimleri butonlarıma ekle. 0 indisli resim
            silBtn.Image = btnResimleri.Images[1]; //form çalışmaya başladığında resimleri butonlarıma ekle. 1 indisli resim
            guncelleBtn.Image = btnResimleri.Images[2]; //form çalışmaya başladığında resimleri butonlarıma ekle. 2 indisli resim
            sorguBtn.Image = btnResimleri.Images[3]; //form çalışmaya başladığında resimleri butonlarıma ekle. 3 indisli resim
        }

        private void saat_Tick(object sender, EventArgs e)  //saat oluşturmak için öncelikle her 1 saniyede bir tetiklenen bir timer ekledim...
        {           //...bu timer her 1 saniyede label'a DateTime fonksiyonu sayesinde tarih bilgisini ve saat bilgisini atıyor.
            string tarih = DateTime.Now.ToLongDateString();
            string saat = DateTime.Now.ToLongTimeString();
            saatlbl.Text = saat;        //saat labelına string saati at
            tarihLabel.Text = tarih;    //tarih labelına string tarihi at
        }

        private void ekleBtn_Click(object sender, EventArgs e)  //ürün ekleme işlemi
        {
            Stok entity = new Stok();   //IsLibrary>Entity klasörü içinde Stok adındaki Classdan nesne oluşturuyorum. Bunun sebebi ürün eklemek için değerleri get set ile kontrolünü sağlamak
            entity.UrunMarkasi = UrunMarkatxt.Text; //ürünmarkasının formdaki UrunMarkatxt'sindeki değer olduğunu söylüyorum.
            entity.UrunAdi = UrunAdtxt.Text;    //ürünadının formdaki UrunAdtxt'sindeki değer olduğunu söylüyorum.
            entity.UrunKategorisi = UrunKategoricombo.SelectedItem.ToString();  //ürün kategorisinin formdaki UrunKategoricombo daki seçili değer olduğunu söylüyorum.
            entity.SonKullanmaTarihi = SKTdatepicker.Value.ToString();  //SKT nin formdaki SKTdatepicker deki seçili tarih olduğunu söylüyorum.
            entity.Adet = Convert.ToInt32(Adetnumeric.Value);   //ürün adedinin formdaki Adetnumericdeki değer olduğunu söylüyorum.
            entity.BirimFiyat = Convert.ToDouble(Fiyattxt.Text);    //ürün fiyatının formdaki Fiyattxt'sindeki değer olduğunu söylüyorum.

            if (!Stoklar.Insert(entity))    //Facade>Stoklar classında Insert yani ekleme fonksiyonu çalışmazsa eğer bunu messagebox ile çalışmadığını bildir.
                MessageBox.Show("Ürün Ekleme Başarısız.\n Tüm Alanları Doldurduğunuzdan Emin Olun.");
            MessageBox.Show("Ürün Başarıyla Eklendi.","Eklendi",MessageBoxButtons.OK,MessageBoxIcon.Information); //ürün eklendiğinde başarılı olduğuna dair bilgilendirme mesajı
            veriGorunum.DataSource = Stoklar.Select();  //Ekleme olduğunda dataGridViewi tekrar listele.
        }

        private void silBtn_Click(object sender, EventArgs e)   //ürün silme işlemi
        {
            if (veriGorunum.SelectedRows.Count == 0) return;    //eğer satır seçili değilse geri dön bir şey yapma

            Stok silinecek = new Stok();    //nesne oluştururuz.
            silinecek.ID = (int)veriGorunum.CurrentRow.Cells["ID"].Value;   //seçili satırın ID si entitydeki Stok clasınındaki ID dir diyoruz.

            if (!Stoklar.Delete(silinecek)) //ve silme işlemini çağırıyoruz.
                MessageBox.Show("Ürün Silme Başarısız.\n Listeden Silinecek Satırı Seçtiğinizden Emin Olun.");  //eğer silme gerçekleşmezse hata mesajı ver
            MessageBox.Show("Ürün Silme Başarılı.","Silindi",MessageBoxButtons.OK,MessageBoxIcon.Information); //ürün silme başarılı olduğuna dair bilgilendirme mesajı
            veriGorunum.DataSource = Stoklar.Select();  ////silme gerçekleştiğinde dataGridViewi tekrar listele.
        }

        private void guncelleBtn_Click(object sender, EventArgs e)  //ürün güncelleme işlemi
        {
            Stok guncelle = new Stok(); //stok entitysinden guncelle adında nesne oluşturuyoruz.
            guncelle.ID = (int)IDtxt.Tag; //IDtxt nin tagını entitydeki ID verisine eşitliyoruz. güncellerken id sabit kalacağı için.
            guncelle.UrunMarkasi = UrunMarkatxt.Text; //aynı ekledeki gibi verileri formdaki ilgili kutucuktaki değer olduğunu söylüyorum.
            guncelle.UrunAdi = UrunAdtxt.Text;  //diğer hepsinde de aynı işlemi yapıyorum.
            guncelle.UrunKategorisi = UrunKategoricombo.SelectedItem.ToString();
            guncelle.SonKullanmaTarihi = SKTdatepicker.Value.ToString();
            guncelle.Adet = Convert.ToInt32(Adetnumeric.Value);//adet bilgisi numericUpDown ile ayarlanabilir. bunu da int olarak tanımlamak istedim.
            guncelle.BirimFiyat = Convert.ToDouble(Fiyattxt.Text);//fiyat bilgisi küsüratlı olabildiğinden double olarak tanımlamıştım.

            if (!Stoklar.Update(guncelle))  //güncelle metodunu çağır eğer olmazsa...
                MessageBox.Show("Ürün Güncelleme Başarısız."); //...olmadığını bilgilendir.
            MessageBox.Show("Ürün Başarıyla Güncellendi.","Güncellendi",MessageBoxButtons.OK,MessageBoxIcon.Information); //eğer olursa da bilgilendir.
            veriGorunum.DataSource = Stoklar.Select();

        }

        private void AnaForm_Click(object sender, EventArgs e)  //kutucukları temizleme işlemi
        {   //form her çalıştığında datagriddeki seçili satır kutucuklara geliyordu. ekleme yapmak istediğimizde boş kutucuklar...
            veriGorunum.ClearSelection();   ///...olsun istiyorum. bunun içinde forma tıklandığında kutucuklar temizlensin kodunu yazdım.
            IDtxt.Clear();  //forma tıklandığında kutucuklarda yazanlar temizlencek ve datagriddeki seçili satır seçili olmaktan çıkıcak.
            UrunMarkatxt.Clear();
            UrunAdtxt.Clear();
            UrunKategoricombo.Text = "Kategori Seçiniz...";
            Adetnumeric.Value = 1;
            Fiyattxt.Clear();
            
        }

        private void sorguBtn_Click(object sender, EventArgs e)//ürün sorgusu yapmak için formu açma işlemi
        {
            SorguForm formuac = new SorguForm();//yeni formdan nesne oluşturuyorum
            formuac.ShowDialog();//bu nesneyi ekranda göster diyorum.
        }

        private void veriGorunum_CellClick(object sender, DataGridViewCellEventArgs e) //datagridviewden seçini satırın kutucuklarda gözükmesini sağlama
        { //bu kısımda yaptığım şey, ürün güncellemede kolaylık olsun diye seçili satırın kutucuklarda görünmesidir.
            DataGridViewRow satir = veriGorunum.CurrentRow; //satır adında nesne oluşturuyorum. bu nesneyi kullanarak benim datagridimdeki hücrelere ulaşacağım
            IDtxt.Text = satir.Cells["ID"].Value.ToString();    //Idtxt in yazısı benim datagridimdeki ID hücresindeki seçili veridir.
            IDtxt.Tag = satir.Cells["ID"].Value;    //Idtxt in Tagı benim datagridimdeki ID hücresindeki seçili verinin tagıdır.TAGı güncellemede kullanıyoruz
            UrunMarkatxt.Text = satir.Cells["UrunMarkasi"].Value.ToString();    //seçili kutucuk bilgisi verigorunumdeki ilgili hücredeki veridir.
            UrunAdtxt.Text = satir.Cells["UrunAdi"].Value.ToString();    //seçili kutucuk bilgisi verigorunumdeki ilgili hücredeki veridir.
            UrunKategoricombo.Text = satir.Cells["UrunKategorisi"].Value.ToString();     //seçili kutucuk bilgisi verigorunumdeki ilgili hücredeki veridir.
            SKTdatepicker.Value = (DateTime)satir.Cells["SonKullanmaTarihi"].Value;  //seçili kutucuk bilgisi verigorunumdeki ilgili hücredeki veridir.
            Adetnumeric.Value = (int)satir.Cells["Adet"].Value;  //seçili kutucuk bilgisi verigorunumdeki ilgili hücredeki veridir.
            Fiyattxt.Text = satir.Cells["BirimFiyat"].Value.ToString(); //seçili kutucuk bilgisi verigorunumdeki ilgili hücredeki veridir.
        }

    }
}
