namespace Anaokulu_Otomasyon
{
    partial class FrmOgrenci
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
            this.grpOgrenciEkle = new System.Windows.Forms.GroupBox();
            this.btnogrencisil = new System.Windows.Forms.Button();
            this.cmbdonem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtkayit = new System.Windows.Forms.DateTimePicker();
            this.btnogrguncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnogrekle = new System.Windows.Forms.Button();
            this.cmbsinif = new System.Windows.Forms.ComboBox();
            this.cmbcins = new System.Windows.Forms.ComboBox();
            this.dtOgr = new System.Windows.Forms.DateTimePicker();
            this.txtOgrTC = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOgrenciAra = new System.Windows.Forms.GroupBox();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridogrlistele = new System.Windows.Forms.DataGridView();
            this.txtograra = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.grpOgrenciEkle.SuspendLayout();
            this.grpOgrenciAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridogrlistele)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOgrenciEkle
            // 
            this.grpOgrenciEkle.Controls.Add(this.btnogrencisil);
            this.grpOgrenciEkle.Controls.Add(this.cmbdonem);
            this.grpOgrenciEkle.Controls.Add(this.label13);
            this.grpOgrenciEkle.Controls.Add(this.dtkayit);
            this.grpOgrenciEkle.Controls.Add(this.btnogrguncelle);
            this.grpOgrenciEkle.Controls.Add(this.label7);
            this.grpOgrenciEkle.Controls.Add(this.btnogrekle);
            this.grpOgrenciEkle.Controls.Add(this.cmbsinif);
            this.grpOgrenciEkle.Controls.Add(this.cmbcins);
            this.grpOgrenciEkle.Controls.Add(this.dtOgr);
            this.grpOgrenciEkle.Controls.Add(this.txtOgrTC);
            this.grpOgrenciEkle.Controls.Add(this.txtOgrAd);
            this.grpOgrenciEkle.Controls.Add(this.label6);
            this.grpOgrenciEkle.Controls.Add(this.label5);
            this.grpOgrenciEkle.Controls.Add(this.label4);
            this.grpOgrenciEkle.Controls.Add(this.label3);
            this.grpOgrenciEkle.Controls.Add(this.label1);
            this.grpOgrenciEkle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgrenciEkle.Location = new System.Drawing.Point(1, 2);
            this.grpOgrenciEkle.Name = "grpOgrenciEkle";
            this.grpOgrenciEkle.Size = new System.Drawing.Size(407, 398);
            this.grpOgrenciEkle.TabIndex = 0;
            this.grpOgrenciEkle.TabStop = false;
            this.grpOgrenciEkle.Text = "Öğrenci İşlemleri";
            // 
            // btnogrencisil
            // 
            this.btnogrencisil.BackColor = System.Drawing.Color.IndianRed;
            this.btnogrencisil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnogrencisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnogrencisil.Location = new System.Drawing.Point(282, 327);
            this.btnogrencisil.Name = "btnogrencisil";
            this.btnogrencisil.Size = new System.Drawing.Size(117, 42);
            this.btnogrencisil.TabIndex = 25;
            this.btnogrencisil.Text = "SİL";
            this.btnogrencisil.UseVisualStyleBackColor = false;
            this.btnogrencisil.Click += new System.EventHandler(this.btnogrencisil_Click);
            // 
            // cmbdonem
            // 
            this.cmbdonem.FormattingEnabled = true;
            this.cmbdonem.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cmbdonem.Location = new System.Drawing.Point(115, 271);
            this.cmbdonem.Name = "cmbdonem";
            this.cmbdonem.Size = new System.Drawing.Size(160, 21);
            this.cmbdonem.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(7, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Dönemi:";
            // 
            // dtkayit
            // 
            this.dtkayit.CustomFormat = "dd-MMMM-yy";
            this.dtkayit.Enabled = false;
            this.dtkayit.Location = new System.Drawing.Point(117, 220);
            this.dtkayit.Name = "dtkayit";
            this.dtkayit.Size = new System.Drawing.Size(158, 22);
            this.dtkayit.TabIndex = 25;
            // 
            // btnogrguncelle
            // 
            this.btnogrguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnogrguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnogrguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnogrguncelle.Location = new System.Drawing.Point(145, 329);
            this.btnogrguncelle.Name = "btnogrguncelle";
            this.btnogrguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnogrguncelle.TabIndex = 24;
            this.btnogrguncelle.Text = "Güncelle";
            this.btnogrguncelle.UseVisualStyleBackColor = false;
            this.btnogrguncelle.Click += new System.EventHandler(this.btnogrguncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Kayıt Tarihi:";
            // 
            // btnogrekle
            // 
            this.btnogrekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnogrekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnogrekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnogrekle.Location = new System.Drawing.Point(11, 329);
            this.btnogrekle.Name = "btnogrekle";
            this.btnogrekle.Size = new System.Drawing.Size(117, 42);
            this.btnogrekle.TabIndex = 23;
            this.btnogrekle.Text = "Ekle";
            this.btnogrekle.UseVisualStyleBackColor = false;
            this.btnogrekle.Click += new System.EventHandler(this.btnogrekle_Click);
            // 
            // cmbsinif
            // 
            this.cmbsinif.FormattingEnabled = true;
            this.cmbsinif.Location = new System.Drawing.Point(113, 175);
            this.cmbsinif.Name = "cmbsinif";
            this.cmbsinif.Size = new System.Drawing.Size(160, 21);
            this.cmbsinif.TabIndex = 17;
            // 
            // cmbcins
            // 
            this.cmbcins.FormattingEnabled = true;
            this.cmbcins.Items.AddRange(new object[] {
            "Erkek ",
            "Kız"});
            this.cmbcins.Location = new System.Drawing.Point(113, 137);
            this.cmbcins.Name = "cmbcins";
            this.cmbcins.Size = new System.Drawing.Size(160, 21);
            this.cmbcins.TabIndex = 16;
            // 
            // dtOgr
            // 
            this.dtOgr.CustomFormat = "dd-MMMM-yy";
            this.dtOgr.Location = new System.Drawing.Point(113, 101);
            this.dtOgr.Name = "dtOgr";
            this.dtOgr.Size = new System.Drawing.Size(158, 22);
            this.dtOgr.TabIndex = 15;
            // 
            // txtOgrTC
            // 
            this.txtOgrTC.Location = new System.Drawing.Point(113, 67);
            this.txtOgrTC.Name = "txtOgrTC";
            this.txtOgrTC.Size = new System.Drawing.Size(160, 22);
            this.txtOgrTC.TabIndex = 14;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(113, 24);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(160, 22);
            this.txtOgrAd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sınıf:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı ve Soyadı:";
            // 
            // grpOgrenciAra
            // 
            this.grpOgrenciAra.Controls.Add(this.cmbdonemara);
            this.grpOgrenciAra.Controls.Add(this.label15);
            this.grpOgrenciAra.Controls.Add(this.btnara);
            this.grpOgrenciAra.Controls.Add(this.btnyenile);
            this.grpOgrenciAra.Controls.Add(this.dtgridogrlistele);
            this.grpOgrenciAra.Controls.Add(this.txtograra);
            this.grpOgrenciAra.Controls.Add(this.label23);
            this.grpOgrenciAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgrenciAra.Location = new System.Drawing.Point(433, 2);
            this.grpOgrenciAra.Name = "grpOgrenciAra";
            this.grpOgrenciAra.Size = new System.Drawing.Size(635, 398);
            this.grpOgrenciAra.TabIndex = 2;
            this.grpOgrenciAra.TabStop = false;
            this.grpOgrenciAra.Text = "Öğrenci Ara";
            // 
            // cmbdonemara
            // 
            this.cmbdonemara.FormattingEnabled = true;
            this.cmbdonemara.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cmbdonemara.Location = new System.Drawing.Point(89, 51);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(135, 21);
            this.cmbdonemara.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Dönemi:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(230, 14);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(106, 42);
            this.btnara.TabIndex = 39;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(354, 14);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dtgridogrlistele
            // 
            this.dtgridogrlistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridogrlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridogrlistele.Location = new System.Drawing.Point(0, 76);
            this.dtgridogrlistele.Name = "dtgridogrlistele";
            this.dtgridogrlistele.Size = new System.Drawing.Size(635, 322);
            this.dtgridogrlistele.TabIndex = 15;
            this.dtgridogrlistele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridogrlistele_CellClick);
            // 
            // txtograra
            // 
            this.txtograra.Location = new System.Drawing.Point(89, 18);
            this.txtograra.Name = "txtograra";
            this.txtograra.Size = new System.Drawing.Size(135, 22);
            this.txtograra.TabIndex = 14;
            this.txtograra.TextChanged += new System.EventHandler(this.txtograra_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(-4, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 13;
            this.label23.Text = "Ad-Soyad:";
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 496);
            this.Controls.Add(this.grpOgrenciAra);
            this.Controls.Add(this.grpOgrenciEkle);
            this.Name = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            this.grpOgrenciEkle.ResumeLayout(false);
            this.grpOgrenciEkle.PerformLayout();
            this.grpOgrenciAra.ResumeLayout(false);
            this.grpOgrenciAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridogrlistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenciEkle;
        private System.Windows.Forms.ComboBox cmbsinif;
        private System.Windows.Forms.DateTimePicker dtOgr;
        private System.Windows.Forms.TextBox txtOgrTC;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOgrenciAra;
        private System.Windows.Forms.DataGridView dtgridogrlistele;
        private System.Windows.Forms.TextBox txtograra;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnogrekle;
        private System.Windows.Forms.Button btnogrguncelle;
        private System.Windows.Forms.Button btnogrencisil;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.DateTimePicker dtkayit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbdonem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cmbcins;
    }
}