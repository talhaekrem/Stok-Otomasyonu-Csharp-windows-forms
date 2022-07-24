using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IsLibrary;    //iş kütüphanesini ekliyorum
using IsLibrary.Entity; //iş kütüphanesi entity klasörünü ekliyorum
using IsLibrary.Facade; //iş kütüphanesi facade klasörünü ekliyorum
namespace StokOtomasyonu
{
    public partial class SorguForm : Form
    {
        public SorguForm()
        {
            InitializeComponent();
        }

        private void sorguyapBtn_Click(object sender, EventArgs e)//butona tıkladığında sorgu yap çalışıcak
        {
            Stok entity = new Stok();   //entity klasörü içinde stok sınıfından "entity" adında nesne oluşturuyorum.
            //bu nesneyi değerleri çağırırken kullanacağız.

            if (markaRadio.Checked == true) //eğer marka sorgusu için koyduğum radioButton seçiliyse...
            {
                entity.UrunMarkasi = sorgutxt.Text; //textboxtaki değer benim entitydeki UrunMarkasi değerine eşittir.
                sorgugrid.DataSource = Stoklar.SelectMarkaSorgu(entity); //bu değeri al select komutu için kullan
            }
            else if (adRadio.Checked == true) //eğer ad sorgusu için koyduğum radioButton seçiliyse...
            {
                entity.UrunAdi = sorgutxt.Text; //textboxtaki değer benim entitydeki UrunAdi değerine eşittir.
                sorgugrid.DataSource = Stoklar.SelectadSorgu(entity);   //bu değeri al select komutunda kullan.
            }
            else
            {       //eğer hiçbir radioButton seçilmemişse kullanıcıyı seçim yapması konusunda uyarıyorum.
                MessageBox.Show("Lütfen Seçim Yapınız...");
            }
            
            if(sorgugrid.Rows.Count == 0) //eğer girilen texte göre ürün bulunmadıysa ürün bulunamadı diye bilgilendirsin.
                MessageBox.Show("Girdiğiniz kelimeye ait ürün bulunamadı.\nDoğru yazdığınızdan emin olun.", "Sorgu Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Sorgu Başarılı. "+sorgugrid.Rows.Count +" ürün bulundu.","Sorgu Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //sorgu başarılı olduğuna dair kullanıcıyı bilgilendiriyorum. Tamam butonuyla birlikte Bulunan ürün sayısı ve bilgi ikonu ekliyorum.
        }

        private void SorguForm_Load(object sender, EventArgs e)
        {
            sorguyapBtn.Image = btnResimleri.Images[3]; //butona resim eklemek için form çalıştığından itibaren aktif ol
        }

    }
}
