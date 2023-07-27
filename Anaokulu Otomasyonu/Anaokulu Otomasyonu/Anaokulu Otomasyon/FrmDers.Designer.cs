namespace Anaokulu_Otomasyon
{
    partial class FrmDers
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
            this.btnderssil = new System.Windows.Forms.Button();
            this.btndersekle = new System.Windows.Forms.Button();
            this.btndersguncelle = new System.Windows.Forms.Button();
            this.rchaciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDersad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnyenile = new System.Windows.Forms.Button();
            this.txtdersara = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgdersgoruntule = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdersgoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnderssil);
            this.groupBox1.Controls.Add(this.btndersekle);
            this.groupBox1.Controls.Add(this.btndersguncelle);
            this.groupBox1.Controls.Add(this.rchaciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDersad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders İşlemleri";
            // 
            // btnderssil
            // 
            this.btnderssil.BackColor = System.Drawing.Color.IndianRed;
            this.btnderssil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnderssil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnderssil.Location = new System.Drawing.Point(269, 246);
            this.btnderssil.Name = "btnderssil";
            this.btnderssil.Size = new System.Drawing.Size(117, 42);
            this.btnderssil.TabIndex = 25;
            this.btnderssil.Text = "SİL";
            this.btnderssil.UseVisualStyleBackColor = false;
            this.btnderssil.Click += new System.EventHandler(this.btnderssil_Click);
            // 
            // btndersekle
            // 
            this.btndersekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btndersekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btndersekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndersekle.Location = new System.Drawing.Point(6, 246);
            this.btndersekle.Name = "btndersekle";
            this.btndersekle.Size = new System.Drawing.Size(117, 42);
            this.btndersekle.TabIndex = 25;
            this.btndersekle.Text = "Ekle";
            this.btndersekle.UseVisualStyleBackColor = false;
            this.btndersekle.Click += new System.EventHandler(this.btndersekle_Click);
            // 
            // btndersguncelle
            // 
            this.btndersguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btndersguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btndersguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndersguncelle.Location = new System.Drawing.Point(142, 246);
            this.btndersguncelle.Name = "btndersguncelle";
            this.btndersguncelle.Size = new System.Drawing.Size(117, 42);
            this.btndersguncelle.TabIndex = 26;
            this.btndersguncelle.Text = "Güncelle";
            this.btndersguncelle.UseVisualStyleBackColor = false;
            this.btndersguncelle.Click += new System.EventHandler(this.btndersguncelle_Click);
            // 
            // rchaciklama
            // 
            this.rchaciklama.Location = new System.Drawing.Point(79, 87);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(165, 96);
            this.rchaciklama.TabIndex = 16;
            this.rchaciklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Açıklama:";
            // 
            // txtDersad
            // 
            this.txtDersad.Location = new System.Drawing.Point(79, 31);
            this.txtDersad.Name = "txtDersad";
            this.txtDersad.Size = new System.Drawing.Size(160, 22);
            this.txtDersad.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ders Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnyenile);
            this.groupBox3.Controls.Add(this.txtdersara);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtgdersgoruntule);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(416, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 397);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders Ara";
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(286, 17);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // txtdersara
            // 
            this.txtdersara.Location = new System.Drawing.Point(89, 28);
            this.txtdersara.Name = "txtdersara";
            this.txtdersara.Size = new System.Drawing.Size(160, 22);
            this.txtdersara.TabIndex = 30;
            this.txtdersara.TextChanged += new System.EventHandler(this.txtdersara_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ders Adı:";
            // 
            // dtgdersgoruntule
            // 
            this.dtgdersgoruntule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgdersgoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdersgoruntule.Location = new System.Drawing.Point(0, 65);
            this.dtgdersgoruntule.Name = "dtgdersgoruntule";
            this.dtgdersgoruntule.RowHeadersWidth = 60;
            this.dtgdersgoruntule.Size = new System.Drawing.Size(525, 326);
            this.dtgdersgoruntule.TabIndex = 15;
            this.dtgdersgoruntule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdersgoruntule_CellClick);
            // 
            // FrmDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1139, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDers";
            this.Load += new System.EventHandler(this.FrmDers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdersgoruntule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchaciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDersad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndersekle;
        private System.Windows.Forms.Button btndersguncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdersara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgdersgoruntule;
        private System.Windows.Forms.Button btnderssil;
        private System.Windows.Forms.Button btnyenile;
    }
}