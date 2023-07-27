namespace Anaokulu_Otomasyon
{
    partial class FrmVeliDersProgramı
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
            this.dtgriddersprogrami = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dttarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriddersprogrami)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgriddersprogrami
            // 
            this.dtgriddersprogrami.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgriddersprogrami.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgriddersprogrami.Location = new System.Drawing.Point(6, 143);
            this.dtgriddersprogrami.Name = "dtgriddersprogrami";
            this.dtgriddersprogrami.Size = new System.Drawing.Size(870, 277);
            this.dtgriddersprogrami.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dttarih);
            this.groupBox1.Controls.Add(this.dtgriddersprogrami);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Programı";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(337, 42);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(105, 42);
            this.btnara.TabIndex = 35;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tarih:";
            // 
            // dttarih
            // 
            this.dttarih.Location = new System.Drawing.Point(92, 52);
            this.dttarih.Name = "dttarih";
            this.dttarih.Size = new System.Drawing.Size(200, 21);
            this.dttarih.TabIndex = 1;
            // 
            // FrmVeliDersProgramı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVeliDersProgramı";
            this.Load += new System.EventHandler(this.FrmVeliDersProgramı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgriddersprogrami)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgriddersprogrami;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dttarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnara;
    }
}