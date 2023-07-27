namespace Anaokulu_Otomasyon
{
    partial class FrmGaleri
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
            this.txtResimAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResimSil = new System.Windows.Forms.Button();
            this.txtresimyolu = new System.Windows.Forms.TextBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.btnresimguncelle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtgridresim = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnileri = new System.Windows.Forms.Button();
            this.pctresim = new System.Windows.Forms.PictureBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridresim)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResimAdi
            // 
            this.txtResimAdi.Location = new System.Drawing.Point(98, 18);
            this.txtResimAdi.Name = "txtResimAdi";
            this.txtResimAdi.Size = new System.Drawing.Size(143, 22);
            this.txtResimAdi.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Resim Adi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Resim Yolu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResimSil);
            this.groupBox1.Controls.Add(this.txtresimyolu);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnresimekle);
            this.groupBox1.Controls.Add(this.btnresimguncelle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtResimAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 187);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim İşlemleri";
            // 
            // btnResimSil
            // 
            this.btnResimSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnResimSil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnResimSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResimSil.Location = new System.Drawing.Point(269, 139);
            this.btnResimSil.Name = "btnResimSil";
            this.btnResimSil.Size = new System.Drawing.Size(117, 42);
            this.btnResimSil.TabIndex = 28;
            this.btnResimSil.Text = "SİL";
            this.btnResimSil.UseVisualStyleBackColor = false;
            this.btnResimSil.Click += new System.EventHandler(this.btnResimSil_Click);
            // 
            // txtresimyolu
            // 
            this.txtresimyolu.Location = new System.Drawing.Point(98, 92);
            this.txtresimyolu.Name = "txtresimyolu";
            this.txtresimyolu.Size = new System.Drawing.Size(121, 22);
            this.txtresimyolu.TabIndex = 34;
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(98, 57);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(143, 22);
            this.dttarih.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tarih:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 22);
            this.button1.TabIndex = 29;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnresimekle
            // 
            this.btnresimekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnresimekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresimekle.Location = new System.Drawing.Point(10, 139);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(117, 42);
            this.btnresimekle.TabIndex = 28;
            this.btnresimekle.Text = "Ekle";
            this.btnresimekle.UseVisualStyleBackColor = false;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // btnresimguncelle
            // 
            this.btnresimguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnresimguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnresimguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresimguncelle.Location = new System.Drawing.Point(133, 139);
            this.btnresimguncelle.Name = "btnresimguncelle";
            this.btnresimguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnresimguncelle.TabIndex = 45;
            this.btnresimguncelle.Text = "Güncelle";
            this.btnresimguncelle.UseVisualStyleBackColor = false;
            this.btnresimguncelle.Click += new System.EventHandler(this.btnresimguncelle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtgridresim
            // 
            this.dtgridresim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridresim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridresim.Location = new System.Drawing.Point(6, 18);
            this.dtgridresim.Name = "dtgridresim";
            this.dtgridresim.Size = new System.Drawing.Size(523, 169);
            this.dtgridresim.TabIndex = 0;
            this.dtgridresim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridresim_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgridresim);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(459, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 187);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resim Listele";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btngeri);
            this.groupBox5.Controls.Add(this.btnileri);
            this.groupBox5.Controls.Add(this.pctresim);
            this.groupBox5.Location = new System.Drawing.Point(237, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(582, 267);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resim Görüntüle";
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(44, 227);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(100, 34);
            this.btngeri.TabIndex = 2;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnileri
            // 
            this.btnileri.Location = new System.Drawing.Point(413, 227);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(100, 34);
            this.btnileri.TabIndex = 1;
            this.btnileri.Text = "İleri";
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // pctresim
            // 
            this.pctresim.Location = new System.Drawing.Point(6, 19);
            this.pctresim.Name = "pctresim";
            this.pctresim.Size = new System.Drawing.Size(561, 202);
            this.pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctresim.TabIndex = 0;
            this.pctresim.TabStop = false;
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(1000, 92);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 48;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // FrmGaleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1147, 504);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGaleri";
            this.Text = "FrmGaleri";
            this.Load += new System.EventHandler(this.FrmGaleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridresim)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtResimAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.Button btnresimguncelle;
        private System.Windows.Forms.Button btnResimSil;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgridresim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.PictureBox pctresim;
        private System.Windows.Forms.TextBox txtresimyolu;
    }
}