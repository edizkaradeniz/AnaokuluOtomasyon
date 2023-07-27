namespace Anaokulu_Otomasyon
{
    partial class FrmYoklamaListesi
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
            this.cmbsinif = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dtgridYoklamaListesi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridYoklamaListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsinif);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.dtgridYoklamaListesi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yoklama Listesi";
            // 
            // cmbsinif
            // 
            this.cmbsinif.FormattingEnabled = true;
            this.cmbsinif.Location = new System.Drawing.Point(75, 76);
            this.cmbsinif.Name = "cmbsinif";
            this.cmbsinif.Size = new System.Drawing.Size(200, 21);
            this.cmbsinif.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sınıf:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(314, 45);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(160, 42);
            this.btnara.TabIndex = 33;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(79, 34);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(196, 20);
            this.dttarih.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(24, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 20);
            this.label23.TabIndex = 30;
            this.label23.Text = "Tarih:";
            // 
            // dtgridYoklamaListesi
            // 
            this.dtgridYoklamaListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridYoklamaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridYoklamaListesi.Location = new System.Drawing.Point(11, 109);
            this.dtgridYoklamaListesi.Name = "dtgridYoklamaListesi";
            this.dtgridYoklamaListesi.Size = new System.Drawing.Size(617, 319);
            this.dtgridYoklamaListesi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(753, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 45);
            this.label5.TabIndex = 36;
            this.label5.Text = "Gelmeyen Öğrenci Listesi";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(721, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 381);
            this.listBox1.TabIndex = 38;
            // 
            // FrmYoklamaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1200, 496);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmYoklamaListesi";
            this.Load += new System.EventHandler(this.FrmYoklamaListesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridYoklamaListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgridYoklamaListesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbsinif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnara;
    }
}