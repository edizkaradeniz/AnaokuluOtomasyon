namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmenYemekBildirimi
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
            this.btnyemekbildirimiekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbadsoyad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.btnyemekbildirimguncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dttarihara = new System.Windows.Forms.DateTimePicker();
            this.dtgridyemekbildirim = new System.Windows.Forms.DataGridView();
            this.btnyemekbildirimsil = new System.Windows.Forms.Button();
            this.cmbyemekyedimi = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemekbildirim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbyemekyedimi);
            this.groupBox1.Controls.Add(this.btnyemekbildirimguncelle);
            this.groupBox1.Controls.Add(this.btnyemekbildirimsil);
            this.groupBox1.Controls.Add(this.btnyemekbildirimiekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbadsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Bildirimi İşlemleri";
            // 
            // btnyemekbildirimiekle
            // 
            this.btnyemekbildirimiekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnyemekbildirimiekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnyemekbildirimiekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyemekbildirimiekle.Location = new System.Drawing.Point(0, 212);
            this.btnyemekbildirimiekle.Name = "btnyemekbildirimiekle";
            this.btnyemekbildirimiekle.Size = new System.Drawing.Size(117, 42);
            this.btnyemekbildirimiekle.TabIndex = 55;
            this.btnyemekbildirimiekle.Text = "Ekle";
            this.btnyemekbildirimiekle.UseVisualStyleBackColor = false;
            this.btnyemekbildirimiekle.Click += new System.EventHandler(this.btnyemekbildirimiekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Yemeğini Yedimi:";
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
            // btnyemekbildirimguncelle
            // 
            this.btnyemekbildirimguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnyemekbildirimguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnyemekbildirimguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyemekbildirimguncelle.Location = new System.Drawing.Point(123, 212);
            this.btnyemekbildirimguncelle.Name = "btnyemekbildirimguncelle";
            this.btnyemekbildirimguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnyemekbildirimguncelle.TabIndex = 56;
            this.btnyemekbildirimguncelle.Text = "Güncelle";
            this.btnyemekbildirimguncelle.UseVisualStyleBackColor = false;
            this.btnyemekbildirimguncelle.Click += new System.EventHandler(this.btnyemekbildirimguncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnara);
            this.groupBox3.Controls.Add(this.btnyenile);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dttarihara);
            this.groupBox3.Controls.Add(this.dtgridyemekbildirim);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(403, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 432);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yemek Bildirimi Ara";
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
            // dtgridyemekbildirim
            // 
            this.dtgridyemekbildirim.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridyemekbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridyemekbildirim.Location = new System.Drawing.Point(0, 111);
            this.dtgridyemekbildirim.Name = "dtgridyemekbildirim";
            this.dtgridyemekbildirim.Size = new System.Drawing.Size(587, 315);
            this.dtgridyemekbildirim.TabIndex = 16;
            this.dtgridyemekbildirim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridyemekbildirim_CellClick);
            // 
            // btnyemekbildirimsil
            // 
            this.btnyemekbildirimsil.BackColor = System.Drawing.Color.IndianRed;
            this.btnyemekbildirimsil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnyemekbildirimsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyemekbildirimsil.Location = new System.Drawing.Point(256, 212);
            this.btnyemekbildirimsil.Name = "btnyemekbildirimsil";
            this.btnyemekbildirimsil.Size = new System.Drawing.Size(117, 42);
            this.btnyemekbildirimsil.TabIndex = 25;
            this.btnyemekbildirimsil.Text = "SİL";
            this.btnyemekbildirimsil.UseVisualStyleBackColor = false;
            this.btnyemekbildirimsil.Click += new System.EventHandler(this.btnyemekbildirimsil_Click);
            // 
            // cmbyemekyedimi
            // 
            this.cmbyemekyedimi.FormattingEnabled = true;
            this.cmbyemekyedimi.Items.AddRange(new object[] {
            "Yedi",
            "Az Yedi",
            "Yemedi"});
            this.cmbyemekyedimi.Location = new System.Drawing.Point(141, 127);
            this.cmbyemekyedimi.Name = "cmbyemekyedimi";
            this.cmbyemekyedimi.Size = new System.Drawing.Size(152, 23);
            this.cmbyemekyedimi.TabIndex = 57;
            // 
            // FrmOgretmenYemekBildirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOgretmenYemekBildirimi";
            this.Load += new System.EventHandler(this.FrmOgretmenYemekBildirimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemekbildirim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.ComboBox cmbadsoyad;
        private System.Windows.Forms.Button btnyemekbildirimsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyemekbildirimiekle;
        private System.Windows.Forms.Button btnyemekbildirimguncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dttarihara;
        private System.Windows.Forms.DataGridView dtgridyemekbildirim;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.ComboBox cmbyemekyedimi;
    }
}