using System;
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
    public partial class kayitVeİslemler : Form
    {
        public kayitVeİslemler()
        {
            InitializeComponent();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            DialogResult diyalog = MessageBox.Show("Yeniden Değer Girmek İster Misiniz", "Kişi Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // DialogResult KULLANARAK NESNE TÜRETİYORUM

            richTextBox1.Clear();   // TextBox TEMİZLİYORUM
            string cinsiyetSecimi = ""; // CİNSİYETİ BELİRLEMEK İÇİN DEĞİŞKEN ATIYORUM

            if (rdbErkek.Checked == true)   // DEĞİŞKENİME SEÇİLİ CİNSİYETİ YAZDIRIYORUM
            {
                cinsiyetSecimi = "Erkek";
            }
            else if (rdbKadin.Checked == true)
            {
                cinsiyetSecimi = "Kadın";
            }
            richTextBox1.Text = txtAdi.Text + "\n" + txtSoyadi.Text + "\n" + cinsiyetSecimi + "\n" + mskDogumTarihi.Text + "\n" + mskTelefon.Text + "\n" + lstOgrenimDurumu.Text;  // YAZILAN DEĞERLERİ RichTextBox a YAZDIRIYORUM

            if (diyalog == DialogResult.Yes)    // SONRASINDA MessageBox la SEÇİM YAPTIRIYORUM
            {
                temizlemeVeBlokeleme();     // METODU ÇAĞIRIYOUM
            }
            else if (diyalog == DialogResult.No)
            {
                MessageBox.Show("Pogram Kapatılacaktır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);    // PROGRAMIN KAPATILACAĞINI SÖYLÜYORUM
                this.Close();   // ÇALIŞMAYI KAPATIYORUM
            }
        }

        private void temizlemeVeBlokeleme() // TEMİZLEME VE BLOKLAMA İÇİN METOT OLUŞTURUYORUM
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            mskTelefon.Clear();
            mskDogumTarihi.Clear();
            rdbErkek.Checked = false;
            rdbKadin.Checked = false;
            lstOgrenimDurumu.SelectedIndex = -1;    // ListBox SEÇİMİ SIFIRLIYORUM

            txtSoyadi.Enabled = false;
            mskTelefon.Enabled = false;
            mskDogumTarihi.Enabled = false;
            rdbErkek.Enabled = false;
            rdbKadin.Enabled = false;
            lstOgrenimDurumu.Enabled = false;
            btnYazdır.Enabled = false;
            btnTemizle.Enabled = false;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizlemeVeBlokeleme();     // METODU ÇAĞIRIYOUM
        }

        private void kayitVeİslemler_Load(object sender, EventArgs e)
        {
            temizlemeVeBlokeleme();     // METODU ÇAĞIRIYOUM 1. BÖLÜM İÇİN

            txtIkinciSayi.Enabled = false;
            lstIslemTuru.Enabled = false;
            btnHesapla.Enabled = false;
            btnTemizle2.Enabled = false;
            txtSonuc.Enabled = false;
            btnIslemYap.Enabled = false;
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            txtSoyadi.Enabled = true;
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            rdbErkek.Enabled = true;
            rdbKadin.Enabled = true;
        }

        private void rdbKadin_CheckedChanged(object sender, EventArgs e)
        {
            mskTelefon.Enabled = true;
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            mskTelefon.Enabled = true;
        }

        private void mskTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskDogumTarihi.Enabled = true;
        }

        private void mskDogumTarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lstOgrenimDurumu.Enabled = true;
        }

        private void lstOgrenimDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnYazdır.Enabled = true;
            btnTemizle.Enabled = true;
        }

        //////////////////////////////////////// İKİNCİ BÖLÜM KODLARI

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblAsalSayisi.Text = " ";
            btnIslemYap.Enabled = true;
            richTextBox2.Clear();   // RichTextBox TEMİZLİYORUM

            int sayi1 = Convert.ToInt32(txtIlkSayi.Text);   // YAZILAN DEĞERİ DEĞİŞKENE ATIYORUM
            int sayi2 = Convert.ToInt32(txtIkinciSayi.Text);    // YAZILAN DEĞERİ DEĞİŞKENE ATIYORUM
            int sonuc2 = 0; // SONUCU YAZDIRMAK İÇİN DEĞİŞKEN OLUŞTURUYORUM
            int asallar = 0;
            int asalSayisi = 0;

            if (lstIslemTuru.SelectedIndex == 2)    // İŞLEM TÜRÜNDE SEÇİLEN BÖLME İŞLEMİNİ YAPTIRIYORUM
            {
                sonuc2 = sayi1 / sayi2;     // YAPILAN İŞLEMİ DEĞİŞKENE ATIYORUM
            }
            if (lstIslemTuru.SelectedIndex == 0)    // İŞLEM TÜRÜNDE SEÇİLEN TOPLAMA İŞLEMİNİ YAPTIRIYORUM
            {
                sonuc2 = sayi1 + sayi2;     // YAPILAN İŞLEMİ DEĞİŞKENE ATIYORUM
            }
            if (lstIslemTuru.SelectedIndex == 1)    // İŞLEM TÜRÜNDE SEÇİLEN ÇIKARMA İŞLEMİNİ YAPTIRIYORUM
            {
                sonuc2 = sayi1 - sayi2;     // YAPILAN İŞLEMİ DEĞİŞKENE ATIYORUM
            }
            if (lstIslemTuru.SelectedIndex == 3)    // İŞLEM TÜRÜNDE SEÇİLEN ÇARPMA İŞLEMİNİ YAPTIRIYORUM
            {
                sonuc2 = sayi1 * sayi2;     // YAPILAN İŞLEMİ DEĞİŞKENE ATIYORUM
            }
            if (lstIslemTuru.SelectedIndex == 4)    // İŞLEM TÜRÜNDE SEÇİLEN **ASAL TOPLAMA** İŞLEMİNİ YAPTIRIYORUM
            {
                if (sayi1 <= 0) // EN KÜÇÜK ASAL SAYI 2 DEN BAŞLADIĞI İÇİN GİRİLEN DEĞER SIFIR İSE ONU 2 YE ÇEVİRİYORUM
                {
                    sayi1 = 2;
                }
                for (int i = sayi1; i <= sayi2; i++)    // GİRİLEN DEĞERDEN BAŞLAYIP GİRİLEN DEĞERE KADAR SAYDIRIYORUM
                {
                    bool kontrol = false;   // Boolean DEĞİŞKENİ OLUŞTURUYORUM

                    for (int j = 2; j < i; j++)     // ASAL SAYILAR 2 DEN BAŞLADIĞI İÇİN 2 DEN BAŞLATIP GİRİLEN DEĞERE KADAR SAYDIRIYORUM
                    {
                        if ((i % j) == 0)   // BÖLÜMÜNDEN KALAN 0 İSE
                        {
                            kontrol = true; // Boolean DEĞİŞKENİNİ DOĞRU DEĞERİNİ VERİYORUM
                            break;  // DÖNGÜDEN ÇIKIYORUM
                        }
                    }
                    if (kontrol == true) { }
                    else
                    {
                        sonuc2 += i;    // ASALLARI TOPLATIYORUM
                        asallar = i;    // ASALLARI YAZDIRMAK İÇİN DEĞERİ ATIYORUM HER SEFERNDE YENİ DEĞER İLE DEĞİŞİYOR
                        asalSayisi++;   // ASAL SAYI ADETİNİ TUTMAK VE SIRA NUMARASI İÇİN ARTTIRIYORUM
                        richTextBox2.Text = richTextBox2.Text + asalSayisi + ". " + asallar + "\n";     // RichTextBox ASALLARI SIRA NUMARASIYLA YAZDIRIYORUM
                    }
                }
                if (sonuc2 <= 0)    // ASAL SAYI OLUP OLMADIĞINI KONTROL EDİYORUM ONA GÖRE METİN YAZDIRIYORUM
                {
                    lblAsalSayisi.Text = "Asal sayı yoktur";
                }
                else
                {
                    lblAsalSayisi.Text = Convert.ToString(asalSayisi) + " " + "adet asal sayı vardır.";
                }
            }
            txtSonuc.Text = sonuc2.ToString();  // SONUÇ DEĞERİNİ YAZDIRIYORUM
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();   // RichTextBox TEMİZLİYORUM
            lblAsalSayisi.Text = " ";
            txtIlkSayi.Clear();
            txtIkinciSayi.Clear();
            lstIslemTuru.SelectedIndex = -1;
            txtSonuc.Clear();
            btnHesapla.Enabled = false;
            txtIkinciSayi.Enabled = false;
            lstIslemTuru.Enabled = false;
            btnTemizle2.Enabled = false;
            txtSonuc.Enabled = false;
            btnIslemYap.Enabled = false;

        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            lblAsalSayisi.Text = " ";
            richTextBox2.Clear();   // RichTextBox TEMİZLİYORUM
            txtIlkSayi.Text = txtSonuc.Text;
            txtIkinciSayi.Clear();
            lstIslemTuru.SelectedIndex = -1;
            btnHesapla.Enabled = false;
            txtSonuc.Clear();
        }

        private void txtIlkSayi_TextChanged(object sender, EventArgs e)
        {
            txtIkinciSayi.Enabled = true;
            btnTemizle2.Enabled = true;
        }

        private void txtIkinciSayi_TextChanged(object sender, EventArgs e)
        {
            lstIslemTuru.Enabled = true;
        }

        private void lstIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = true;
            btnTemizle2.Enabled = true;
        }
    }
}
