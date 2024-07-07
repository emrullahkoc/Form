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
    public partial class programlar : Form
    {
        public programlar()
        {
            InitializeComponent();
        }
        private void programAc(Form ac) // FORMLARI AÇMAK İÇİN METOT OLUŞTURUYORUM
        {
            this.SuspendLayout();   // TAM OLARAK NE İŞE YARADIĞINI BİLMİYORUM
            ac.MdiParent = this;    // 
            ac.Show();  // METODU AÇIYORUM
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHavuz_Click(object sender, EventArgs e)
        {
            havuzProgrami hvz = new havuzProgrami();    // NESNE TÜRETİYORUM
            programAc(hvz);     // METODU ÇAĞIRIYORUM VE METOT YARDIMIYLA AÇIYORUM
        }

        private void btnKasiyer_Click(object sender, EventArgs e)
        {
            kasiyerProgrami ksy=new kasiyerProgrami();
            programAc(ksy);
        }

        private void btnGunes_Click(object sender, EventArgs e)
        {
            gunesProgrami gns = new gunesProgrami();
            programAc(gns);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            girisEkranKod grs = new girisEkranKod();
            programAc(grs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitVeİslemler kyt = new kayitVeİslemler();
            programAc(kyt);
        }
    }
}
