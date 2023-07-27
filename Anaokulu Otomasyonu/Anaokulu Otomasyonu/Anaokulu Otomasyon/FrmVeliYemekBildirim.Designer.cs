namespace Anaokulu_Otomasyon
{
    partial class FrmVeliYemekBildirim
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
            this.dtgridyemekbildirim = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnara = new System.Windows.Forms.Button();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemekbildirim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgridyemekbildirim
            // 
            this.dtgridyemekbildirim.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgridyemekbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridyemekbildirim.Location = new System.Drawing.Point(0, 85);
            this.dtgridyemekbildirim.Name = "dtgridyemekbildirim";
            this.dtgridyemekbildirim.Size = new System.Drawing.Size(591, 333);
            this.dtgridyemekbildirim.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.dtgridyemekbildirim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(180, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Bildirimi";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(350, 37);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(124, 42);
            this.btnara.TabIndex = 37;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(107, 46);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(189, 21);
            this.dttarih.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(42, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 20);
            this.label23.TabIndex = 35;
            this.label23.Text = "Tarih:";
            // 
            // FrmVeliYemekBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliYemekBildirim";
            this.Load += new System.EventHandler(this.FrmVeliYemekBildirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridyemekbildirim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridyemekbildirim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label23;
    }
}