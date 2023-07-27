namespace Anaokulu_Otomasyon
{
    partial class FrmVeliEtkinlik
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
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgridEtkinlik = new System.Windows.Forms.DataGridView();
            this.txtetkinlikbaslik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rchetkinlikbilgi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridEtkinlik)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtgridEtkinlik);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etkinlik";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(345, 15);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(89, 42);
            this.btnara.TabIndex = 49;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(107, 24);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(190, 21);
            this.dttarih.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tarih:";
            // 
            // dtgridEtkinlik
            // 
            this.dtgridEtkinlik.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgridEtkinlik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridEtkinlik.Location = new System.Drawing.Point(0, 63);
            this.dtgridEtkinlik.Name = "dtgridEtkinlik";
            this.dtgridEtkinlik.Size = new System.Drawing.Size(652, 353);
            this.dtgridEtkinlik.TabIndex = 0;
            this.dtgridEtkinlik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridEtkinlik_CellClick);
            // 
            // txtetkinlikbaslik
            // 
            this.txtetkinlikbaslik.Enabled = false;
            this.txtetkinlikbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtetkinlikbaslik.Location = new System.Drawing.Point(765, 13);
            this.txtetkinlikbaslik.Name = "txtetkinlikbaslik";
            this.txtetkinlikbaslik.Size = new System.Drawing.Size(190, 26);
            this.txtetkinlikbaslik.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(661, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Etkinlik Başlığı:";
            // 
            // rchetkinlikbilgi
            // 
            this.rchetkinlikbilgi.Enabled = false;
            this.rchetkinlikbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchetkinlikbilgi.Location = new System.Drawing.Point(766, 48);
            this.rchetkinlikbilgi.Name = "rchetkinlikbilgi";
            this.rchetkinlikbilgi.Size = new System.Drawing.Size(190, 372);
            this.rchetkinlikbilgi.TabIndex = 22;
            this.rchetkinlikbilgi.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(661, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Etkinlik Bilgi:";
            // 
            // FrmVeliEtkinlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.rchetkinlikbilgi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtetkinlikbaslik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliEtkinlik";
            this.Text = "FrmVeliEtkinlik";
            this.Load += new System.EventHandler(this.FrmVeliEtkinlik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridEtkinlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgridEtkinlik;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtetkinlikbaslik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchetkinlikbilgi;
        private System.Windows.Forms.Label label5;
    }
}