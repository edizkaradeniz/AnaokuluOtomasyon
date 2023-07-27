namespace Anaokulu_Otomasyon
{
    partial class FrmVeliDers
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rchaciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgdersgoruntule = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdersgoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rchaciklama);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtgdersgoruntule);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(844, 426);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(518, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Açıklama:";
            // 
            // rchaciklama
            // 
            this.rchaciklama.Enabled = false;
            this.rchaciklama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchaciklama.Location = new System.Drawing.Point(609, 116);
            this.rchaciklama.Name = "rchaciklama";
            this.rchaciklama.Size = new System.Drawing.Size(215, 132);
            this.rchaciklama.TabIndex = 17;
            this.rchaciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Öğrencinin Gördüğü Dersler";
            // 
            // dtgdersgoruntule
            // 
            this.dtgdersgoruntule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgdersgoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdersgoruntule.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgdersgoruntule.Location = new System.Drawing.Point(30, 65);
            this.dtgdersgoruntule.Name = "dtgdersgoruntule";
            this.dtgdersgoruntule.Size = new System.Drawing.Size(482, 355);
            this.dtgdersgoruntule.TabIndex = 15;
            this.dtgdersgoruntule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdersgoruntule_CellClick);
            // 
            // FrmVeliDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmVeliDers";
            this.Load += new System.EventHandler(this.FrmVeliDers_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdersgoruntule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgdersgoruntule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchaciklama;
        public System.Windows.Forms.Label label1;
    }
}