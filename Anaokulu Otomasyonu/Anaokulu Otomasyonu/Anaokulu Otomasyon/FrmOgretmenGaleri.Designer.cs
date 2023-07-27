namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmenGaleri
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnileri = new System.Windows.Forms.Button();
            this.pctresim = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtresimyolu = new System.Windows.Forms.TextBox();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResimAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btngeri);
            this.groupBox5.Controls.Add(this.btnileri);
            this.groupBox5.Controls.Add(this.pctresim);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(331, 62);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(547, 239);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resim Görüntüle";
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(55, 192);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(100, 34);
            this.btngeri.TabIndex = 2;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnileri
            // 
            this.btnileri.Location = new System.Drawing.Point(415, 191);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(100, 34);
            this.btnileri.TabIndex = 1;
            this.btnileri.Text = "İleri";
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // pctresim
            // 
            this.pctresim.Image = global::Anaokulu_Otomasyon.Properties.Resources._89163f66_11f2_4795_b80d_d6b300615536;
            this.pctresim.Location = new System.Drawing.Point(6, 19);
            this.pctresim.Name = "pctresim";
            this.pctresim.Size = new System.Drawing.Size(535, 166);
            this.pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctresim.TabIndex = 0;
            this.pctresim.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtresimyolu);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnresimekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtResimAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 187);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim Ekle";
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
            this.btnresimekle.Location = new System.Drawing.Point(98, 139);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(143, 42);
            this.btnresimekle.TabIndex = 28;
            this.btnresimekle.Text = "Ekle";
            this.btnresimekle.UseVisualStyleBackColor = false;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
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
            // txtResimAdi
            // 
            this.txtResimAdi.Location = new System.Drawing.Point(98, 18);
            this.txtResimAdi.Name = "txtResimAdi";
            this.txtResimAdi.Size = new System.Drawing.Size(143, 22);
            this.txtResimAdi.TabIndex = 22;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOgretmenGaleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "FrmOgretmenGaleri";
            this.Text = "FrmOgretmenGaleri";
            this.Load += new System.EventHandler(this.FrmOgretmenGaleri_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.PictureBox pctresim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtresimyolu;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResimAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}