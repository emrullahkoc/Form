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
    public partial class havuzProgrami : Form
    {
        public havuzProgrami()
        {
            InitializeComponent();
        }
            // BİRİNCİ KISIM
        int[] toplam = { 0 };   // TOPLAMI YAZDIRMAK İÇİN DIŞARIDA TUTUYORUM
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int[] musluklar = { 200, 100, 150 };    // MUSLUKLARA DEĞERLERİ VERİYORUM
            lblSonuc.Text = Convert.ToString(sonuc(musluklar)[0]) + ". " + "Saatte Doldu";  // METOTDAN GELEN "SAYAÇ" DEĞERİNİ YAZDIRIYORUM
            lblTasan.Text = Convert.ToString((toplam[0]) - 100000) + " " + "Litre Taştı";   // TOPLAMDAN ÇIKIYORUM (TAŞMA OLDUĞU İÇİN)
            lblDolan.Text = Convert.ToString(toplam[0]) + " " + "Litre Doldu";  // KAÇ LİTRE DOLDUĞUNU YAZDIRIYORUM
            btnHesapla.Enabled = false; // HESAPLA BUTONUNU PASİF HALE GETİRİYORUM TEK SEFERLİK İŞLEM OLDUĞU İÇİN
        }
        private int[] sonuc(int[] musluk)   //SAATİ HESAPLAMAK İÇİN DİZİ PARAMETRELİ METOT OLUŞTURUYORUM
        {
            int[] sayac = { 0 };    // SAAT İÇİN SAYAÇ DEĞİŞKENİ OLUŞTURUYORUM
            for (int i = 0; i < 1000; i++)  // 1000 E KADAR SAYDIRIYORUM
            {
                if (toplam[0] < 100000) // TOPLAM 1000 DEN KÜÇÜK MÜ DİYE KONTROL EDİYORUM
                {
                    sayac[0]++;     // SAYAÇ 1 ARTTIRIYORUM
                    toplam[0] += musluk[0] + musluk[1] - musluk[2];     // TOPLAMA VE ÇIKARMA İŞLEMİNİ DEĞİŞKENE ATIYORUM
                }
            }
            return sayac;   // SAYAÇ DEĞERİNİ DİZİ OLARAK DIŞARI ÇIKARIYORUM
        }
        // İKİNCİ KISIM KODLARI

        int[] alan = { 0 }; // DİZİYE ALAN DEĞERİ ATIYORUM
        int[] toplam2 = { 0 };  // DİZİYE TOPLAM DEĞERİ ATIYORUM
        int[] sayac2 = { 0 };   // DİZİYE SAYAÇ DEĞERİ ATIYORUM
        int[] musluklar = new int[6];   // 6 DİZİDEN OLUŞACAK DEĞİŞKEN OLUŞTURUYORUM

        private void btnHesapla2_Click(object sender, EventArgs e)
        {
            alan[0] = Convert.ToInt32(txtAlan.Text);    // TextBox A YAZILAN DEĞERİ ALAN DEĞİŞKENİNE ATIYORUM

            string[] girilenDegerler = { txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text };    // TextBox A YAZILAN DEĞERİ "girilenDegerler" DEĞİŞKENİNE ATIYORUM

            for (int i = 0; i < Convert.ToInt32(girilenDegerler.Length); i++)   // "girilenDegerler" UZUNLUĞU KADAR SAYDIRIYORUM
            {
                if (string.IsNullOrEmpty(girilenDegerler[i]))   // "girilenDegerler" BOŞ GEÇİLİYORSA
                {
                    girilenDegerler[i] = "0";   // "girilenDegerler" i Cİ DEĞERİNE "0" DEĞERİNİ ATIYORUM HATA ALMAMAK İÇİN
                }
            }

            musluklar[0] = Convert.ToInt32(girilenDegerler[0]); // "musluklar" DİZİSİNE DEĞERLERİ ATIYORUM
            musluklar[1] = Convert.ToInt32(girilenDegerler[1]);
            musluklar[2] = Convert.ToInt32(girilenDegerler[2]);
            musluklar[3] = Convert.ToInt32(girilenDegerler[3]);
            musluklar[4] = Convert.ToInt32(girilenDegerler[4]);
            musluklar[5] = Convert.ToInt32(girilenDegerler[5]);

            lblSonuc2.Text = Convert.ToString(degiskenSonuc(musluklar)[0] + ". " + "Saatte Doldu");     // METOTDAN GELEN DEĞERİ YAZDIRIYORUM
            lblDolan2.Text = Convert.ToString(toplam2[0]) + " " + "Litre Doldu";    // TOPLAMI YAZDIRIYORUM

            if (toplam2[0] > alan[0])   // TOPLAM ALANDAN BÜYÜK İSE
            {
                lblTasan2.Text = Convert.ToString(toplam2[0] - alan[0]) + " " + "Litre Taştı";  // TAŞAN LİTREYİ YAZDIRIYORUM
            }
            else if (toplam2[0] == alan[0])     // TOPLAM ile ALAN EŞİT İSE
            {
                lblTasan2.Text = "Tam Doldu";
            }
            if (toplam2[0] <= 0) // TOPLAM 0 EŞİT VEYA KÜÇÜK İSE
            {
                lblSonuc2.Text = "DOLUM YAPILAMADI";
                lblTasan2.Text = " ";   // LABEL SİLİYORUM
                lblDolan2.Text = " ";   // LABEL SİLİYORUM
            }

            btnHesapla2.Enabled = false;    // HESAPLAYA 2. DEFA BASMASINI ENGELLİYORUM
            blokeTextBox(); // TextBox BLOKE METODUNU ÇAĞIRIYORUM

            txtAlan.Enabled = false;
            btnTemizle.Enabled = true;  // TEMİZLE BUTONUNU AKTİFLEŞTİRİYORUM Kİ BAŞTAN GİRİŞ YAPABİLSİN HATA ALMASIN
        }

        private void blokeTextBox() //TextBox LARI BLOKELEMEK İÇİN METOT OLUŞTURUYORUM
        {
            txt1.Enabled = false;   //TextBox LARI BLOKLUYORUM
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            txt6.Enabled = false;
        }

        private int[] degiskenSonuc(int[] degisken)     // SAATİ HESAPLAMAK İÇİN DİZİ PARAMETRELİ METOT OLUŞTURUYORUM
        {
            for (int i = 0; i < alan[0]; i++)   // GİRİLEN ALAN KADAR SAYDIRIYORUM
            {
                if (toplam2[0] < alan[0])   // EĞER TOPLAM KÜÇÜKSE ALANDAN 
                {
                    toplam2[0] += degisken[0] + degisken[1] + degisken[2] - degisken[3] - degisken[4] - degisken[5];    // TOPLAMA VE ÇIKARMA İŞLEMİNİ DEĞİŞKENE ATIYORUM
                    sayac2[0]++;    // SAYACI 1 ARTTIRIYORUM
                }
            }
            return sayac2;  // SAYAÇ DEĞERİNİ DİZİ OLARAK DIŞARI ÇIKARIYORUM 
        }

        private void txtAlan_TextChanged(object sender, EventArgs e)    // ALAN DEĞERİNE GİRİŞ YAPILDIĞINDA
        {
            txt1.Enabled = true;    // TextBox DOLUM YAPAN MUSLUK 1 AÇIYORUM
            txt4.Enabled = true;    // TextBox BOŞALTIM YAPAN MUSLUK 1 AÇIYORUM
        }

        private void btnTemizle_Click(object sender, EventArgs e)   
        {
            txt1.Text = "";     // TextBox LARA BOŞ DEĞER ATAMASI YAPIYORUM
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txtAlan.Text = "";
            alan[0] = 0;        // DİZİ DEĞİŞKENLERİNİ SIFIRLIYORUM
            toplam2[0] = 0;
            sayac2[0] = 0;
            blokeTextBox();     // TextBox BLOKE METODUNU ÇAĞIRIYORUM
            btnHesapla2.Enabled = false;
            txtAlan.Enabled = true;
            btnTemizle.Enabled = false;
        }

        private void havuzProgrami_Load(object sender, EventArgs e)     // AÇILIŞTA OLACAK İŞLEMLERİ YAZIYORUM
        {
            blokeTextBox();     // TextBox BLOKE METODUNU ÇAĞIRIYORUM
            btnHesapla2.Enabled = false;    // BUTONLARI PASİF YAPIYORUM Kİ DEĞER GİRMEDEN BOŞA BASAMASIN
            btnTemizle.Enabled = false;
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            txt2.Enabled = true;    // TextBox LARI SIRAYLA AÇTIRIYORUM
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {
            txt3.Enabled = true;    // TextBox LARI SIRAYLA AÇTIRIYORUM
        }
        private void txt4_TextChanged(object sender, EventArgs e)
        {
            txt5.Enabled = true;    
            btnHesapla2.Enabled = true;     // BOŞALAN MUSLUKTA GİRİLDİKTEN SONRA HESAPLAMA BUTONU AKTİF HALE GETİRİYORUM
        }
        private void txt5_TextChanged(object sender, EventArgs e)
        {
            txt6.Enabled = true;    // TextBox LARI SIRAYLA AÇTIRIYORUM
        }
    }
}
