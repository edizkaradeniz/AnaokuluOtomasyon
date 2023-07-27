namespace Anaokulu_Otomasyon
{
    partial class FrmSinifBilgileri
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
            this.btnsinifsil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.txtsinifadiara = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgsinif = new System.Windows.Forms.DataGridView();
            this.btnsinifguncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbogretmen = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbdonem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkontenjan = new System.Windows.Forms.TextBox();
            this.btnsinifekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsinifadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinif)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsinifsil
            // 
            this.btnsinifsil.BackColor = System.Drawing.Color.IndianRed;
            this.btnsinifsil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnsinifsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsinifsil.Location = new System.Drawing.Point(246, 245);
            this.btnsinifsil.Name = "btnsinifsil";
            this.btnsinifsil.Size = new System.Drawing.Size(117, 42);
            this.btnsinifsil.TabIndex = 25;
            this.btnsinifsil.Text = "SİL";
            this.btnsinifsil.UseVisualStyleBackColor = false;
            this.btnsinifsil.Click += new System.EventHandler(this.btnsinifsil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbdonemara);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnara);
            this.groupBox3.Controls.Add(this.btnyenile);
            this.groupBox3.Controls.Add(this.txtsinifadiara);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtgsinif);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(433, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 375);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınıf Ara";
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
            this.cmbdonemara.Location = new System.Drawing.Point(89, 41);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(160, 21);
            this.cmbdonemara.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Dönem:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(255, 12);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(89, 42);
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
            this.btnyenile.Location = new System.Drawing.Point(350, 12);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // txtsinifadiara
            // 
            this.txtsinifadiara.Location = new System.Drawing.Point(89, 16);
            this.txtsinifadiara.Name = "txtsinifadiara";
            this.txtsinifadiara.Size = new System.Drawing.Size(160, 22);
            this.txtsinifadiara.TabIndex = 30;
            this.txtsinifadiara.TextChanged += new System.EventHandler(this.txtsinifadiara_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sınıf Adı:";
            // 
            // dtgsinif
            // 
            this.dtgsinif.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgsinif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsinif.Location = new System.Drawing.Point(0, 65);
            this.dtgsinif.Name = "dtgsinif";
            this.dtgsinif.Size = new System.Drawing.Size(550, 304);
            this.dtgsinif.TabIndex = 15;
            this.dtgsinif.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgsinif_CellClick);
            // 
            // btnsinifguncelle
            // 
            this.btnsinifguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnsinifguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnsinifguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsinifguncelle.Location = new System.Drawing.Point(123, 245);
            this.btnsinifguncelle.Name = "btnsinifguncelle";
            this.btnsinifguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnsinifguncelle.TabIndex = 26;
            this.btnsinifguncelle.Text = "Güncelle";
            this.btnsinifguncelle.UseVisualStyleBackColor = false;
            this.btnsinifguncelle.Click += new System.EventHandler(this.btnsinifguncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsinifsil);
            this.groupBox1.Controls.Add(this.cmbogretmen);
            this.groupBox1.Controls.Add(this.btnsinifguncelle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbdonem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtkontenjan);
            this.groupBox1.Controls.Add(this.btnsinifekle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsinifadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 318);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf İşlemleri";
            // 
            // cmbogretmen
            // 
            this.cmbogretmen.FormattingEnabled = true;
            this.cmbogretmen.Location = new System.Drawing.Point(79, 178);
            this.cmbogretmen.Name = "cmbogretmen";
            this.cmbogretmen.Size = new System.Drawing.Size(160, 21);
            this.cmbogretmen.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-4, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Öğretmen:";
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
            this.cmbdonem.Location = new System.Drawing.Point(79, 127);
            this.cmbdonem.Name = "cmbdonem";
            this.cmbdonem.Size = new System.Drawing.Size(160, 21);
            this.cmbdonem.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-4, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Dönem:";
            // 
            // txtkontenjan
            // 
            this.txtkontenjan.Location = new System.Drawing.Point(79, 84);
            this.txtkontenjan.Name = "txtkontenjan";
            this.txtkontenjan.Size = new System.Drawing.Size(160, 22);
            this.txtkontenjan.TabIndex = 26;
            // 
            // btnsinifekle
            // 
            this.btnsinifekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnsinifekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnsinifekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsinifekle.Location = new System.Drawing.Point(3, 245);
            this.btnsinifekle.Name = "btnsinifekle";
            this.btnsinifekle.Size = new System.Drawing.Size(117, 42);
            this.btnsinifekle.TabIndex = 25;
            this.btnsinifekle.Text = "Ekle";
            this.btnsinifekle.UseVisualStyleBackColor = false;
            this.btnsinifekle.Click += new System.EventHandler(this.btnsinifekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kontenjan:";
            // 
            // txtsinifadi
            // 
            this.txtsinifadi.Location = new System.Drawing.Point(79, 31);
            this.txtsinifadi.Name = "txtsinifadi";
            this.txtsinifadi.Size = new System.Drawing.Size(160, 22);
            this.txtsinifadi.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sınıf Adı:";
            // 
            // FrmSinifBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1104, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSinifBilgileri";
            this.Load += new System.EventHandler(this.FrmSinifBilgileri_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinif)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnsinifsil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.TextBox txtsinifadiara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgsinif;
        private System.Windows.Forms.Button btnsinifguncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkontenjan;
        private System.Windows.Forms.Button btnsinifekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsinifadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbdonem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbogretmen;
        private System.Windows.Forms.Label label10;
    }
}