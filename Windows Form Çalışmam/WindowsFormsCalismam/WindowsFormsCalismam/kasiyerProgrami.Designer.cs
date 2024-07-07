namespace WindowsFormsCalismam
{
    partial class kasiyerProgrami
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasiyerProgrami));
            this.label6 = new System.Windows.Forms.Label();
            this.lstIslemGecmisi = new System.Windows.Forms.ListBox();
            this.rtxbYazilanKodlar = new System.Windows.Forms.RichTextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstIslemKaydi = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSatis = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.lstKasiyer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(476, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "İŞLEM GEÇMİŞİ";
            // 
            // lstIslemGecmisi
            // 
            this.lstIslemGecmisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.lstIslemGecmisi.FormattingEnabled = true;
            this.lstIslemGecmisi.ItemHeight = 18;
            this.lstIslemGecmisi.Location = new System.Drawing.Point(369, 370);
            this.lstIslemGecmisi.Name = "lstIslemGecmisi";
            this.lstIslemGecmisi.Size = new System.Drawing.Size(332, 310);
            this.lstIslemGecmisi.TabIndex = 47;
            // 
            // rtxbYazilanKodlar
            // 
            this.rtxbYazilanKodlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbYazilanKodlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtxbYazilanKodlar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxbYazilanKodlar.Location = new System.Drawing.Point(719, 0);
            this.rtxbYazilanKodlar.Name = "rtxbYazilanKodlar";
            this.rtxbYazilanKodlar.Size = new System.Drawing.Size(561, 720);
            this.rtxbYazilanKodlar.TabIndex = 46;
            this.rtxbYazilanKodlar.Text = resources.GetString("rtxbYazilanKodlar.Text");
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSonuc.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSonuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSonuc.Location = new System.Drawing.Point(124, 692);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(17, 19);
            this.lblSonuc.TabIndex = 44;
            this.lblSonuc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(14, 692);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Toplam Satış :";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.IndianRed;
            this.btnTemizle.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.btnTemizle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTemizle.Location = new System.Drawing.Point(231, 262);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(196, 50);
            this.btnTemizle.TabIndex = 42;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.GreenYellow;
            this.btnHesapla.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.btnHesapla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHesapla.Location = new System.Drawing.Point(14, 262);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(196, 50);
            this.btnHesapla.TabIndex = 41;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lstIslemKaydi
            // 
            this.lstIslemKaydi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.lstIslemKaydi.FormattingEnabled = true;
            this.lstIslemKaydi.ItemHeight = 18;
            this.lstIslemKaydi.Location = new System.Drawing.Point(14, 370);
            this.lstIslemKaydi.Name = "lstIslemKaydi";
            this.lstIslemKaydi.Size = new System.Drawing.Size(348, 310);
            this.lstIslemKaydi.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(124, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "İŞLEM KAYDI";
            // 
            // lstSatis
            // 
            this.lstSatis.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lstSatis.FormattingEnabled = true;
            this.lstSatis.ItemHeight = 17;
            this.lstSatis.Location = new System.Drawing.Point(448, 113);
            this.lstSatis.Name = "lstSatis";
            this.lstSatis.Size = new System.Drawing.Size(253, 140);
            this.lstSatis.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(448, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Satılan Ürünler";
            // 
            // lstUrun
            // 
            this.lstUrun.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.ItemHeight = 17;
            this.lstUrun.Items.AddRange(new object[] {
            "Sigara\t,50",
            "Su\t,10",
            "Çikolata\t,15",
            "Kola\t,25",
            "Tost\t,55",
            "K.Tost\t,35"});
            this.lstUrun.Location = new System.Drawing.Point(231, 113);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(196, 140);
            this.lstUrun.TabIndex = 36;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(231, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ürünler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "TARİH";
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(14, 39);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(2);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(196, 29);
            this.dtTarih.TabIndex = 33;
            // 
            // lstKasiyer
            // 
            this.lstKasiyer.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lstKasiyer.FormattingEnabled = true;
            this.lstKasiyer.ItemHeight = 17;
            this.lstKasiyer.Items.AddRange(new object[] {
            "Emrullah",
            "Deniz",
            "Eray",
            "Berke",
            "Ömer",
            "Ahmet",
            "Mehmet"});
            this.lstKasiyer.Location = new System.Drawing.Point(14, 113);
            this.lstKasiyer.Name = "lstKasiyer";
            this.lstKasiyer.Size = new System.Drawing.Size(196, 140);
            this.lstKasiyer.TabIndex = 32;
            this.lstKasiyer.SelectedIndexChanged += new System.EventHandler(this.lstKasiyer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kasiyerler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(345, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 38);
            this.label8.TabIndex = 52;
            this.label8.Text = "**Önemli Not\nTarih seçimi yapıldığında KASİYER tekrar seçilmeli";
            // 
            // kasiyerProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsCalismam.Properties.Resources.ArkaPlan;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstIslemGecmisi);
            this.Controls.Add(this.rtxbYazilanKodlar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lstIslemKaydi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.lstKasiyer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kasiyerProgrami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kasiyerProgrami";
            this.Load += new System.EventHandler(this.kasiyerProgrami_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstIslemGecmisi;
        private System.Windows.Forms.RichTextBox rtxbYazilanKodlar;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lstIslemKaydi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ListBox lstKasiyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}