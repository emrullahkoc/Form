namespace WindowsFormsCalismam
{
    partial class kayitVeİslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitVeİslemler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.lstOgrenimDurumu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.rtxtBirinciBolum = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lstIslemTuru = new System.Windows.Forms.ComboBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.txtIlkSayi = new System.Windows.Forms.TextBox();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAsalSayisi = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.rdbErkek);
            this.groupBox1.Controls.Add(this.rdbKadin);
            this.groupBox1.Controls.Add(this.lstOgrenimDurumu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mskDogumTarihi);
            this.groupBox1.Controls.Add(this.mskTelefon);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.btnYazdır);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Font = new System.Drawing.Font("Krona One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri Kayıt";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(355, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 265);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbErkek.Location = new System.Drawing.Point(271, 114);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(69, 20);
            this.rdbErkek.TabIndex = 3;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            this.rdbErkek.CheckedChanged += new System.EventHandler(this.rdbErkek_CheckedChanged);
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKadin.Location = new System.Drawing.Point(196, 114);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(69, 20);
            this.rdbKadin.TabIndex = 2;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            this.rdbKadin.CheckedChanged += new System.EventHandler(this.rdbKadin_CheckedChanged);
            // 
            // lstOgrenimDurumu
            // 
            this.lstOgrenimDurumu.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOgrenimDurumu.FormattingEnabled = true;
            this.lstOgrenimDurumu.Items.AddRange(new object[] {
            "İlkokul",
            "Ortaokul",
            "Lise ",
            "Ön Lisans",
            "Lisans",
            "Doktora"});
            this.lstOgrenimDurumu.Location = new System.Drawing.Point(196, 217);
            this.lstOgrenimDurumu.Name = "lstOgrenimDurumu";
            this.lstOgrenimDurumu.Size = new System.Drawing.Size(144, 24);
            this.lstOgrenimDurumu.TabIndex = 6;
            this.lstOgrenimDurumu.SelectedIndexChanged += new System.EventHandler(this.lstOgrenimDurumu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Öğrenim Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cinsiyet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Soyadınız";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(11, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Adınız";
            // 
            // mskDogumTarihi
            // 
            this.mskDogumTarihi.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogumTarihi.Location = new System.Drawing.Point(196, 182);
            this.mskDogumTarihi.Mask = "00/00/0000";
            this.mskDogumTarihi.Name = "mskDogumTarihi";
            this.mskDogumTarihi.Size = new System.Drawing.Size(144, 22);
            this.mskDogumTarihi.TabIndex = 5;
            this.mskDogumTarihi.ValidatingType = typeof(System.DateTime);
            this.mskDogumTarihi.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDogumTarihi_MaskInputRejected);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(196, 147);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(144, 22);
            this.mskTelefon.TabIndex = 4;
            this.mskTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefon_MaskInputRejected);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(196, 79);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(144, 22);
            this.txtSoyadi.TabIndex = 1;
            this.txtSoyadi.TextChanged += new System.EventHandler(this.txtSoyadi_TextChanged);
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(196, 44);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(144, 22);
            this.txtAdi.TabIndex = 0;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYazdır.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazdır.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnYazdır.Location = new System.Drawing.Point(11, 265);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(144, 42);
            this.btnYazdır.TabIndex = 7;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = false;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.IndianRed;
            this.btnTemizle.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTemizle.Location = new System.Drawing.Point(196, 265);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(144, 42);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rtxtBirinciBolum
            // 
            this.rtxtBirinciBolum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtxtBirinciBolum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtBirinciBolum.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtBirinciBolum.Location = new System.Drawing.Point(684, 23);
            this.rtxtBirinciBolum.Name = "rtxtBirinciBolum";
            this.rtxtBirinciBolum.Size = new System.Drawing.Size(584, 311);
            this.rtxtBirinciBolum.TabIndex = 1;
            this.rtxtBirinciBolum.Text = resources.GetString("rtxtBirinciBolum.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblAsalSayisi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnIslemYap);
            this.groupBox2.Controls.Add(this.txtIlkSayi);
            this.groupBox2.Controls.Add(this.txtIkinciSayi);
            this.groupBox2.Controls.Add(this.txtSonuc);
            this.groupBox2.Controls.Add(this.lstIslemTuru);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.btnTemizle2);
            this.groupBox2.Font = new System.Drawing.Font("Krona One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Bilgileri Kayıt";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Plum;
            this.richTextBox2.Font = new System.Drawing.Font("Krona One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox2.Location = new System.Drawing.Point(355, 42);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(296, 257);
            this.richTextBox2.TabIndex = 43;
            this.richTextBox2.Text = "";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHesapla.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHesapla.Location = new System.Drawing.Point(21, 152);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(144, 42);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.BackColor = System.Drawing.Color.IndianRed;
            this.btnTemizle2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTemizle2.Location = new System.Drawing.Point(196, 152);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(144, 42);
            this.btnTemizle2.TabIndex = 4;
            this.btnTemizle2.Text = "Temizle";
            this.btnTemizle2.UseVisualStyleBackColor = false;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(21, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "İşlem Türü";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(21, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "İkinci Sayı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(22, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "İlk Sayı";
            // 
            // lstIslemTuru
            // 
            this.lstIslemTuru.Font = new System.Drawing.Font("Krona One", 9F);
            this.lstIslemTuru.FormattingEnabled = true;
            this.lstIslemTuru.Items.AddRange(new object[] {
            "TOPLAMA",
            "ÇIKARMA",
            "BÖLME",
            "ÇARPMA",
            "ASAL TOPLA"});
            this.lstIslemTuru.Location = new System.Drawing.Point(196, 106);
            this.lstIslemTuru.Name = "lstIslemTuru";
            this.lstIslemTuru.Size = new System.Drawing.Size(144, 24);
            this.lstIslemTuru.TabIndex = 2;
            this.lstIslemTuru.SelectedIndexChanged += new System.EventHandler(this.lstIslemTuru_SelectedIndexChanged);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Krona One", 9F);
            this.txtSonuc.Location = new System.Drawing.Point(21, 252);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(319, 22);
            this.txtSonuc.TabIndex = 48;
            // 
            // txtIlkSayi
            // 
            this.txtIlkSayi.Font = new System.Drawing.Font("Krona One", 9F);
            this.txtIlkSayi.Location = new System.Drawing.Point(196, 44);
            this.txtIlkSayi.Name = "txtIlkSayi";
            this.txtIlkSayi.Size = new System.Drawing.Size(144, 22);
            this.txtIlkSayi.TabIndex = 0;
            this.txtIlkSayi.TextChanged += new System.EventHandler(this.txtIlkSayi_TextChanged);
            // 
            // txtIkinciSayi
            // 
            this.txtIkinciSayi.Font = new System.Drawing.Font("Krona One", 9F);
            this.txtIkinciSayi.Location = new System.Drawing.Point(196, 75);
            this.txtIkinciSayi.Name = "txtIkinciSayi";
            this.txtIkinciSayi.Size = new System.Drawing.Size(144, 22);
            this.txtIkinciSayi.TabIndex = 1;
            this.txtIkinciSayi.TextChanged += new System.EventHandler(this.txtIkinciSayi_TextChanged);
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIslemYap.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIslemYap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIslemYap.Location = new System.Drawing.Point(21, 292);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(319, 42);
            this.btnIslemYap.TabIndex = 5;
            this.btnIslemYap.Text = "ÇIKAN SONUÇLA ISLEM YAP";
            this.btnIslemYap.UseVisualStyleBackColor = false;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Sonuç";
            // 
            // lblAsalSayisi
            // 
            this.lblAsalSayisi.AutoSize = true;
            this.lblAsalSayisi.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAsalSayisi.Location = new System.Drawing.Point(359, 314);
            this.lblAsalSayisi.Name = "lblAsalSayisi";
            this.lblAsalSayisi.Size = new System.Drawing.Size(0, 17);
            this.lblAsalSayisi.TabIndex = 53;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.Violet;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox3.Location = new System.Drawing.Point(684, 363);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(584, 345);
            this.richTextBox3.TabIndex = 45;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // kayitVeİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsCalismam.Properties.Resources.ArkaPlan;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtxtBirinciBolum);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kayitVeİslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayıtVeİslemler";
            this.Load += new System.EventHandler(this.kayitVeİslemler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.ComboBox lstOgrenimDurumu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rtxtBirinciBolum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle2;
        private System.Windows.Forms.TextBox txtIlkSayi;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.ComboBox lstIslemTuru;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAsalSayisi;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}