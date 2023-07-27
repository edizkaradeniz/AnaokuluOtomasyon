namespace Anaokulu_Otomasyon
{
    partial class FrmVeliDuyuru
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
            this.dtgridviewduyuru = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.txtduyurubaslik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rchicerik = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewduyuru)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgridviewduyuru
            // 
            this.dtgridviewduyuru.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgridviewduyuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridviewduyuru.Location = new System.Drawing.Point(0, 65);
            this.dtgridviewduyuru.Name = "dtgridviewduyuru";
            this.dtgridviewduyuru.Size = new System.Drawing.Size(505, 319);
            this.dtgridviewduyuru.TabIndex = 0;
            this.dtgridviewduyuru.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridviewduyuru_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.dtgridviewduyuru);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duyuru";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(322, 17);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(105, 42);
            this.btnara.TabIndex = 38;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tarih:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(77, 27);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(200, 21);
            this.dttarih.TabIndex = 36;
            // 
            // txtduyurubaslik
            // 
            this.txtduyurubaslik.Enabled = false;
            this.txtduyurubaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtduyurubaslik.Location = new System.Drawing.Point(642, 8);
            this.txtduyurubaslik.Name = "txtduyurubaslik";
            this.txtduyurubaslik.Size = new System.Drawing.Size(190, 26);
            this.txtduyurubaslik.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(521, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Duyuru Başlığı:";
            // 
            // rchicerik
            // 
            this.rchicerik.Enabled = false;
            this.rchicerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchicerik.Location = new System.Drawing.Point(640, 47);
            this.rchicerik.Name = "rchicerik";
            this.rchicerik.Size = new System.Drawing.Size(305, 375);
            this.rchicerik.TabIndex = 22;
            this.rchicerik.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(521, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Duyuru İçeriği:";
            // 
            // FrmVeliDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.rchicerik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtduyurubaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliDuyuru";
            this.Text = "FrmVeliDuyuru";
            this.Load += new System.EventHandler(this.FrmVeliDuyuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewduyuru)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridviewduyuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtduyurubaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchicerik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttarih;
    }
}