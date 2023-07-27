namespace Anaokulu_Otomasyon
{
    partial class FrmVeliYemekListesi
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
            this.btnara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.dtgridyemeklistesi = new System.Windows.Forms.DataGridView();
            this.rchikindi = new System.Windows.Forms.RichTextBox();
            this.rchogle = new System.Windows.Forms.RichTextBox();
            this.rchsabah = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemeklistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.dtgridyemeklistesi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Listesi";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(342, 34);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(105, 42);
            this.btnara.TabIndex = 41;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tarih:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(97, 44);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(200, 21);
            this.dttarih.TabIndex = 39;
            // 
            // dtgridyemeklistesi
            // 
            this.dtgridyemeklistesi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgridyemeklistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridyemeklistesi.Location = new System.Drawing.Point(0, 109);
            this.dtgridyemeklistesi.Name = "dtgridyemeklistesi";
            this.dtgridyemeklistesi.Size = new System.Drawing.Size(670, 311);
            this.dtgridyemeklistesi.TabIndex = 0;
            this.dtgridyemeklistesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridyemeklistesi_CellClick);
            // 
            // rchikindi
            // 
            this.rchikindi.Enabled = false;
            this.rchikindi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchikindi.Location = new System.Drawing.Point(748, 270);
            this.rchikindi.Name = "rchikindi";
            this.rchikindi.Size = new System.Drawing.Size(149, 138);
            this.rchikindi.TabIndex = 26;
            this.rchikindi.Text = "";
            // 
            // rchogle
            // 
            this.rchogle.Enabled = false;
            this.rchogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchogle.Location = new System.Drawing.Point(748, 130);
            this.rchogle.Name = "rchogle";
            this.rchogle.Size = new System.Drawing.Size(149, 121);
            this.rchogle.TabIndex = 25;
            this.rchogle.Text = "";
            // 
            // rchsabah
            // 
            this.rchsabah.Enabled = false;
            this.rchsabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchsabah.Location = new System.Drawing.Point(748, 9);
            this.rchsabah.Name = "rchsabah";
            this.rchsabah.Size = new System.Drawing.Size(149, 106);
            this.rchsabah.TabIndex = 24;
            this.rchsabah.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(682, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sabah:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(676, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "İkindi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(683, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Öğle:";
            // 
            // FrmVeliYemekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.rchikindi);
            this.Controls.Add(this.rchogle);
            this.Controls.Add(this.rchsabah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliYemekListesi";
            this.Text = "FrmVeliYemekListesi";
            this.Load += new System.EventHandler(this.FrmVeliYemekListesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemeklistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgridyemeklistesi;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.RichTextBox rchikindi;
        private System.Windows.Forms.RichTextBox rchogle;
        private System.Windows.Forms.RichTextBox rchsabah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}