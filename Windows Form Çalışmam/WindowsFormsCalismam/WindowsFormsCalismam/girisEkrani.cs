using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsCalismam
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()    // YAPICI METOTLAR YANİ PROGRAM BAŞLADIĞI AN BAŞLATILMASINI İSTEDİĞİMİZ METOTLARDIR
        {
            InitializeComponent();
            kullaniciGiris();   // KAYITLI KULLANICI VARSA BİLGİLERİNİ DOLDURMA METODU
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // PROGRAMI KAPATMA
        }

        private void kullaniciGiris()  // EĞER KAYDEDİLEN KULLANICI VARSA O AYARLARI GETİRMEK İÇİN METOT OLUŞTURDUM
        {
            if (Properties.Settings.Default.kullaniciAdi != string.Empty)   // KULLANICI ADI BOŞ DEĞİLSE
            {
                if (Properties.Settings.Default.beniUnutma == true)     // PROPERTİES AYARLARI "DOĞRU" SEÇİLİ İSE
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;    // KAYDEDİLEN KULLANICI ADI
                    txtSifre.Text = Properties.Settings.Default.parola; // KAYDEDİLEN PAROLA
                    chcBeniHatirla.Checked = true;  // KAYDEDİLEN CHECKBOX
                }
                else
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;
                }
            }
        }

        private void kullaniciKaydet()  // KULLANICI GİRİŞİNİ PROPERTİES AYARLARINA KAYDETMEK İÇİN METOT OLUŞTURDUM
        {
            if (chcBeniHatirla.Checked) // CHECKBOX SEÇİLİ İSE
            {
                Properties.Settings.Default.kullaniciAdi = txtKullaniciAdi.Text;    // KULLANICI ADINI PROPERTİES AYARLARINA KAYDEDİYOR
                Properties.Settings.Default.parola = txtSifre.Text;     // PAROLAYI PROPERTİES AYARLARINA KAYDEDİYOR
                Properties.Settings.Default.beniUnutma = true;      // PROPERTİES AYARLARINI "DOĞRU" OLARAK KAYDEDİYOR 
                Properties.Settings.Default.Save();     // PROPERTİES AYARLARINI KAYDEDİYOR 
            }
            else    // CHECKBOX SEÇİLİ DEĞİL İSE ALANLARI BOŞ VE "YANLIŞ" OLARAK KAYDEDİYOR
            {
                Properties.Settings.Default.kullaniciAdi = "";
                Properties.Settings.Default.parola = "";
                Properties.Settings.Default.beniUnutma = false;
                Properties.Settings.Default.Save();
            }
        }
        int girisHakki = 3; // 3 GİRİŞ HAKKI VERİLDİ
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")  // KULLANICI ADI VEYA PAROLA BOŞ İSE
            {
                MessageBox.Show("Zorunlu Alanlar Boş Geçilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);   // KOŞUL SAĞLANAMADIĞINDA EKRANA YAZILACAK NOT
            }
            else
            {
                if (txtKullaniciAdi.Text == "Emrullah" && txtSifre.Text == "858852")    // KOŞULU BELİRTİYORUM VE KOŞUL SAĞLANIRSA İŞLEME DEVAM ET DİYORUM
                {
                    kullaniciKaydet();  //  METOTLA KULLANICI GİRİŞİNİ KAYDEDİYOR 
                    MessageBox.Show("Zoru hemen yaparız, imkansız ise biraz zaman alır.", "* UNUTMA *", MessageBoxButtons.OK, MessageBoxIcon.None);
                    programlar ac = new programlar();  // PROGRAMLAR EKRANINI AÇMAK İÇİN NESNE ÜRETİYOR
                    ac.Show();      // OLUŞTURULAN NESNEYİ AÇIYOR
                    this.Hide();    //AÇIK SAYFALARI GİZLER "this.Close();" DENİLDİĞİNDE PROGRAMI KAPATIYOR 
                }
                else    //KOŞUL SAĞLANMAZSA
                {
                    Properties.Settings.Default.kullaniciAdi = "";  // HATALI GİRİŞTE KULLANICI ADINI SİLİYORUM
                    Properties.Settings.Default.parola = "";    // HATALI GİRİŞTE PAROLAYI SİLİYORUM
                    Properties.Settings.Default.beniUnutma = false; // HATALI GİRİŞTE UNUTMA İŞARETİNİ KALDIRIYORUM
                    Properties.Settings.Default.Save();     // VE BU ŞEKİLDE KAYDEDİYORUM

                    girisHakki--;   // GİRİŞ HAKKININDAN 1 ÇIKARTIYORUM
                    lblGirisHakki.Text = girisHakki + " " + "Hakkınız Kaldı";   // LABEL A GİRİŞ HAKKINI YAZDIRIYORUM
                    if (girisHakki == 1)    // SON GİRİŞ HAKKI OLDUĞUNU UYARIYORUM
                    {
                        MessageBox.Show("Son Hakkınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (girisHakki == 0)   // 3 HATALI GİRİŞ OLDUĞUNU VE PROGRAMI KAPATIYORUM
                    {
                        MessageBox.Show("Program Kapatılıyor", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Giriş Başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning); // HER HATALI GİRİŞTE UYARI VERİYORUM
                    }
                    txtKullaniciAdi.Text = "";  // KULLANICI ADINI BOŞALTIYORUM
                    txtSifre.Text = "";     // PAROLA ALANINI BOŞALTIYORUM
                }
            }
        }

        private void girisEkrani_KeyDown(object sender, KeyEventArgs e) // EKRAN ÜSTÜNE TUŞ ATAMASI YAPTIM BUNUN İÇİN "KeyPreview TRUE" ÇEVİRDİM ve KeyDown ÖZELLİĞİNE AŞAĞIDAKİ KODLARI YAZDIM
        {
            if (e.KeyCode == Keys.Enter)    // ENTER TUŞUNA BASILIRSA
            {
                btnGiris.PerformClick();    // GİRİŞ BUTONUNA TIKLAMA YAPIYOR
            }
        }
    }
}