namespace Anaokulu_Otomasyon
{
    partial class FrmYemekListesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnyemeklistesisil = new System.Windows.Forms.Button();
            this.cmbdonem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnYemekListesiGuncelle = new System.Windows.Forms.Button();
            this.btnYemekListesiEkle = new System.Windows.Forms.Button();
            this.rchikindi = new System.Windows.Forms.RichTextBox();
            this.rchogle = new System.Windows.Forms.RichTextBox();
            this.rchsabah = new System.Windows.Forms.RichTextBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOgretmenAra = new System.Windows.Forms.GroupBox();
            this.btndonemara = new System.Windows.Forms.Button();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btntarihara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dttarihara = new System.Windows.Forms.DateTimePicker();
            this.dtgridyemeklistesi = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpOgretmenAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemeklistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnyemeklistesisil);
            this.groupBox1.Controls.Add(this.cmbdonem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnYemekListesiGuncelle);
            this.groupBox1.Controls.Add(this.btnYemekListesiEkle);
            this.groupBox1.Controls.Add(this.rchikindi);
            this.groupBox1.Controls.Add(this.rchogle);
            this.groupBox1.Controls.Add(this.rchsabah);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Listesi İşlemleri";
            // 
            // btnyemeklistesisil
            // 
            this.btnyemeklistesisil.BackColor = System.Drawing.Color.IndianRed;
            this.btnyemeklistesisil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnyemeklistesisil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyemeklistesisil.Location = new System.Drawing.Point(277, 417);
            this.btnyemeklistesisil.Name = "btnyemeklistesisil";
            this.btnyemeklistesisil.Size = new System.Drawing.Size(117, 42);
            this.btnyemeklistesisil.TabIndex = 25;
            this.btnyemeklistesisil.Text = "SİL";
            this.btnyemeklistesisil.UseVisualStyleBackColor = false;
            this.btnyemeklistesisil.Click += new System.EventHandler(this.btnyemeklistesisil_Click);
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
            this.cmbdonem.Location = new System.Drawing.Point(125, 18);
            this.cmbdonem.Name = "cmbdonem";
            this.cmbdonem.Size = new System.Drawing.Size(160, 21);
            this.cmbdonem.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Dönem:";
            // 
            // btnYemekListesiGuncelle
            // 
            this.btnYemekListesiGuncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnYemekListesiGuncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnYemekListesiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYemekListesiGuncelle.Location = new System.Drawing.Point(145, 417);
            this.btnYemekListesiGuncelle.Name = "btnYemekListesiGuncelle";
            this.btnYemekListesiGuncelle.Size = new System.Drawing.Size(117, 42);
            this.btnYemekListesiGuncelle.TabIndex = 25;
            this.btnYemekListesiGuncelle.Text = "Güncelle";
            this.btnYemekListesiGuncelle.UseVisualStyleBackColor = false;
            this.btnYemekListesiGuncelle.Click += new System.EventHandler(this.btnYemekListesiGuncelle_Click);
            // 
            // btnYemekListesiEkle
            // 
            this.btnYemekListesiEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnYemekListesiEkle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnYemekListesiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYemekListesiEkle.Location = new System.Drawing.Point(10, 417);
            this.btnYemekListesiEkle.Name = "btnYemekListesiEkle";
            this.btnYemekListesiEkle.Size = new System.Drawing.Size(117, 42);
            this.btnYemekListesiEkle.TabIndex = 24;
            this.btnYemekListesiEkle.Text = "Ekle";
            this.btnYemekListesiEkle.UseVisualStyleBackColor = false;
            this.btnYemekListesiEkle.Click += new System.EventHandler(this.btnYemekListesiEkle_Click);
            // 
            // rchikindi
            // 
            this.rchikindi.Location = new System.Drawing.Point(136, 296);
            this.rchikindi.Name = "rchikindi";
            this.rchikindi.Size = new System.Drawing.Size(149, 79);
            this.rchikindi.TabIndex = 20;
            this.rchikindi.Text = "";
            // 
            // rchogle
            // 
            this.rchogle.Location = new System.Drawing.Point(136, 197);
            this.rchogle.Name = "rchogle";
            this.rchogle.Size = new System.Drawing.Size(149, 79);
            this.rchogle.TabIndex = 19;
            this.rchogle.Text = "";
            // 
            // rchsabah
            // 
            this.rchsabah.Location = new System.Drawing.Point(136, 96);
            this.rchsabah.Name = "rchsabah";
            this.rchsabah.Size = new System.Drawing.Size(149, 79);
            this.rchsabah.TabIndex = 18;
            this.rchsabah.Text = "";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(127, 58);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(158, 22);
            this.dttarih.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sabah:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "İkindi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Öğle:";
            // 
            // grpOgretmenAra
            // 
            this.grpOgretmenAra.Controls.Add(this.btndonemara);
            this.grpOgretmenAra.Controls.Add(this.cmbdonemara);
            this.grpOgretmenAra.Controls.Add(this.label11);
            this.grpOgretmenAra.Controls.Add(this.btntarihara);
            this.grpOgretmenAra.Controls.Add(this.btnyenile);
            this.grpOgretmenAra.Controls.Add(this.dttarihara);
            this.grpOgretmenAra.Controls.Add(this.dtgridyemeklistesi);
            this.grpOgretmenAra.Controls.Add(this.label23);
            this.grpOgretmenAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgretmenAra.Location = new System.Drawing.Point(434, 4);
            this.grpOgretmenAra.Name = "grpOgretmenAra";
            this.grpOgretmenAra.Size = new System.Drawing.Size(617, 490);
            this.grpOgretmenAra.TabIndex = 8;
            this.grpOgretmenAra.TabStop = false;
            this.grpOgretmenAra.Text = "Yemek Listesi Ara";
            // 
            // btndonemara
            // 
            this.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndonemara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonemara.Location = new System.Drawing.Point(208, 57);
            this.btndonemara.Name = "btndonemara";
            this.btndonemara.Size = new System.Drawing.Size(124, 28);
            this.btndonemara.TabIndex = 41;
            this.btndonemara.Text = "Ara";
            this.btndonemara.UseVisualStyleBackColor = false;
            this.btndonemara.Click += new System.EventHandler(this.btndonemara_Click);
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
            this.cmbdonemara.Location = new System.Drawing.Point(61, 60);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(130, 21);
            this.cmbdonemara.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-5, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Dönem:";
            // 
            // btntarihara
            // 
            this.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btntarihara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntarihara.Location = new System.Drawing.Point(208, 21);
            this.btntarihara.Name = "btntarihara";
            this.btntarihara.Size = new System.Drawing.Size(124, 30);
            this.btntarihara.TabIndex = 34;
            this.btntarihara.Text = "Ara";
            this.btntarihara.UseVisualStyleBackColor = false;
            this.btntarihara.Click += new System.EventHandler(this.btntarihara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(338, 12);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(112, 42);
            this.btnyenile.TabIndex = 28;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dttarihara
            // 
            this.dttarihara.Location = new System.Drawing.Point(61, 26);
            this.dttarihara.Name = "dttarihara";
            this.dttarihara.Size = new System.Drawing.Size(130, 22);
            this.dttarihara.TabIndex = 18;
            // 
            // dtgridyemeklistesi
            // 
            this.dtgridyemeklistesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridyemeklistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridyemeklistesi.Location = new System.Drawing.Point(5, 116);
            this.dtgridyemeklistesi.Name = "dtgridyemeklistesi";
            this.dtgridyemeklistesi.Size = new System.Drawing.Size(605, 353);
            this.dtgridyemeklistesi.TabIndex = 15;
            this.dtgridyemeklistesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridyemeklistesi_CellClick);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(-4, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 20);
            this.label23.TabIndex = 13;
            this.label23.Text = "Tarih:";
            // 
            // FrmYemekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1135, 496);
            this.Controls.Add(this.grpOgretmenAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmYemekListesi";
            this.Load += new System.EventHandler(this.FrmYemekListesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOgretmenAra.ResumeLayout(false);
            this.grpOgretmenAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemeklistesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchikindi;
        private System.Windows.Forms.RichTextBox rchogle;
        private System.Windows.Forms.RichTextBox rchsabah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnyemeklistesisil;
        private System.Windows.Forms.GroupBox grpOgretmenAra;
        private System.Windows.Forms.DateTimePicker dttarihara;
        private System.Windows.Forms.DataGridView dtgridyemeklistesi;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnYemekListesiEkle;
        private System.Windows.Forms.Button btnYemekListesiGuncelle;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btntarihara;
        private System.Windows.Forms.ComboBox cmbdonem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btndonemara;
    }
}