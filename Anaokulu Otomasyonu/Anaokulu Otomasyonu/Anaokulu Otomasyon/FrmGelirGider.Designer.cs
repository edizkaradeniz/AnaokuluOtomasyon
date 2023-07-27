namespace Anaokulu_Otomasyon
{
    partial class FrmGelirGider
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngelirgidersil = new System.Windows.Forms.Button();
            this.btngiderguncelle = new System.Windows.Forms.Button();
            this.btngiderekle = new System.Windows.Forms.Button();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdonem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbgiderturu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbgider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOgretmenAra = new System.Windows.Forms.GroupBox();
            this.btndonemara = new System.Windows.Forms.Button();
            this.dtcikistarih = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.dtgridgelirgider = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgiristarih = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btntarihara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.grpOgretmenAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridgelirgider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngelirgidersil);
            this.groupBox1.Controls.Add(this.btngiderguncelle);
            this.groupBox1.Controls.Add(this.btngiderekle);
            this.groupBox1.Controls.Add(this.cmbOdemeTuru);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbdonem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbgiderturu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtfiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbgider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gider İşlemleri";
            // 
            // btngelirgidersil
            // 
            this.btngelirgidersil.BackColor = System.Drawing.Color.IndianRed;
            this.btngelirgidersil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btngelirgidersil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngelirgidersil.Location = new System.Drawing.Point(296, 260);
            this.btngelirgidersil.Name = "btngelirgidersil";
            this.btngelirgidersil.Size = new System.Drawing.Size(117, 42);
            this.btngelirgidersil.TabIndex = 25;
            this.btngelirgidersil.Text = "SİL";
            this.btngelirgidersil.UseVisualStyleBackColor = false;
            this.btngelirgidersil.Click += new System.EventHandler(this.btngelirgidersil_Click);
            // 
            // btngiderguncelle
            // 
            this.btngiderguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btngiderguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btngiderguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiderguncelle.Location = new System.Drawing.Point(154, 260);
            this.btngiderguncelle.Name = "btngiderguncelle";
            this.btngiderguncelle.Size = new System.Drawing.Size(117, 42);
            this.btngiderguncelle.TabIndex = 44;
            this.btngiderguncelle.Text = "Güncelle";
            this.btngiderguncelle.UseVisualStyleBackColor = false;
            this.btngiderguncelle.Click += new System.EventHandler(this.btngiderguncelle_Click);
            // 
            // btngiderekle
            // 
            this.btngiderekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btngiderekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btngiderekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiderekle.Location = new System.Drawing.Point(18, 260);
            this.btngiderekle.Name = "btngiderekle";
            this.btngiderekle.Size = new System.Drawing.Size(117, 42);
            this.btngiderekle.TabIndex = 27;
            this.btngiderekle.Text = "Ekle";
            this.btngiderekle.UseVisualStyleBackColor = false;
            this.btngiderekle.Click += new System.EventHandler(this.btngiderekle_Click);
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit",
            "Havale",
            "EFT"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(128, 187);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(143, 21);
            this.cmbOdemeTuru.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-1, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ödeme Türü:";
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
            this.cmbdonem.Location = new System.Drawing.Point(128, 229);
            this.cmbdonem.Name = "cmbdonem";
            this.cmbdonem.Size = new System.Drawing.Size(143, 21);
            this.cmbdonem.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dönem:";
            // 
            // cmbgiderturu
            // 
            this.cmbgiderturu.FormattingEnabled = true;
            this.cmbgiderturu.Items.AddRange(new object[] {
            "Kira Masrafları",
            "Kırtasiye Masrafları",
            "Elektrik-Su-Doğalgaz",
            "Personel Maaşları",
            "Mutfak Masrafları",
            "Oyuncak Masrafları",
            "Veli Ödemesi"});
            this.cmbgiderturu.Location = new System.Drawing.Point(128, 148);
            this.cmbgiderturu.Name = "cmbgiderturu";
            this.cmbgiderturu.Size = new System.Drawing.Size(143, 21);
            this.cmbgiderturu.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gider Türü:";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(128, 104);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(143, 22);
            this.txtfiyat.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tutar:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(128, 61);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(143, 22);
            this.dttarih.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tarih:";
            // 
            // cmbgider
            // 
            this.cmbgider.FormattingEnabled = true;
            this.cmbgider.Items.AddRange(new object[] {
            "Gider",
            "Gelir"});
            this.cmbgider.Location = new System.Drawing.Point(128, 17);
            this.cmbgider.Name = "cmbgider";
            this.cmbgider.Size = new System.Drawing.Size(143, 21);
            this.cmbgider.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gelir/Gider:";
            // 
            // grpOgretmenAra
            // 
            this.grpOgretmenAra.Controls.Add(this.btndonemara);
            this.grpOgretmenAra.Controls.Add(this.dtcikistarih);
            this.grpOgretmenAra.Controls.Add(this.label15);
            this.grpOgretmenAra.Controls.Add(this.cmbdonemara);
            this.grpOgretmenAra.Controls.Add(this.dtgridgelirgider);
            this.grpOgretmenAra.Controls.Add(this.label13);
            this.grpOgretmenAra.Controls.Add(this.dtgiristarih);
            this.grpOgretmenAra.Controls.Add(this.label14);
            this.grpOgretmenAra.Controls.Add(this.btntarihara);
            this.grpOgretmenAra.Controls.Add(this.btnyenile);
            this.grpOgretmenAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgretmenAra.Location = new System.Drawing.Point(447, 0);
            this.grpOgretmenAra.Name = "grpOgretmenAra";
            this.grpOgretmenAra.Size = new System.Drawing.Size(606, 305);
            this.grpOgretmenAra.TabIndex = 9;
            this.grpOgretmenAra.TabStop = false;
            this.grpOgretmenAra.Text = "Gelir-Gider Ara";
            // 
            // btndonemara
            // 
            this.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndonemara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonemara.Location = new System.Drawing.Point(223, 63);
            this.btndonemara.Name = "btndonemara";
            this.btndonemara.Size = new System.Drawing.Size(89, 34);
            this.btndonemara.TabIndex = 55;
            this.btndonemara.Text = "Ara";
            this.btndonemara.UseVisualStyleBackColor = false;
            this.btndonemara.Click += new System.EventHandler(this.btndonemara_Click);
            // 
            // dtcikistarih
            // 
            this.dtcikistarih.Location = new System.Drawing.Point(91, 40);
            this.dtcikistarih.Name = "dtcikistarih";
            this.dtcikistarih.Size = new System.Drawing.Size(126, 22);
            this.dtcikistarih.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(5, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Çıkış Tarih:";
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
            this.cmbdonemara.Location = new System.Drawing.Point(91, 73);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(126, 21);
            this.cmbdonemara.TabIndex = 52;
            // 
            // dtgridgelirgider
            // 
            this.dtgridgelirgider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridgelirgider.Location = new System.Drawing.Point(6, 97);
            this.dtgridgelirgider.Name = "dtgridgelirgider";
            this.dtgridgelirgider.Size = new System.Drawing.Size(594, 205);
            this.dtgridgelirgider.TabIndex = 15;
            this.dtgridgelirgider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridgelirgider_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(5, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Dönem:";
            // 
            // dtgiristarih
            // 
            this.dtgiristarih.Location = new System.Drawing.Point(91, 12);
            this.dtgiristarih.Name = "dtgiristarih";
            this.dtgiristarih.Size = new System.Drawing.Size(126, 22);
            this.dtgiristarih.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(5, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "Giriş Tarih:";
            // 
            // btntarihara
            // 
            this.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btntarihara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntarihara.Location = new System.Drawing.Point(222, 9);
            this.btntarihara.Name = "btntarihara";
            this.btntarihara.Size = new System.Drawing.Size(89, 42);
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
            this.btnyenile.Location = new System.Drawing.Point(343, 40);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 34);
            this.btnyenile.TabIndex = 47;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 310);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gelir";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Gider";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(934, 183);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "Gelir-Gider";
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1108, 515);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.grpOgretmenAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGelirGider";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOgretmenAra.ResumeLayout(false);
            this.grpOgretmenAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridgelirgider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbgider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgiderturu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdonem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpOgretmenAra;
        private System.Windows.Forms.DateTimePicker dtcikistarih;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.DataGridView dtgridgelirgider;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtgiristarih;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btntarihara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btngiderekle;
        private System.Windows.Forms.Button btngiderguncelle;
        private System.Windows.Forms.Button btngelirgidersil;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btndonemara;
    }
}