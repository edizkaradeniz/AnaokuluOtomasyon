namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmenİlacİslem
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
            this.cmbsinif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.dtgridviewİlac = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewİlac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbsinif);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnara);
            this.groupBox3.Controls.Add(this.dtgridviewİlac);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(34, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 387);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İlaç Listesi";
            // 
            // cmbsinif
            // 
            this.cmbsinif.FormattingEnabled = true;
            this.cmbsinif.Items.AddRange(new object[] {
            "Ocean",
            "Disney",
            "Rainbow"});
            this.cmbsinif.Location = new System.Drawing.Point(722, 33);
            this.cmbsinif.Name = "cmbsinif";
            this.cmbsinif.Size = new System.Drawing.Size(144, 23);
            this.cmbsinif.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(658, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Sınıf:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(722, 86);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(144, 42);
            this.btnara.TabIndex = 44;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // dtgridviewİlac
            // 
            this.dtgridviewİlac.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridviewİlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridviewİlac.Location = new System.Drawing.Point(6, 33);
            this.dtgridviewİlac.Name = "dtgridviewİlac";
            this.dtgridviewİlac.Size = new System.Drawing.Size(646, 349);
            this.dtgridviewİlac.TabIndex = 0;
            // 
            // FrmOgretmenİlacİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmOgretmenİlacİslem";
            this.Load += new System.EventHandler(this.FrmOgretmenİlacİslem_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewİlac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgridviewİlac;
        private System.Windows.Forms.ComboBox cmbsinif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnara;
    }
}