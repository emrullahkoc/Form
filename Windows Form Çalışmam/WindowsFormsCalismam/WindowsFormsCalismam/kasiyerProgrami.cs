using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalismam
{
    public partial class kasiyerProgrami : Form
    {
        public kasiyerProgrami()
        {
            InitializeComponent();
        }

        ArrayList kasiyerler = new ArrayList(); // SEÇİLEN KASİYERLERİ TUTMAK İÇİN ArrayList OLUŞTURULUYOR
        ArrayList tarih = new ArrayList();  // SEÇİLEN TARİHLERİ TUTMAK İÇİN ArrayList OLUŞTURULUYOR

        double toplam = 0;  // KASİYER ÜRÜN TOPLAMLARI İÇİN DEĞİŞKEN OLUŞTURULUYOR
        char ayrac = ',';   // AYRAÇ İÇİN DEĞİŞKEN OLUŞTURULUYOR
        double toplamSatislar = 0;  // ALT TOPLAM İÇİN DEĞİŞKEN OLUŞTURULUYOR

        private void kasiyerProgrami_Load(object sender, EventArgs e)   // PROGRAM ÇALIŞTIĞINDA HATA ALMAMAK İÇİN BUTON VE ListBox BLOKELENİYOR
        {
            btnTemizle.Enabled = false;
            btnHesapla.Enabled = false;
            lstUrun.Enabled = false;
        }

        private void lstKasiyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            kasiyerler.Add(lstKasiyer.SelectedItem.ToString()); // ArrayList SEÇİLEN KASİYERLERİ KAYDEDİYOR
            lstUrun.Enabled = true;     // KASİYER SEÇİLDİKTEN SONRA ÜRÜN AKTİF HALE GELİYOR İLK SEÇİM KASİYER OLMASI İÇİN
            tarih.Add(dtTarih.Text);    // ArrayList SEÇİLEN TARİHİ KAYDEDİYOR
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = true;  // ÜRÜN DE SEÇİLDİKTEN SONRA BUTONLAR AKTİF HALE GETİRİLİYOR
            btnTemizle.Enabled = true;
            lstSatis.Items.Add(dtTarih.Text + "," + lstKasiyer.SelectedItem.ToString() + "," + lstUrun.SelectedItem.ToString()); // SATIŞ ListBox A SEÇİMLER GÖNDERİLİYOR
            lstIslemGecmisi.Items.Add(dtTarih.Text + ",\t" + lstKasiyer.SelectedItem.ToString() + ",\t" + lstUrun.SelectedItem.ToString()); // SEÇİMLERİ İŞLEM GEÇMİŞİNE EKLİYOR
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            btnTemizle.Enabled = false;     // TEMİZLE BUTONU BLOKELENİYOR
            dtTarih.Enabled = true;     // TARİH BLOKESİNİ KALDIRIYOR
            DateTime tarihl = DateTime.Now;     // BUGÜNÜN TARİHİNİ ALIR

            for (int j = 0; j < kasiyerler.Count; j++)  // KASİYELER DÖNÜYOR
            {
                toplam = 0;
                for (int i = 0; i < lstSatis.Items.Count; i++)  // KASİYERİN SEÇİLEN ÜRÜNLERİ VE TUTARLARI DÖNÜYOR
                {
                    string[] urunler = lstSatis.Items[i].ToString().Split(ayrac);   // AYRAÇ YARDIMI İLE (KASİYER-ÜRÜN-FİYAT) BÖLÜNÜYOR
                    if (kasiyerler[j].ToString() == urunler[1].ToString() && tarih[j].ToString() == urunler[0].ToString())      // KASİYER VE ÜRÜN EŞLEŞİYORSA - TARİH VE ÜRÜN EŞLEŞİYORSA
                    {
                        toplam += Convert.ToDouble(urunler[3]);     // AYRAÇ YARDIMIYLA BÖLÜNEN 3 DİZİ TOPLAMA EKLENİYOR
                        toplamSatislar += Convert.ToDouble(urunler[3]);     // AYRAÇ YARDIMIYLA BÖLÜNEN 3 DİZİ ALT TOPLAMA EKLENİYOR
                    }
                }
                lstIslemKaydi.Items.Add(tarih[j] + ",\t" + kasiyerler[j].ToString() + ",\t" + toplam.ToString()); //KASİYER VE SATIŞLARIN TOPLAMI YAZDIRILIYOR
            }

            lblSonuc.Text = toplamSatislar.ToString();  // ALT TOPLAM YAZDIRILIYOR
            kasiyerler.Clear();     // KASİYER ArrayList TEMİZLENİYOR
            tarih.Clear();      // TARİH ArrayList TEMİZLENİYOR
            lstSatis.Items.Clear();  // ListBox TEMİZLENİYOR
            btnHesapla.Enabled = false;     // HESAPLA BUTONU PASİFLEŞİYOR
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstSatis.Items.Clear(); // ListBox TEMİZLENİYOR
            kasiyerler.Clear();     // KASİYER ArrayList TEMİZLENİYOR
            btnTemizle.Enabled = false;     // TEMİZLE BUTONU PASİFLEŞİYOR
            btnHesapla.Enabled = false;     // HESAPLA BUTONU PASİFLEŞİYOR
        }
    }
}
