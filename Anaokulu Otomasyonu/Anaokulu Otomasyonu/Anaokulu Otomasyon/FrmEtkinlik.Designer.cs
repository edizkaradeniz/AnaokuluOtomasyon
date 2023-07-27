namespace Anaokulu_Otomasyon
{
    partial class FrmEtkinlik
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
            this.btnEtkinlikSil = new System.Windows.Forms.Button();
            this.btnetkinlikguncelle = new System.Windows.Forms.Button();
            this.cmbdonem = new System.Windows.Forms.ComboBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnetkinlikekle = new System.Windows.Forms.Button();
            this.rchbilgi = new System.Windows.Forms.RichTextBox();
            this.txtbaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOgretmenAra = new System.Windows.Forms.GroupBox();
            this.btndonemara = new System.Windows.Forms.Button();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dttarihara = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btntarihara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridetkinliklistele = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grpOgretmenAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridetkinliklistele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtkinlikSil);
            this.groupBox1.Controls.Add(this.btnetkinlikguncelle);
            this.groupBox1.Controls.Add(this.cmbdonem);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnetkinlikekle);
            this.groupBox1.Controls.Add(this.rchbilgi);
            this.groupBox1.Controls.Add(this.txtbaslik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etkinlik İşlemleri";
            // 
            // btnEtkinlikSil
            // 
            this.btnEtkinlikSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnEtkinlikSil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnEtkinlikSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtkinlikSil.Location = new System.Drawing.Point(274, 417);
            this.btnEtkinlikSil.Name = "btnEtkinlikSil";
            this.btnEtkinlikSil.Size = new System.Drawing.Size(117, 42);
            this.btnEtkinlikSil.TabIndex = 25;
            this.btnEtkinlikSil.Text = "SİL";
            this.btnEtkinlikSil.UseVisualStyleBackColor = false;
            this.btnEtkinlikSil.Click += new System.EventHandler(this.btnEtkinlikSil_Click);
            // 
            // btnetkinlikguncelle
            // 
            this.btnetkinlikguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnetkinlikguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnetkinlikguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnetkinlikguncelle.Location = new System.Drawing.Point(139, 417);
            this.btnetkinlikguncelle.Name = "btnetkinlikguncelle";
            this.btnetkinlikguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnetkinlikguncelle.TabIndex = 43;
            this.btnetkinlikguncelle.Text = "Güncelle";
            this.btnetkinlikguncelle.UseVisualStyleBackColor = false;
            this.btnetkinlikguncelle.Click += new System.EventHandler(this.btnetkinlikguncelle_Click);
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
            // btnetkinlikekle
            // 
            this.btnetkinlikekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnetkinlikekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnetkinlikekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnetkinlikekle.Location = new System.Drawing.Point(6, 417);
            this.btnetkinlikekle.Name = "btnetkinlikekle";
            this.btnetkinlikekle.Size = new System.Drawing.Size(117, 42);
            this.btnetkinlikekle.TabIndex = 24;
            this.btnetkinlikekle.Text = "Ekle";
            this.btnetkinlikekle.UseVisualStyleBackColor = false;
            this.btnetkinlikekle.Click += new System.EventHandler(this.btnetkinlikekle_Click);
            // 
            // rchbilgi
            // 
            this.rchbilgi.Location = new System.Drawing.Point(107, 131);
            this.rchbilgi.Name = "rchbilgi";
            this.rchbilgi.Size = new System.Drawing.Size(190, 268);
            this.rchbilgi.TabIndex = 19;
            this.rchbilgi.Text = "";
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
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Etkinlik Bilgi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Etkinlik Başlığı:";
            // 
            // grpOgretmenAra
            // 
            this.grpOgretmenAra.Controls.Add(this.btndonemara);
            this.grpOgretmenAra.Controls.Add(this.cmbdonemara);
            this.grpOgretmenAra.Controls.Add(this.label10);
            this.grpOgretmenAra.Controls.Add(this.dttarihara);
            this.grpOgretmenAra.Controls.Add(this.label8);
            this.grpOgretmenAra.Controls.Add(this.btntarihara);
            this.grpOgretmenAra.Controls.Add(this.btnyenile);
            this.grpOgretmenAra.Controls.Add(this.dtgridetkinliklistele);
            this.grpOgretmenAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgretmenAra.Location = new System.Drawing.Point(405, 12);
            this.grpOgretmenAra.Name = "grpOgretmenAra";
            this.grpOgretmenAra.Size = new System.Drawing.Size(569, 450);
            this.grpOgretmenAra.TabIndex = 8;
            this.grpOgretmenAra.TabStop = false;
            this.grpOgretmenAra.Text = "Etkinlik Ara";
            // 
            // btndonemara
            // 
            this.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndonemara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonemara.Location = new System.Drawing.Point(278, 57);
            this.btndonemara.Name = "btndonemara";
            this.btndonemara.Size = new System.Drawing.Size(89, 27);
            this.btndonemara.TabIndex = 53;
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
            this.cmbdonemara.Location = new System.Drawing.Point(66, 57);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(200, 21);
            this.cmbdonemara.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Dönem:";
            // 
            // dttarihara
            // 
            this.dttarihara.Location = new System.Drawing.Point(66, 14);
            this.dttarihara.Name = "dttarihara";
            this.dttarihara.Size = new System.Drawing.Size(200, 22);
            this.dttarihara.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tarih:";
            // 
            // btntarihara
            // 
            this.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btntarihara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntarihara.Location = new System.Drawing.Point(278, 13);
            this.btntarihara.Name = "btntarihara";
            this.btntarihara.Size = new System.Drawing.Size(89, 27);
            this.btntarihara.TabIndex = 48;
            this.btntarihara.Text = "Ara";
            this.btntarihara.UseVisualStyleBackColor = false;
            this.btntarihara.Click += new System.EventHandler(this.btntarihara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(393, 30);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 33);
            this.btnyenile.TabIndex = 47;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            // 
            // dtgridetkinliklistele
            // 
            this.dtgridetkinliklistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridetkinliklistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridetkinliklistele.Location = new System.Drawing.Point(6, 95);
            this.dtgridetkinliklistele.Name = "dtgridetkinliklistele";
            this.dtgridetkinliklistele.Size = new System.Drawing.Size(557, 349);
            this.dtgridetkinliklistele.TabIndex = 15;
            this.dtgridetkinliklistele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridetkinliklistele_CellClick);
            // 
            // FrmEtkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1184, 496);
            this.Controls.Add(this.grpOgretmenAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEtkinlik";
            this.Text = "FrmEtkinlik";
            this.Load += new System.EventHandler(this.FrmEtkinlik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOgretmenAra.ResumeLayout(false);
            this.grpOgretmenAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridetkinliklistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbdonem;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnetkinlikekle;
        private System.Windows.Forms.RichTextBox rchbilgi;
        private System.Windows.Forms.TextBox txtbaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnetkinlikguncelle;
        private System.Windows.Forms.Button btnEtkinlikSil;
        private System.Windows.Forms.GroupBox grpOgretmenAra;
        private System.Windows.Forms.DataGridView dtgridetkinliklistele;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dttarihara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btntarihara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btndonemara;
    }
}