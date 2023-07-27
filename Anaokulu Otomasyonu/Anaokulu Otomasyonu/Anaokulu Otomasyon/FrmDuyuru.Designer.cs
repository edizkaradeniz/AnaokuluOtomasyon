namespace Anaokulu_Otomasyon
{
    partial class FrmDuyuru
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
            this.btnduyurusil = new System.Windows.Forms.Button();
            this.btnduyuruguncelle = new System.Windows.Forms.Button();
            this.cmbdonem = new System.Windows.Forms.ComboBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnduyuruekle = new System.Windows.Forms.Button();
            this.rchicerik = new System.Windows.Forms.RichTextBox();
            this.txtbaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOgretmenAra = new System.Windows.Forms.GroupBox();
            this.btndonemara = new System.Windows.Forms.Button();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dttarihara = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTarihara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridduyurulistele = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grpOgretmenAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridduyurulistele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnduyurusil);
            this.groupBox1.Controls.Add(this.btnduyuruguncelle);
            this.groupBox1.Controls.Add(this.cmbdonem);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnduyuruekle);
            this.groupBox1.Controls.Add(this.rchicerik);
            this.groupBox1.Controls.Add(this.txtbaslik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyuru İşlemleri";
            // 
            // btnduyurusil
            // 
            this.btnduyurusil.BackColor = System.Drawing.Color.IndianRed;
            this.btnduyurusil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnduyurusil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnduyurusil.Location = new System.Drawing.Point(257, 417);
            this.btnduyurusil.Name = "btnduyurusil";
            this.btnduyurusil.Size = new System.Drawing.Size(117, 42);
            this.btnduyurusil.TabIndex = 26;
            this.btnduyurusil.Text = "SİL";
            this.btnduyurusil.UseVisualStyleBackColor = false;
            this.btnduyurusil.Click += new System.EventHandler(this.btnduyurusil_Click);
            // 
            // btnduyuruguncelle
            // 
            this.btnduyuruguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnduyuruguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnduyuruguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnduyuruguncelle.Location = new System.Drawing.Point(133, 417);
            this.btnduyuruguncelle.Name = "btnduyuruguncelle";
            this.btnduyuruguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnduyuruguncelle.TabIndex = 25;
            this.btnduyuruguncelle.Text = "Güncelle";
            this.btnduyuruguncelle.UseVisualStyleBackColor = false;
            this.btnduyuruguncelle.Click += new System.EventHandler(this.btnduyuruguncelle_Click);
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
            this.cmbdonem.Location = new System.Drawing.Point(107, 104);
            this.cmbdonem.Name = "cmbdonem";
            this.cmbdonem.Size = new System.Drawing.Size(190, 21);
            this.cmbdonem.TabIndex = 42;
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(107, 62);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(190, 22);
            this.dttarih.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Dönem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tarih:";
            // 
            // btnduyuruekle
            // 
            this.btnduyuruekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnduyuruekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnduyuruekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnduyuruekle.Location = new System.Drawing.Point(10, 417);
            this.btnduyuruekle.Name = "btnduyuruekle";
            this.btnduyuruekle.Size = new System.Drawing.Size(117, 42);
            this.btnduyuruekle.TabIndex = 24;
            this.btnduyuruekle.Text = "Ekle";
            this.btnduyuruekle.UseVisualStyleBackColor = false;
            this.btnduyuruekle.Click += new System.EventHandler(this.btnduyuruekle_Click);
            // 
            // rchicerik
            // 
            this.rchicerik.Location = new System.Drawing.Point(107, 133);
            this.rchicerik.Name = "rchicerik";
            this.rchicerik.Size = new System.Drawing.Size(183, 268);
            this.rchicerik.TabIndex = 19;
            this.rchicerik.Text = "";
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(107, 18);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(190, 22);
            this.txtbaslik.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Duyuru İçeriği:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Duyuru Başlığı:";
            // 
            // grpOgretmenAra
            // 
            this.grpOgretmenAra.Controls.Add(this.btndonemara);
            this.grpOgretmenAra.Controls.Add(this.cmbdonemara);
            this.grpOgretmenAra.Controls.Add(this.label10);
            this.grpOgretmenAra.Controls.Add(this.dttarihara);
            this.grpOgretmenAra.Controls.Add(this.label8);
            this.grpOgretmenAra.Controls.Add(this.btnTarihara);
            this.grpOgretmenAra.Controls.Add(this.btnyenile);
            this.grpOgretmenAra.Controls.Add(this.dtgridduyurulistele);
            this.grpOgretmenAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgretmenAra.Location = new System.Drawing.Point(387, 0);
            this.grpOgretmenAra.Name = "grpOgretmenAra";
            this.grpOgretmenAra.Size = new System.Drawing.Size(584, 459);
            this.grpOgretmenAra.TabIndex = 7;
            this.grpOgretmenAra.TabStop = false;
            this.grpOgretmenAra.Text = "Duyuru Ara";
            // 
            // btndonemara
            // 
            this.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndonemara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonemara.Location = new System.Drawing.Point(275, 45);
            this.btndonemara.Name = "btndonemara";
            this.btndonemara.Size = new System.Drawing.Size(89, 30);
            this.btndonemara.TabIndex = 47;
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
            this.cmbdonemara.Location = new System.Drawing.Point(67, 51);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(200, 21);
            this.cmbdonemara.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Dönem:";
            // 
            // dttarihara
            // 
            this.dttarihara.Location = new System.Drawing.Point(67, 19);
            this.dttarihara.Name = "dttarihara";
            this.dttarihara.Size = new System.Drawing.Size(200, 22);
            this.dttarihara.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Tarih:";
            // 
            // btnTarihara
            // 
            this.btnTarihara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTarihara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnTarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarihara.Location = new System.Drawing.Point(275, 12);
            this.btnTarihara.Name = "btnTarihara";
            this.btnTarihara.Size = new System.Drawing.Size(89, 30);
            this.btnTarihara.TabIndex = 39;
            this.btnTarihara.Text = "Ara";
            this.btnTarihara.UseVisualStyleBackColor = false;
            this.btnTarihara.Click += new System.EventHandler(this.btnTarihara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(374, 18);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dtgridduyurulistele
            // 
            this.dtgridduyurulistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridduyurulistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridduyurulistele.Location = new System.Drawing.Point(0, 80);
            this.dtgridduyurulistele.Name = "dtgridduyurulistele";
            this.dtgridduyurulistele.Size = new System.Drawing.Size(567, 373);
            this.dtgridduyurulistele.TabIndex = 15;
            this.dtgridduyurulistele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridduyurulistele_CellClick);
            // 
            // FrmDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1145, 496);
            this.Controls.Add(this.grpOgretmenAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDuyuru";
            this.Load += new System.EventHandler(this.FrmDuyuru_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOgretmenAra.ResumeLayout(false);
            this.grpOgretmenAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridduyurulistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchicerik;
        private System.Windows.Forms.TextBox txtbaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOgretmenAra;
        private System.Windows.Forms.DataGridView dtgridduyurulistele;
        private System.Windows.Forms.Button btnduyuruekle;
        private System.Windows.Forms.Button btnduyuruguncelle;
        private System.Windows.Forms.Button btnduyurusil;
        private System.Windows.Forms.Button btnTarihara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dttarihara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbdonem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btndonemara;
    }
}