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
    public partial class gunesProgrami : Form
    {
        public gunesProgrami()
        {
            InitializeComponent();
        }

        private void gunesProgrami_Load(object sender, EventArgs e)
        {
            temizleSil();   // İLK AÇILDIĞINDA METODU ÇALIŞTIRIYORUM
        }

        private void btnHesapla2_Click(object sender, EventArgs e)
        {

            string[] girilenDegerler = { txtBaslangicHizi.Text, txtGunesBaslangicHizi.Text, txtGunesinCevresi.Text, txtGunesTur.Text };    // TextBox A YAZILAN DEĞERİ "girilenDegerler" DEĞİŞKENİNE ATIYORUM

            for (int i = 0; i < Convert.ToInt32(girilenDegerler.Length); i++)   // "girilenDegerler" UZUNLUĞU KADAR SAYDIRIYORUM
            {
                if (string.IsNullOrEmpty(girilenDegerler[i]))   // "girilenDegerler" BOŞ GEÇİLİYORSA
                {
                    girilenDegerler[i] = "0";   // "girilenDegerler" i Cİ DİZİSİNE "0" DEĞERİNİ ATIYORUM HATA ALMAMAK İÇİN
                }
            }

            string[] girilenDegerler1 = { txtGuneseUzaklik.Text,txtGuneseKadarArtis.Text,
            txtGirilenHiz.Text };    // TextBox A YAZILAN DEĞERİ "girilenDegerler" DEĞİŞKENİNE ATIYORUM

            for (int i = 0; i < Convert.ToInt32(girilenDegerler1.Length); i++)   // "girilenDegerler" UZUNLUĞU KADAR SAYDIRIYORUM
            {
                if (string.IsNullOrEmpty(girilenDegerler1[i]))   // "girilenDegerler" BOŞ GEÇİLİYORSA
                {
                    girilenDegerler1[i] = "1";   // "girilenDegerler" i Cİ DİZİSİNE "1" DEĞERİNİ ATIYORUM HATA ALMAMAK İÇİN
                }
            }

            int saat = 0;   // SAAT DEĞİŞKENİ OLUŞTURUYORUM
            int[] hiz = { Convert.ToInt32(girilenDegerler[0]), 0 }; 
            int mesafe = Convert.ToInt32(girilenDegerler[0]);
            int gidilenMesafe = 0;

            for (int i = 0; i <= Convert.ToInt32(girilenDegerler1[0]); i += mesafe) // GÜNEŞE KADAR GİDİLEN YOL HIZ VE SAAT
            {
                mesafe += Convert.ToInt32(girilenDegerler1[1]);
                saat++;
                hiz[1] += Convert.ToInt32(girilenDegerler1[1]);
                gidilenMesafe += mesafe;
            }
            lblGuneseKadarHiz.Text = Convert.ToString(hiz[1] + hiz[0]);
            lblKatedilenMesafe.Text = Convert.ToString(gidilenMesafe);

            if (rdbEvet.Checked == true)    // SABİT HIZ EVET İSE 
            {

                int hiz2 = hiz[0] + hiz[1];
                double katedilenYol = 0;
                for (double k = 0; k <= Convert.ToDouble(girilenDegerler1[0]) + (Convert.ToDouble(girilenDegerler[2]) * Convert.ToDouble(girilenDegerler[3])); k += hiz2)
                {
                    saat++;
                    katedilenYol += hiz2;
                }
                lblGunesVarisSonrasiHiz.Text = Convert.ToString(hiz2);
                lblGunesCevreDonusYolu.Text = Convert.ToString(katedilenYol);
            }
            else if (rdbHayir.Checked == true)  // SABİT HIZ HAYIR SEÇİLİR İSE GİRİLEN DEĞERLERE GÖRE FOR DÖNGÜSÜ OLUŞTURUYORUM
            {
                int baslangicHiziGunes = Convert.ToInt32(girilenDegerler[1]);
                int hiz3 = Convert.ToInt32(girilenDegerler1[2]) + baslangicHiziGunes;
                int hiz4 = 0;
                double katedilenYol = 0;
                for (double k = 0; k <= Convert.ToDouble(girilenDegerler1[0]) + (Convert.ToDouble(girilenDegerler[2]) * Convert.ToDouble(girilenDegerler[3])); k += hiz3)
                {
                    hiz4 += hiz3;
                    saat++;
                    katedilenYol += hiz3;
                }
                lblGunesVarisSonrasiHiz.Text = Convert.ToString(hiz4);
                lblGunesCevreDonusYolu.Text = Convert.ToString(katedilenYol);
            }
            lblSaat.Text = Convert.ToString(saat);
            lblSonuc.Text = Convert.ToString(saat / 24);
            double toplamMesafe = Convert.ToDouble(lblGunesCevreDonusYolu.Text) + Convert.ToDouble(lblKatedilenMesafe.Text);
            lblToplamYol.Text = Convert.ToString(toplamMesafe);
            btnTemizle.Enabled = true;
        }

        private void txtBaslangicHizi_TextChanged(object sender, EventArgs e)
        {
            txtGuneseUzaklik.Enabled = true;
        }

        private void txtGuneseUzaklik_TextChanged(object sender, EventArgs e)
        {
            txtGuneseKadarArtis.Enabled = true;
        }

        private void txtGuneseKadarArtis_TextChanged(object sender, EventArgs e)
        {
            rdbEvet.Enabled = true;
            rdbHayir.Enabled = true;
        }

        private void rdbHayir_CheckedChanged(object sender, EventArgs e)
        {
            txtGunesBaslangicHizi.Enabled = true;
            txtGunesinCevresi.Enabled = false;
        }

        private void rdbEvet_CheckedChanged(object sender, EventArgs e)
        {
            txtGunesBaslangicHizi.Text = "";
            txtGirilenHiz.Text = "";

            txtGunesBaslangicHizi.Enabled = false;
            txtGirilenHiz.Enabled = false;
            txtGunesinCevresi.Enabled = true;
        }

        private void txtGunesinCevresi_TextChanged(object sender, EventArgs e)
        {
            txtGunesTur.Enabled = true;
        }

        private void txtGunesTur_TextChanged(object sender, EventArgs e)
        {
            btnHesapla2.Enabled = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizleSil();
        }

        private void temizleSil()   // TEMİZLEME VE BLOKLAMA İÇİN METOT OLUŞTURUYORUM
        {
            txtBaslangicHizi.Text = "";
            txtGuneseUzaklik.Text = "";
            txtGuneseKadarArtis.Text = "";
            txtGunesBaslangicHizi.Text = "";
            txtGirilenHiz.Text = "";
            txtGunesTur.Text = "";
            txtGunesinCevresi.Text = "";
            lblGuneseKadarHiz.Text = "0";
            lblKatedilenMesafe.Text = "0";
            lblGunesVarisSonrasiHiz.Text = "0";
            lblGunesCevreDonusYolu.Text = "0";
            lblSonuc.Text = "0";
            lblToplamYol.Text = "0";
            lblSaat.Text = "0";

            rdbEvet.Checked = false;
            rdbHayir.Checked = false;
            txtGuneseUzaklik.Enabled = false;
            txtGuneseKadarArtis.Enabled = false;
            txtGunesBaslangicHizi.Enabled = false;
            txtGirilenHiz.Enabled = false;
            txtGunesTur.Enabled = false;
            txtGunesinCevresi.Enabled = false;
            btnHesapla2.Enabled = false;
            btnTemizle.Enabled = false;
            rdbEvet.Enabled = false;
            rdbHayir.Enabled = false;
        }

        private void txtGunesBaslangicHizi_TextChanged(object sender, EventArgs e)
        {
            txtGirilenHiz.Enabled = true;
        }

        private void txtGirilenHiz_TextChanged(object sender, EventArgs e)
        {
            txtGunesinCevresi.Enabled = true;
        }
    }
}
