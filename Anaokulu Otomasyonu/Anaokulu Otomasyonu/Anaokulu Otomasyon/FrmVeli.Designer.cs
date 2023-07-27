namespace Anaokulu_Otomasyon
{
    partial class FrmVeli
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
            this.btnveliSil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.cmbogrenci = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdonemi = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtyillikfiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnveliekle = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkulad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtveliadsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpOgrenciAra = new System.Windows.Forms.GroupBox();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridvelilistele = new System.Windows.Forms.DataGridView();
            this.txtveliara = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpOgrenciAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvelilistele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnveliSil);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.cmbogrenci);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbdonemi);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtyillikfiyat);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnveliekle);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.txtkulad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rchadres);
            this.groupBox1.Controls.Add(this.msktel);
            this.groupBox1.Controls.Add(this.txtveliadsoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veli İşlemleri";
            // 
            // btnveliSil
            // 
            this.btnveliSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnveliSil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnveliSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnveliSil.Location = new System.Drawing.Point(271, 372);
            this.btnveliSil.Name = "btnveliSil";
            this.btnveliSil.Size = new System.Drawing.Size(117, 42);
            this.btnveliSil.TabIndex = 25;
            this.btnveliSil.Text = "SİL";
            this.btnveliSil.UseVisualStyleBackColor = false;
            this.btnveliSil.Click += new System.EventHandler(this.btnveliSil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.Location = new System.Drawing.Point(134, 372);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnguncelle.TabIndex = 39;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // cmbogrenci
            // 
            this.cmbogrenci.FormattingEnabled = true;
            this.cmbogrenci.Location = new System.Drawing.Point(151, 54);
            this.cmbogrenci.Name = "cmbogrenci";
            this.cmbogrenci.Size = new System.Drawing.Size(121, 21);
            this.cmbogrenci.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Öğrenci Adı ve Soyadı:";
            // 
            // cmbdonemi
            // 
            this.cmbdonemi.FormattingEnabled = true;
            this.cmbdonemi.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cmbdonemi.Location = new System.Drawing.Point(130, 333);
            this.cmbdonemi.Name = "cmbdonemi";
            this.cmbdonemi.Size = new System.Drawing.Size(144, 21);
            this.cmbdonemi.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(4, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Dönemi:";
            // 
            // txtyillikfiyat
            // 
            this.txtyillikfiyat.Location = new System.Drawing.Point(130, 286);
            this.txtyillikfiyat.Name = "txtyillikfiyat";
            this.txtyillikfiyat.Size = new System.Drawing.Size(144, 22);
            this.txtyillikfiyat.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Yıllık Fiyat:";
            // 
            // btnveliekle
            // 
            this.btnveliekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnveliekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnveliekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnveliekle.Location = new System.Drawing.Point(11, 372);
            this.btnveliekle.Name = "btnveliekle";
            this.btnveliekle.Size = new System.Drawing.Size(117, 42);
            this.btnveliekle.TabIndex = 24;
            this.btnveliekle.Text = "Ekle";
            this.btnveliekle.UseVisualStyleBackColor = false;
            this.btnveliekle.Click += new System.EventHandler(this.btnveliekle_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(130, 250);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(144, 22);
            this.txtsifre.TabIndex = 38;
            // 
            // txtkulad
            // 
            this.txtkulad.Location = new System.Drawing.Point(130, 216);
            this.txtkulad.Name = "txtkulad";
            this.txtkulad.Size = new System.Drawing.Size(144, 22);
            this.txtkulad.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // rchadres
            // 
            this.rchadres.Location = new System.Drawing.Point(130, 126);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(144, 67);
            this.rchadres.TabIndex = 33;
            this.rchadres.Text = "";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(130, 85);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(144, 22);
            this.msktel.TabIndex = 29;
            // 
            // txtveliadsoyad
            // 
            this.txtveliadsoyad.Location = new System.Drawing.Point(130, 16);
            this.txtveliadsoyad.Name = "txtveliadsoyad";
            this.txtveliadsoyad.Size = new System.Drawing.Size(144, 22);
            this.txtveliadsoyad.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Adres:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-4, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Veli Adı ve Soyadı:";
            // 
            // grpOgrenciAra
            // 
            this.grpOgrenciAra.Controls.Add(this.cmbdonemara);
            this.grpOgrenciAra.Controls.Add(this.label18);
            this.grpOgrenciAra.Controls.Add(this.btnara);
            this.grpOgrenciAra.Controls.Add(this.btnyenile);
            this.grpOgrenciAra.Controls.Add(this.dtgridvelilistele);
            this.grpOgrenciAra.Controls.Add(this.txtveliara);
            this.grpOgrenciAra.Controls.Add(this.label23);
            this.grpOgrenciAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgrenciAra.Location = new System.Drawing.Point(401, 2);
            this.grpOgrenciAra.Name = "grpOgrenciAra";
            this.grpOgrenciAra.Size = new System.Drawing.Size(748, 466);
            this.grpOgrenciAra.TabIndex = 4;
            this.grpOgrenciAra.TabStop = false;
            this.grpOgrenciAra.Text = "Veli Ara";
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
            this.cmbdonemara.Location = new System.Drawing.Point(101, 42);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(160, 21);
            this.cmbdonemara.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "Dönemi:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(267, 17);
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
            this.btnyenile.Location = new System.Drawing.Point(389, 17);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dtgridvelilistele
            // 
            this.dtgridvelilistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridvelilistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridvelilistele.Location = new System.Drawing.Point(3, 98);
            this.dtgridvelilistele.Name = "dtgridvelilistele";
            this.dtgridvelilistele.Size = new System.Drawing.Size(739, 358);
            this.dtgridvelilistele.TabIndex = 15;
            this.dtgridvelilistele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridvelilistele_CellClick);
            // 
            // txtveliara
            // 
            this.txtveliara.Location = new System.Drawing.Point(101, 13);
            this.txtveliara.Name = "txtveliara";
            this.txtveliara.Size = new System.Drawing.Size(160, 22);
            this.txtveliara.TabIndex = 14;
            this.txtveliara.TextChanged += new System.EventHandler(this.txtveliara_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(-4, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 20);
            this.label23.TabIndex = 13;
            this.label23.Text = "Adı ve Soyadı:";
            // 
            // FrmVeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1210, 496);
            this.Controls.Add(this.grpOgrenciAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeli";
            this.Load += new System.EventHandler(this.FrmVeli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOgrenciAra.ResumeLayout(false);
            this.grpOgrenciAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvelilistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.TextBox txtveliadsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchadres;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkulad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnveliekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnveliSil;
        private System.Windows.Forms.GroupBox grpOgrenciAra;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.DataGridView dtgridvelilistele;
        private System.Windows.Forms.TextBox txtveliara;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtyillikfiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbdonemi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbogrenci;
        private System.Windows.Forms.Label label6;
    }
}