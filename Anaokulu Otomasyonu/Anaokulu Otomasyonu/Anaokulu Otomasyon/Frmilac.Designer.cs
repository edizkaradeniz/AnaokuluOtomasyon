namespace Anaokulu_Otomasyon
{
    partial class Frmilac
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
            this.label14 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgridilac = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridilac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsinif);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.btnyenile);
            this.groupBox1.Controls.Add(this.txtOgrenci);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtgridilac);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(180, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Listesi";
            // 
            // cmbsinif
            // 
            this.cmbsinif.FormattingEnabled = true;
            this.cmbsinif.Location = new System.Drawing.Point(168, 71);
            this.cmbsinif.Name = "cmbsinif";
            this.cmbsinif.Size = new System.Drawing.Size(160, 21);
            this.cmbsinif.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(7, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "Sınıf:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(365, 57);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(127, 35);
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
            this.btnyenile.Location = new System.Drawing.Point(360, 10);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(132, 44);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(168, 32);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(160, 22);
            this.txtOgrenci.TabIndex = 34;
            this.txtOgrenci.TextChanged += new System.EventHandler(this.txtOgrenci_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Öğrenci Ad ve Soyad:";
            // 
            // dtgridilac
            // 
            this.dtgridilac.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridilac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridilac.Location = new System.Drawing.Point(6, 94);
            this.dtgridilac.Name = "dtgridilac";
            this.dtgridilac.Size = new System.Drawing.Size(646, 291);
            this.dtgridilac.TabIndex = 31;
            // 
            // Frmilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 496);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmilac";
            this.Load += new System.EventHandler(this.Frmilac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridilac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOgrenci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgridilac;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.ComboBox cmbsinif;
        private System.Windows.Forms.Label label14;
    }
}