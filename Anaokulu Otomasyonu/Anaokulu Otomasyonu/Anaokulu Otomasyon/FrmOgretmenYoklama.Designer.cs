namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmenYoklama
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
            this.btnyoklamaekle = new System.Windows.Forms.Button();
            this.cmbokul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbadsoyad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.btnyoklamaguncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridyoklama = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dttarihara = new System.Windows.Forms.DateTimePicker();
            this.btnyoklamasil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyoklama)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnyoklamasil);
            this.groupBox1.Controls.Add(this.btnyoklamaguncelle);
            this.groupBox1.Controls.Add(this.btnyoklamaekle);
            this.groupBox1.Controls.Add(this.cmbokul);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbadsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Yoklama İşlemleri";
            // 
            // btnyoklamaekle
            // 
            this.btnyoklamaekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnyoklamaekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnyoklamaekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyoklamaekle.Location = new System.Drawing.Point(2, 168);
            this.btnyoklamaekle.Name = "btnyoklamaekle";
            this.btnyoklamaekle.Size = new System.Drawing.Size(117, 42);
            this.btnyoklamaekle.TabIndex = 59;
            this.btnyoklamaekle.Text = "Ekle";
            this.btnyoklamaekle.UseVisualStyleBackColor = false;
            this.btnyoklamaekle.Click += new System.EventHandler(this.btnyoklamaekle_Click);
            // 
            // cmbokul
            // 
            this.cmbokul.FormattingEnabled = true;
            this.cmbokul.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cmbokul.Location = new System.Drawing.Point(109, 116);
            this.cmbokul.Name = "cmbokul";
            this.cmbokul.Size = new System.Drawing.Size(151, 23);
            this.cmbokul.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Okula Geldimi";
            // 
            // cmbadsoyad
            // 
            this.cmbadsoyad.FormattingEnabled = true;
            this.cmbadsoyad.Location = new System.Drawing.Point(83, 71);
            this.cmbadsoyad.Name = "cmbadsoyad";
            this.cmbadsoyad.Size = new System.Drawing.Size(177, 23);
            this.cmbadsoyad.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(-4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tarih:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(83, 30);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(177, 21);
            this.dttarih.TabIndex = 54;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(-4, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 53;
            this.label23.Text = "Ad-Soyad:";
            // 
            // btnyoklamaguncelle
            // 
            this.btnyoklamaguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnyoklamaguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnyoklamaguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyoklamaguncelle.Location = new System.Drawing.Point(129, 168);
            this.btnyoklamaguncelle.Name = "btnyoklamaguncelle";
            this.btnyoklamaguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnyoklamaguncelle.TabIndex = 59;
            this.btnyoklamaguncelle.Text = "Güncelle";
            this.btnyoklamaguncelle.UseVisualStyleBackColor = false;
            this.btnyoklamaguncelle.Click += new System.EventHandler(this.btnyoklamaguncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnara);
            this.groupBox3.Controls.Add(this.btnyenile);
            this.groupBox3.Controls.Add(this.dtgridyoklama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dttarihara);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(410, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 409);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Yoklama Ara";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(286, 15);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(89, 42);
            this.btnara.TabIndex = 63;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(417, 15);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 62;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dtgridyoklama
            // 
            this.dtgridyoklama.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridyoklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridyoklama.Location = new System.Drawing.Point(6, 74);
            this.dtgridyoklama.Name = "dtgridyoklama";
            this.dtgridyoklama.Size = new System.Drawing.Size(544, 329);
            this.dtgridyoklama.TabIndex = 56;
            this.dtgridyoklama.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridyoklama_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tarih:";
            // 
            // dttarihara
            // 
            this.dttarihara.Location = new System.Drawing.Point(83, 30);
            this.dttarihara.Name = "dttarihara";
            this.dttarihara.Size = new System.Drawing.Size(177, 21);
            this.dttarihara.TabIndex = 54;
            // 
            // btnyoklamasil
            // 
            this.btnyoklamasil.BackColor = System.Drawing.Color.IndianRed;
            this.btnyoklamasil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnyoklamasil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyoklamasil.Location = new System.Drawing.Point(262, 168);
            this.btnyoklamasil.Name = "btnyoklamasil";
            this.btnyoklamasil.Size = new System.Drawing.Size(117, 42);
            this.btnyoklamasil.TabIndex = 25;
            this.btnyoklamasil.Text = "SİL";
            this.btnyoklamasil.UseVisualStyleBackColor = false;
            this.btnyoklamasil.Click += new System.EventHandler(this.btnyoklamasil_Click);
            // 
            // FrmOgretmenYoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgretmenYoklama";
            this.Load += new System.EventHandler(this.FrmOgretmenYoklama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyoklama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbokul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbadsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnyoklamaekle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dttarihara;
        private System.Windows.Forms.Button btnyoklamaguncelle;
        private System.Windows.Forms.DataGridView dtgridyoklama;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btnyoklamasil;
    }
}