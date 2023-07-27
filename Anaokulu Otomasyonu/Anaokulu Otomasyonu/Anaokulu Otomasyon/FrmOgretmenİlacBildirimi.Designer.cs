namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmenİlacBildirimi
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
            this.btnİlacbildirimiSil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dttarihara = new System.Windows.Forms.DateTimePicker();
            this.dtgridİlacBildirimi = new System.Windows.Forms.DataGridView();
            this.btnilacbildirimguncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnilacbildirimiekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbadsoyad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbilacictimi = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridİlacBildirimi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnİlacbildirimiSil
            // 
            this.btnİlacbildirimiSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnİlacbildirimiSil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnİlacbildirimiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİlacbildirimiSil.Location = new System.Drawing.Point(260, 190);
            this.btnİlacbildirimiSil.Name = "btnİlacbildirimiSil";
            this.btnİlacbildirimiSil.Size = new System.Drawing.Size(117, 42);
            this.btnİlacbildirimiSil.TabIndex = 25;
            this.btnİlacbildirimiSil.Text = "SİL";
            this.btnİlacbildirimiSil.UseVisualStyleBackColor = false;
            this.btnİlacbildirimiSil.Click += new System.EventHandler(this.btnİlacbildirimiSil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnara);
            this.groupBox3.Controls.Add(this.btnyenile);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dttarihara);
            this.groupBox3.Controls.Add(this.dtgridİlacBildirimi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(423, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 421);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İlaç Bildirimi Ara";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(100, 63);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(89, 42);
            this.btnara.TabIndex = 61;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(195, 63);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 60;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tarih:";
            // 
            // dttarihara
            // 
            this.dttarihara.Location = new System.Drawing.Point(107, 20);
            this.dttarihara.Name = "dttarihara";
            this.dttarihara.Size = new System.Drawing.Size(200, 21);
            this.dttarihara.TabIndex = 58;
            // 
            // dtgridİlacBildirimi
            // 
            this.dtgridİlacBildirimi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridİlacBildirimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridİlacBildirimi.Location = new System.Drawing.Point(0, 111);
            this.dtgridİlacBildirimi.Name = "dtgridİlacBildirimi";
            this.dtgridİlacBildirimi.Size = new System.Drawing.Size(569, 304);
            this.dtgridİlacBildirimi.TabIndex = 16;
            this.dtgridİlacBildirimi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridİlacBildirimi_CellClick);
            // 
            // btnilacbildirimguncelle
            // 
            this.btnilacbildirimguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnilacbildirimguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnilacbildirimguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnilacbildirimguncelle.Location = new System.Drawing.Point(128, 190);
            this.btnilacbildirimguncelle.Name = "btnilacbildirimguncelle";
            this.btnilacbildirimguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnilacbildirimguncelle.TabIndex = 56;
            this.btnilacbildirimguncelle.Text = "Güncelle";
            this.btnilacbildirimguncelle.UseVisualStyleBackColor = false;
            this.btnilacbildirimguncelle.Click += new System.EventHandler(this.btnilacbildirimguncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbilacictimi);
            this.groupBox1.Controls.Add(this.btnilacbildirimguncelle);
            this.groupBox1.Controls.Add(this.btnİlacbildirimiSil);
            this.groupBox1.Controls.Add(this.btnilacbildirimiekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbadsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Bildirimi İşlemleri";
            // 
            // btnilacbildirimiekle
            // 
            this.btnilacbildirimiekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnilacbildirimiekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnilacbildirimiekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnilacbildirimiekle.Location = new System.Drawing.Point(0, 190);
            this.btnilacbildirimiekle.Name = "btnilacbildirimiekle";
            this.btnilacbildirimiekle.Size = new System.Drawing.Size(117, 42);
            this.btnilacbildirimiekle.TabIndex = 55;
            this.btnilacbildirimiekle.Text = "Ekle";
            this.btnilacbildirimiekle.UseVisualStyleBackColor = false;
            this.btnilacbildirimiekle.Click += new System.EventHandler(this.btnilacbildirimiekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "İlacını İçtimi";
            // 
            // cmbadsoyad
            // 
            this.cmbadsoyad.FormattingEnabled = true;
            this.cmbadsoyad.Location = new System.Drawing.Point(93, 72);
            this.cmbadsoyad.Name = "cmbadsoyad";
            this.cmbadsoyad.Size = new System.Drawing.Size(200, 23);
            this.cmbadsoyad.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tarih:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(93, 31);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(200, 21);
            this.dttarih.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(6, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 48;
            this.label23.Text = "Ad-Soyad:";
            // 
            // cmbilacictimi
            // 
            this.cmbilacictimi.FormattingEnabled = true;
            this.cmbilacictimi.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cmbilacictimi.Location = new System.Drawing.Point(107, 127);
            this.cmbilacictimi.Name = "cmbilacictimi";
            this.cmbilacictimi.Size = new System.Drawing.Size(132, 23);
            this.cmbilacictimi.TabIndex = 57;
            // 
            // FrmOgretmenİlacBildirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgretmenİlacBildirimi";
            this.Load += new System.EventHandler(this.FrmOgretmenİlacBildirimi_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridİlacBildirimi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnİlacbildirimiSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dttarihara;
        private System.Windows.Forms.DataGridView dtgridİlacBildirimi;
        private System.Windows.Forms.Button btnilacbildirimguncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnilacbildirimiekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbadsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbilacictimi;
    }
}