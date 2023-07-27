namespace Anaokulu_Otomasyon
{
    partial class FrmVeliÖdemeler
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
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.dtgridodemeler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridodemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.dtgridodemeler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(191, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödemeler";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(139, 43);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(190, 21);
            this.dttarih.TabIndex = 58;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(32, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 57;
            this.label17.Text = "Tarih:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(395, 34);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(89, 42);
            this.btnara.TabIndex = 56;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dtgridodemeler
            // 
            this.dtgridodemeler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgridodemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridodemeler.Location = new System.Drawing.Point(0, 102);
            this.dtgridodemeler.Name = "dtgridodemeler";
            this.dtgridodemeler.Size = new System.Drawing.Size(591, 304);
            this.dtgridodemeler.TabIndex = 0;
            // 
            // FrmVeliÖdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliÖdemeler";
            this.Load += new System.EventHandler(this.FrmVeliÖdemeler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridodemeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgridodemeler;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnara;
    }
}