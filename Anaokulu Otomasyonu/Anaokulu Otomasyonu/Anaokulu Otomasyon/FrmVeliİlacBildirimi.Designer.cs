namespace Anaokulu_Otomasyon
{
    partial class FrmVeliİlacBildirimi
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
            this.dtgridilacbildirim = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridilacbildirim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.dtgridilacbildirim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Bildirimi";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(291, 33);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(105, 42);
            this.btnara.TabIndex = 44;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tarih:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(85, 42);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(200, 21);
            this.dttarih.TabIndex = 42;
            // 
            // dtgridilacbildirim
            // 
            this.dtgridilacbildirim.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgridilacbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridilacbildirim.Location = new System.Drawing.Point(6, 96);
            this.dtgridilacbildirim.Name = "dtgridilacbildirim";
            this.dtgridilacbildirim.Size = new System.Drawing.Size(531, 258);
            this.dtgridilacbildirim.TabIndex = 0;
            // 
            // FrmVeliİlacBildirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliİlacBildirimi";
            this.Load += new System.EventHandler(this.FrmVeliİlacBildirimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridilacbildirim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgridilacbildirim;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttarih;
    }
}