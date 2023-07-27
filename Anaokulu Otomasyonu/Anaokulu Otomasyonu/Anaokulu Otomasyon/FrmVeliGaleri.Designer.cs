namespace Anaokulu_Otomasyon
{
    partial class FrmVeliGaleri
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
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btngeri);
            this.groupBox5.Controls.Add(this.btnileri);
            this.groupBox5.Controls.Add(this.pctresim);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(165, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(648, 416);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resim Görüntüle";
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(60, 334);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(100, 34);
            this.btngeri.TabIndex = 2;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnileri
            // 
            this.btnileri.Location = new System.Drawing.Point(418, 334);
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
            this.pctresim.Size = new System.Drawing.Size(636, 309);
            this.pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctresim.TabIndex = 0;
            this.pctresim.TabStop = false;
            // 
            // FrmVeliGaleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.groupBox5);
            this.Name = "FrmVeliGaleri";
            this.Text = "FrmVeliGaleri";
            this.Load += new System.EventHandler(this.FrmVeliGaleri_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctresim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.PictureBox pctresim;
    }
}