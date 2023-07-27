namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmen
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
            this.btnogretmensil = new System.Windows.Forms.Button();
            this.grpOgretmenAra = new System.Windows.Forms.GroupBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridogretmenlistele = new System.Windows.Forms.DataGridView();
            this.txtogretmenara = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnogretmenguncelle = new System.Windows.Forms.Button();
            this.grpOgretmenEkle = new System.Windows.Forms.GroupBox();
            this.txtogretmenkulad = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.rchogretmenadres = new System.Windows.Forms.RichTextBox();
            this.btnogretmenekle = new System.Windows.Forms.Button();
            this.txtogretmensifre = new System.Windows.Forms.TextBox();
            this.mskogretmentel = new System.Windows.Forms.MaskedTextBox();
            this.txtogretmenmaas = new System.Windows.Forms.TextBox();
            this.dtOgretmen = new System.Windows.Forms.DateTimePicker();
            this.txtogretmenTc = new System.Windows.Forms.TextBox();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOgretmenAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridogretmenlistele)).BeginInit();
            this.grpOgretmenEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnogretmensil
            // 
            this.btnogretmensil.BackColor = System.Drawing.Color.IndianRed;
            this.btnogretmensil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnogretmensil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnogretmensil.Location = new System.Drawing.Point(264, 424);
            this.btnogretmensil.Name = "btnogretmensil";
            this.btnogretmensil.Size = new System.Drawing.Size(117, 42);
            this.btnogretmensil.TabIndex = 25;
            this.btnogretmensil.Text = "SİL";
            this.btnogretmensil.UseVisualStyleBackColor = false;
            this.btnogretmensil.Click += new System.EventHandler(this.btnogretmensil_Click);
            // 
            // grpOgretmenAra
            // 
            this.grpOgretmenAra.Controls.Add(this.btnyenile);
            this.grpOgretmenAra.Controls.Add(this.dtgridogretmenlistele);
            this.grpOgretmenAra.Controls.Add(this.txtogretmenara);
            this.grpOgretmenAra.Controls.Add(this.label23);
            this.grpOgretmenAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgretmenAra.Location = new System.Drawing.Point(423, -1);
            this.grpOgretmenAra.Name = "grpOgretmenAra";
            this.grpOgretmenAra.Size = new System.Drawing.Size(680, 466);
            this.grpOgretmenAra.TabIndex = 6;
            this.grpOgretmenAra.TabStop = false;
            this.grpOgretmenAra.Text = "Öğretmen Ara";
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(326, 17);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dtgridogretmenlistele
            // 
            this.dtgridogretmenlistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridogretmenlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridogretmenlistele.Location = new System.Drawing.Point(0, 65);
            this.dtgridogretmenlistele.Name = "dtgridogretmenlistele";
            this.dtgridogretmenlistele.Size = new System.Drawing.Size(674, 395);
            this.dtgridogretmenlistele.TabIndex = 15;
            this.dtgridogretmenlistele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridogretmenlistele_CellClick);
            // 
            // txtogretmenara
            // 
            this.txtogretmenara.Location = new System.Drawing.Point(89, 26);
            this.txtogretmenara.Name = "txtogretmenara";
            this.txtogretmenara.Size = new System.Drawing.Size(160, 22);
            this.txtogretmenara.TabIndex = 14;
            this.txtogretmenara.TextChanged += new System.EventHandler(this.txtogretmenara_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(-4, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 20);
            this.label23.TabIndex = 13;
            this.label23.Text = "Adı:";
            // 
            // btnogretmenguncelle
            // 
            this.btnogretmenguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnogretmenguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnogretmenguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnogretmenguncelle.Location = new System.Drawing.Point(129, 424);
            this.btnogretmenguncelle.Name = "btnogretmenguncelle";
            this.btnogretmenguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnogretmenguncelle.TabIndex = 24;
            this.btnogretmenguncelle.Text = "Güncelle";
            this.btnogretmenguncelle.UseVisualStyleBackColor = false;
            this.btnogretmenguncelle.Click += new System.EventHandler(this.btnogretmenguncelle_Click);
            // 
            // grpOgretmenEkle
            // 
            this.grpOgretmenEkle.Controls.Add(this.btnogretmensil);
            this.grpOgretmenEkle.Controls.Add(this.btnogretmenguncelle);
            this.grpOgretmenEkle.Controls.Add(this.txtogretmenkulad);
            this.grpOgretmenEkle.Controls.Add(this.label19);
            this.grpOgretmenEkle.Controls.Add(this.rchogretmenadres);
            this.grpOgretmenEkle.Controls.Add(this.btnogretmenekle);
            this.grpOgretmenEkle.Controls.Add(this.txtogretmensifre);
            this.grpOgretmenEkle.Controls.Add(this.mskogretmentel);
            this.grpOgretmenEkle.Controls.Add(this.txtogretmenmaas);
            this.grpOgretmenEkle.Controls.Add(this.dtOgretmen);
            this.grpOgretmenEkle.Controls.Add(this.txtogretmenTc);
            this.grpOgretmenEkle.Controls.Add(this.txtOgretmenAd);
            this.grpOgretmenEkle.Controls.Add(this.label8);
            this.grpOgretmenEkle.Controls.Add(this.label9);
            this.grpOgretmenEkle.Controls.Add(this.label11);
            this.grpOgretmenEkle.Controls.Add(this.label12);
            this.grpOgretmenEkle.Controls.Add(this.label4);
            this.grpOgretmenEkle.Controls.Add(this.label3);
            this.grpOgretmenEkle.Controls.Add(this.label1);
            this.grpOgretmenEkle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgretmenEkle.Location = new System.Drawing.Point(12, -1);
            this.grpOgretmenEkle.Name = "grpOgretmenEkle";
            this.grpOgretmenEkle.Size = new System.Drawing.Size(390, 479);
            this.grpOgretmenEkle.TabIndex = 4;
            this.grpOgretmenEkle.TabStop = false;
            this.grpOgretmenEkle.Text = "Öğretmen İşlemleri";
            // 
            // txtogretmenkulad
            // 
            this.txtogretmenkulad.Location = new System.Drawing.Point(104, 322);
            this.txtogretmenkulad.Name = "txtogretmenkulad";
            this.txtogretmenkulad.Size = new System.Drawing.Size(160, 22);
            this.txtogretmenkulad.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(-4, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Kullanıcı AD:";
            // 
            // rchogretmenadres
            // 
            this.rchogretmenadres.Location = new System.Drawing.Point(106, 131);
            this.rchogretmenadres.Name = "rchogretmenadres";
            this.rchogretmenadres.Size = new System.Drawing.Size(158, 62);
            this.rchogretmenadres.TabIndex = 24;
            this.rchogretmenadres.Text = "";
            // 
            // btnogretmenekle
            // 
            this.btnogretmenekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnogretmenekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnogretmenekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnogretmenekle.Location = new System.Drawing.Point(6, 424);
            this.btnogretmenekle.Name = "btnogretmenekle";
            this.btnogretmenekle.Size = new System.Drawing.Size(117, 42);
            this.btnogretmenekle.TabIndex = 23;
            this.btnogretmenekle.Text = "Ekle";
            this.btnogretmenekle.UseVisualStyleBackColor = false;
            this.btnogretmenekle.Click += new System.EventHandler(this.btnogretmenekle_Click);
            // 
            // txtogretmensifre
            // 
            this.txtogretmensifre.Location = new System.Drawing.Point(104, 364);
            this.txtogretmensifre.Name = "txtogretmensifre";
            this.txtogretmensifre.Size = new System.Drawing.Size(160, 22);
            this.txtogretmensifre.TabIndex = 22;
            // 
            // mskogretmentel
            // 
            this.mskogretmentel.Location = new System.Drawing.Point(106, 294);
            this.mskogretmentel.Mask = "(999) 000-0000";
            this.mskogretmentel.Name = "mskogretmentel";
            this.mskogretmentel.Size = new System.Drawing.Size(160, 22);
            this.mskogretmentel.TabIndex = 21;
            // 
            // txtogretmenmaas
            // 
            this.txtogretmenmaas.Location = new System.Drawing.Point(106, 251);
            this.txtogretmenmaas.Name = "txtogretmenmaas";
            this.txtogretmenmaas.Size = new System.Drawing.Size(160, 22);
            this.txtogretmenmaas.TabIndex = 19;
            // 
            // dtOgretmen
            // 
            this.dtOgretmen.Location = new System.Drawing.Point(106, 91);
            this.dtOgretmen.Name = "dtOgretmen";
            this.dtOgretmen.Size = new System.Drawing.Size(158, 22);
            this.dtOgretmen.TabIndex = 15;
            // 
            // txtogretmenTc
            // 
            this.txtogretmenTc.Location = new System.Drawing.Point(106, 57);
            this.txtogretmenTc.Name = "txtogretmenTc";
            this.txtogretmenTc.Size = new System.Drawing.Size(160, 22);
            this.txtogretmenTc.TabIndex = 14;
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(106, 17);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(160, 22);
            this.txtOgretmenAd.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-4, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Şifre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-4, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Maaş:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-4, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-4, 91);
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
            this.label3.Location = new System.Drawing.Point(0, 55);
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
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD SOYAD:";
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1115, 496);
            this.Controls.Add(this.grpOgretmenAra);
            this.Controls.Add(this.grpOgretmenEkle);
            this.Name = "FrmOgretmen";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            this.grpOgretmenAra.ResumeLayout(false);
            this.grpOgretmenAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridogretmenlistele)).EndInit();
            this.grpOgretmenEkle.ResumeLayout(false);
            this.grpOgretmenEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnogretmensil;
        private System.Windows.Forms.GroupBox grpOgretmenAra;
        private System.Windows.Forms.DataGridView dtgridogretmenlistele;
        private System.Windows.Forms.TextBox txtogretmenara;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnogretmenguncelle;
        private System.Windows.Forms.GroupBox grpOgretmenEkle;
        private System.Windows.Forms.Button btnogretmenekle;
        private System.Windows.Forms.TextBox txtogretmensifre;
        private System.Windows.Forms.MaskedTextBox mskogretmentel;
        private System.Windows.Forms.TextBox txtogretmenmaas;
        private System.Windows.Forms.DateTimePicker dtOgretmen;
        private System.Windows.Forms.TextBox txtogretmenTc;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchogretmenadres;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.TextBox txtogretmenkulad;
        private System.Windows.Forms.Label label19;
    }
}