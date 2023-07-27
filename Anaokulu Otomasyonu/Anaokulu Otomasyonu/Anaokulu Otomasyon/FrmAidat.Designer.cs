namespace Anaokulu_Otomasyon
{
    partial class FrmAidat
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
            this.btnaidatsil = new System.Windows.Forms.Button();
            this.grpOgretmenAra = new System.Windows.Forms.GroupBox();
            this.btntarihara = new System.Windows.Forms.Button();
            this.txtveliara = new System.Windows.Forms.TextBox();
            this.dttarihara = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.dtgridaidat = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btndonemara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.btnaidatguncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbveli = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnaidatekle = new System.Windows.Forms.Button();
            this.cmbodemeturu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdonem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbgelirturu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbgelir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOgretmenAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridaidat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaidatsil
            // 
            this.btnaidatsil.BackColor = System.Drawing.Color.IndianRed;
            this.btnaidatsil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnaidatsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaidatsil.Location = new System.Drawing.Point(276, 318);
            this.btnaidatsil.Name = "btnaidatsil";
            this.btnaidatsil.Size = new System.Drawing.Size(117, 42);
            this.btnaidatsil.TabIndex = 25;
            this.btnaidatsil.Text = "SİL";
            this.btnaidatsil.UseVisualStyleBackColor = false;
            this.btnaidatsil.Click += new System.EventHandler(this.btnaidatsil_Click);
            // 
            // grpOgretmenAra
            // 
            this.grpOgretmenAra.Controls.Add(this.btntarihara);
            this.grpOgretmenAra.Controls.Add(this.txtveliara);
            this.grpOgretmenAra.Controls.Add(this.dttarihara);
            this.grpOgretmenAra.Controls.Add(this.label17);
            this.grpOgretmenAra.Controls.Add(this.cmbdonemara);
            this.grpOgretmenAra.Controls.Add(this.dtgridaidat);
            this.grpOgretmenAra.Controls.Add(this.label13);
            this.grpOgretmenAra.Controls.Add(this.label14);
            this.grpOgretmenAra.Controls.Add(this.btndonemara);
            this.grpOgretmenAra.Controls.Add(this.btnyenile);
            this.grpOgretmenAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgretmenAra.Location = new System.Drawing.Point(423, 12);
            this.grpOgretmenAra.Name = "grpOgretmenAra";
            this.grpOgretmenAra.Size = new System.Drawing.Size(707, 427);
            this.grpOgretmenAra.TabIndex = 13;
            this.grpOgretmenAra.TabStop = false;
            this.grpOgretmenAra.Text = "Aidat Ara";
            // 
            // btntarihara
            // 
            this.btntarihara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btntarihara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btntarihara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntarihara.Location = new System.Drawing.Point(282, 40);
            this.btntarihara.Name = "btntarihara";
            this.btntarihara.Size = new System.Drawing.Size(89, 30);
            this.btntarihara.TabIndex = 57;
            this.btntarihara.Text = "Ara";
            this.btntarihara.UseVisualStyleBackColor = false;
            this.btntarihara.Click += new System.EventHandler(this.btntarihara_Click);
            // 
            // txtveliara
            // 
            this.txtveliara.Location = new System.Drawing.Point(107, 74);
            this.txtveliara.Name = "txtveliara";
            this.txtveliara.Size = new System.Drawing.Size(154, 22);
            this.txtveliara.TabIndex = 56;
            this.txtveliara.TextChanged += new System.EventHandler(this.txtveliara_TextChanged);
            // 
            // dttarihara
            // 
            this.dttarihara.Location = new System.Drawing.Point(107, 40);
            this.dttarihara.Name = "dttarihara";
            this.dttarihara.Size = new System.Drawing.Size(154, 22);
            this.dttarihara.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(0, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 54;
            this.label17.Text = "Tarih:";
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
            this.cmbdonemara.Location = new System.Drawing.Point(107, 13);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(154, 21);
            this.cmbdonemara.TabIndex = 53;
            // 
            // dtgridaidat
            // 
            this.dtgridaidat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridaidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridaidat.Location = new System.Drawing.Point(6, 102);
            this.dtgridaidat.Name = "dtgridaidat";
            this.dtgridaidat.Size = new System.Drawing.Size(695, 319);
            this.dtgridaidat.TabIndex = 15;
            this.dtgridaidat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridaidat_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Veli Ad Soyad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(5, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "Dönem:";
            // 
            // btndonemara
            // 
            this.btndonemara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndonemara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btndonemara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonemara.Location = new System.Drawing.Point(282, 5);
            this.btndonemara.Name = "btndonemara";
            this.btndonemara.Size = new System.Drawing.Size(89, 30);
            this.btndonemara.TabIndex = 48;
            this.btndonemara.Text = "Ara";
            this.btndonemara.UseVisualStyleBackColor = false;
            this.btndonemara.Click += new System.EventHandler(this.btndonemara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(396, 28);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 47;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            // 
            // btnaidatguncelle
            // 
            this.btnaidatguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnaidatguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnaidatguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaidatguncelle.Location = new System.Drawing.Point(140, 318);
            this.btnaidatguncelle.Name = "btnaidatguncelle";
            this.btnaidatguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnaidatguncelle.TabIndex = 44;
            this.btnaidatguncelle.Text = "Güncelle";
            this.btnaidatguncelle.UseVisualStyleBackColor = false;
            this.btnaidatguncelle.Click += new System.EventHandler(this.btnaidatguncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnaidatsil);
            this.groupBox1.Controls.Add(this.cmbveli);
            this.groupBox1.Controls.Add(this.btnaidatguncelle);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnaidatekle);
            this.groupBox1.Controls.Add(this.cmbodemeturu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbdonem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbgelirturu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbgelir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 366);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aidat İşlemleri";
            // 
            // cmbveli
            // 
            this.cmbveli.FormattingEnabled = true;
            this.cmbveli.Location = new System.Drawing.Point(127, 17);
            this.cmbveli.Name = "cmbveli";
            this.cmbveli.Size = new System.Drawing.Size(143, 21);
            this.cmbveli.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Veli Ad Soyad:";
            // 
            // btnaidatekle
            // 
            this.btnaidatekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnaidatekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnaidatekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaidatekle.Location = new System.Drawing.Point(6, 318);
            this.btnaidatekle.Name = "btnaidatekle";
            this.btnaidatekle.Size = new System.Drawing.Size(117, 42);
            this.btnaidatekle.TabIndex = 27;
            this.btnaidatekle.Text = "Ekle";
            this.btnaidatekle.UseVisualStyleBackColor = false;
            this.btnaidatekle.Click += new System.EventHandler(this.btnaidatekle_Click);
            // 
            // cmbodemeturu
            // 
            this.cmbodemeturu.FormattingEnabled = true;
            this.cmbodemeturu.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit",
            "Havale",
            "EFT"});
            this.cmbodemeturu.Location = new System.Drawing.Point(128, 230);
            this.cmbodemeturu.Name = "cmbodemeturu";
            this.cmbodemeturu.Size = new System.Drawing.Size(143, 21);
            this.cmbodemeturu.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-1, 231);
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
            this.cmbdonem.Location = new System.Drawing.Point(128, 272);
            this.cmbdonem.Name = "cmbdonem";
            this.cmbdonem.Size = new System.Drawing.Size(143, 21);
            this.cmbdonem.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dönem:";
            // 
            // cmbgelirturu
            // 
            this.cmbgelirturu.Enabled = false;
            this.cmbgelirturu.FormattingEnabled = true;
            this.cmbgelirturu.Items.AddRange(new object[] {
            "Veli Ödemesi"});
            this.cmbgelirturu.Location = new System.Drawing.Point(128, 191);
            this.cmbgelirturu.Name = "cmbgelirturu";
            this.cmbgelirturu.Size = new System.Drawing.Size(143, 21);
            this.cmbgelirturu.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gelir/Gider Türü:";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(128, 147);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(143, 22);
            this.txttutar.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tutar:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(128, 104);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(143, 22);
            this.dttarih.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tarih:";
            // 
            // cmbgelir
            // 
            this.cmbgelir.Enabled = false;
            this.cmbgelir.FormattingEnabled = true;
            this.cmbgelir.Items.AddRange(new object[] {
            "Gelir"});
            this.cmbgelir.Location = new System.Drawing.Point(128, 60);
            this.cmbgelir.Name = "cmbgelir";
            this.cmbgelir.Size = new System.Drawing.Size(143, 21);
            this.cmbgelir.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gelir/Gider:";
            // 
            // FrmAidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1188, 527);
            this.Controls.Add(this.grpOgretmenAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAidat";
            this.Text = "FrmAidat";
            this.Load += new System.EventHandler(this.FrmAidat_Load);
            this.grpOgretmenAra.ResumeLayout(false);
            this.grpOgretmenAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridaidat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnaidatsil;
        private System.Windows.Forms.GroupBox grpOgretmenAra;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.DataGridView dtgridaidat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btndonemara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btnaidatguncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbveli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnaidatekle;
        private System.Windows.Forms.ComboBox cmbodemeturu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdonem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbgelirturu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbgelir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dttarihara;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btntarihara;
        private System.Windows.Forms.TextBox txtveliara;
    }
}