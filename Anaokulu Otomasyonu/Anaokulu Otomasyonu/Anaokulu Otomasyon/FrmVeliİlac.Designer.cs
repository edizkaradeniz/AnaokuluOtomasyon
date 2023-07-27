namespace Anaokulu_Otomasyon
{
    partial class FrmVeliİlac
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
            this.cmbadsoyad = new System.Windows.Forms.ComboBox();
            this.btnilacekle = new System.Windows.Forms.Button();
            this.rchaciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtilac = new System.Windows.Forms.TextBox();
            this.btnilacguncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgridilac = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridilac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.cmbadsoyad);
            this.groupBox1.Controls.Add(this.btnilacguncelle);
            this.groupBox1.Controls.Add(this.btnilacekle);
            this.groupBox1.Controls.Add(this.rchaciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtilac);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Ekle";
            // 
            // cmbadsoyad
            // 
            this.cmbadsoyad.FormattingEnabled = true;
            this.cmbadsoyad.Location = new System.Drawing.Point(141, 17);
            this.cmbadsoyad.Name = "cmbadsoyad";
            this.cmbadsoyad.Size = new System.Drawing.Size(142, 23);
            this.cmbadsoyad.TabIndex = 30;
            // 
            // btnilacekle
            // 
            this.btnilacekle.BackColor = System.Drawing.Color.YellowGreen;
            this.btnilacekle.Image = global::Anaokulu_Otomasyon.Properties.Resources.insert__2_;
            this.btnilacekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnilacekle.Location = new System.Drawing.Point(6, 291);
            this.btnilacekle.Name = "btnilacekle";
            this.btnilacekle.Size = new System.Drawing.Size(117, 42);
            this.btnilacekle.TabIndex = 29;
            this.btnilacekle.Text = "Ekle";
            this.btnilacekle.UseVisualStyleBackColor = false;
            this.btnilacekle.Click += new System.EventHandler(this.btnilacekle_Click);
            // 
            // rchaciklama
            // 
            this.rchaciklama.Location = new System.Drawing.Point(141, 108);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(143, 135);
            this.rchaciklama.TabIndex = 28;
            this.rchaciklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Öğrenci Ad-Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "İlaç Adı:";
            // 
            // txtilac
            // 
            this.txtilac.Location = new System.Drawing.Point(141, 52);
            this.txtilac.Name = "txtilac";
            this.txtilac.Size = new System.Drawing.Size(143, 21);
            this.txtilac.TabIndex = 24;
            // 
            // btnilacguncelle
            // 
            this.btnilacguncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnilacguncelle.Image = global::Anaokulu_Otomasyon.Properties.Resources.update;
            this.btnilacguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnilacguncelle.Location = new System.Drawing.Point(141, 291);
            this.btnilacguncelle.Name = "btnilacguncelle";
            this.btnilacguncelle.Size = new System.Drawing.Size(117, 42);
            this.btnilacguncelle.TabIndex = 30;
            this.btnilacguncelle.Text = "Güncelle";
            this.btnilacguncelle.UseVisualStyleBackColor = false;
            this.btnilacguncelle.Click += new System.EventHandler(this.btnilacguncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgridilac);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(425, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 333);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İlaç Listesi";
            // 
            // dtgridilac
            // 
            this.dtgridilac.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgridilac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridilac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgridilac.Location = new System.Drawing.Point(3, 17);
            this.dtgridilac.Name = "dtgridilac";
            this.dtgridilac.Size = new System.Drawing.Size(531, 313);
            this.dtgridilac.TabIndex = 0;
            this.dtgridilac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridilac_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Image = global::Anaokulu_Otomasyon.Properties.Resources.trash;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(275, 291);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 42);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmVeliİlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1019, 469);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliİlac";
            this.Text = "FrmVeliİlac";
            this.Load += new System.EventHandler(this.FrmVeliİlac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridilac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchaciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtilac;
        private System.Windows.Forms.Button btnilacekle;
        private System.Windows.Forms.Button btnilacguncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgridilac;
        private System.Windows.Forms.ComboBox cmbadsoyad;
        private System.Windows.Forms.Button btnSil;
    }
}