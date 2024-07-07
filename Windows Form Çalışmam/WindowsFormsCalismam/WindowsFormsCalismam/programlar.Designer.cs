namespace WindowsFormsCalismam
{
    partial class programlar
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.pnlMenü = new System.Windows.Forms.Panel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnGunes = new System.Windows.Forms.Button();
            this.btnKasiyer = new System.Windows.Forms.Button();
            this.btnHavuz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMenü.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.DarkRed;
            this.btnKapat.Font = new System.Drawing.Font("Krona One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKapat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKapat.Location = new System.Drawing.Point(12, 703);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(145, 35);
            this.btnKapat.TabIndex = 29;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // pnlMenü
            // 
            this.pnlMenü.BackgroundImage = global::WindowsFormsCalismam.Properties.Resources.ArkaPlan;
            this.pnlMenü.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenü.Controls.Add(this.button1);
            this.pnlMenü.Controls.Add(this.btnGiris);
            this.pnlMenü.Controls.Add(this.btnGunes);
            this.pnlMenü.Controls.Add(this.btnKasiyer);
            this.pnlMenü.Controls.Add(this.btnHavuz);
            this.pnlMenü.Controls.Add(this.btnKapat);
            this.pnlMenü.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenü.Location = new System.Drawing.Point(0, 0);
            this.pnlMenü.Name = "pnlMenü";
            this.pnlMenü.Size = new System.Drawing.Size(170, 750);
            this.pnlMenü.TabIndex = 31;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGiris.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGiris.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGiris.Location = new System.Drawing.Point(12, 127);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(145, 43);
            this.btnGiris.TabIndex = 33;
            this.btnGiris.Text = "Giriş Ekran Kodları";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnGunes
            // 
            this.btnGunes.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGunes.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGunes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGunes.Location = new System.Drawing.Point(12, 78);
            this.btnGunes.Name = "btnGunes";
            this.btnGunes.Size = new System.Drawing.Size(145, 43);
            this.btnGunes.TabIndex = 32;
            this.btnGunes.Text = "Güneş Hesap Programı";
            this.btnGunes.UseVisualStyleBackColor = false;
            this.btnGunes.Click += new System.EventHandler(this.btnGunes_Click);
            // 
            // btnKasiyer
            // 
            this.btnKasiyer.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKasiyer.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyer.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnKasiyer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKasiyer.Location = new System.Drawing.Point(12, 45);
            this.btnKasiyer.Name = "btnKasiyer";
            this.btnKasiyer.Size = new System.Drawing.Size(145, 27);
            this.btnKasiyer.TabIndex = 31;
            this.btnKasiyer.Text = "Kasiyer Programı";
            this.btnKasiyer.UseVisualStyleBackColor = false;
            this.btnKasiyer.Click += new System.EventHandler(this.btnKasiyer_Click);
            // 
            // btnHavuz
            // 
            this.btnHavuz.BackColor = System.Drawing.Color.YellowGreen;
            this.btnHavuz.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavuz.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnHavuz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHavuz.Location = new System.Drawing.Point(12, 12);
            this.btnHavuz.Name = "btnHavuz";
            this.btnHavuz.Size = new System.Drawing.Size(145, 27);
            this.btnHavuz.TabIndex = 30;
            this.btnHavuz.Text = "Havuz Programı";
            this.btnHavuz.UseVisualStyleBackColor = false;
            this.btnHavuz.Click += new System.EventHandler(this.btnHavuz_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Krona One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(12, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 57);
            this.button1.TabIndex = 34;
            this.button1.Text = "KAYIT ve HESAPLAMA PROGRAMI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // programlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsCalismam.Properties.Resources.ArkaPlan;
            this.ClientSize = new System.Drawing.Size(1500, 750);
            this.Controls.Add(this.pnlMenü);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "programlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "programlar";
            this.pnlMenü.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Panel pnlMenü;
        private System.Windows.Forms.Button btnHavuz;
        private System.Windows.Forms.Button btnKasiyer;
        private System.Windows.Forms.Button btnGunes;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button button1;
    }
}