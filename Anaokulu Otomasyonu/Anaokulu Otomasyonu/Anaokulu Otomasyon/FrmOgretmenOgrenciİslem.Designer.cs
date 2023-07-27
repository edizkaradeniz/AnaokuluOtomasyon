namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmenOgrenciİslem
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
            this.grpOgrenciAra = new System.Windows.Forms.GroupBox();
            this.btndonemiara = new System.Windows.Forms.Button();
            this.cmbsinifara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnsinifara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridogrlistele = new System.Windows.Forms.DataGridView();
            this.grpOgrenciAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridogrlistele)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOgrenciAra
            // 
            this.grpOgrenciAra.Controls.Add(this.btndonemiara);
            this.grpOgrenciAra.Controls.Add(this.cmbsinifara);
            this.grpOgrenciAra.Controls.Add(this.label1);
            this.grpOgrenciAra.Controls.Add(this.cmbdonemara);
            this.grpOgrenciAra.Controls.Add(this.label15);
            this.grpOgrenciAra.Controls.Add(this.btnsinifara);
            this.grpOgrenciAra.Controls.Add(this.btnyenile);
            this.grpOgrenciAra.Controls.Add(this.dtgridogrlistele);
            this.grpOgrenciAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgrenciAra.Location = new System.Drawing.Point(55, 12);
            this.grpOgrenciAra.Name = "grpOgrenciAra";
            this.grpOgrenciAra.Size = new System.Drawing.Size(826, 416);
            this.grpOgrenciAra.TabIndex = 3;
            this.grpOgrenciAra.TabStop = false;
            this.grpOgrenciAra.Text = "Öğrenci Ara";
            // 
            // btndonemiara
            // 
            this.btndonemiara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndonemiara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btndonemiara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndonemiara.Location = new System.Drawing.Point(230, 45);
            this.btndonemiara.Name = "btndonemiara";
            this.btndonemiara.Size = new System.Drawing.Size(106, 30);
            this.btndonemiara.TabIndex = 44;
            this.btndonemiara.Text = "Ara";
            this.btndonemiara.UseVisualStyleBackColor = false;
            this.btndonemiara.Click += new System.EventHandler(this.btndonemiara_Click);
            // 
            // cmbsinifara
            // 
            this.cmbsinifara.FormattingEnabled = true;
            this.cmbsinifara.Items.AddRange(new object[] {
            "Ocean",
            "Disney",
            "Rainbow"});
            this.cmbsinifara.Location = new System.Drawing.Point(89, 14);
            this.cmbsinifara.Name = "cmbsinifara";
            this.cmbsinifara.Size = new System.Drawing.Size(135, 21);
            this.cmbsinifara.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sınıf:";
            // 
            // cmbdonemara
            // 
            this.cmbdonemara.FormattingEnabled = true;
            this.cmbdonemara.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cmbdonemara.Location = new System.Drawing.Point(89, 51);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(135, 21);
            this.cmbdonemara.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Dönemi:";
            // 
            // btnsinifara
            // 
            this.btnsinifara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnsinifara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnsinifara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsinifara.Location = new System.Drawing.Point(230, 8);
            this.btnsinifara.Name = "btnsinifara";
            this.btnsinifara.Size = new System.Drawing.Size(106, 30);
            this.btnsinifara.TabIndex = 39;
            this.btnsinifara.Text = "Ara";
            this.btnsinifara.UseVisualStyleBackColor = false;
            this.btnsinifara.Click += new System.EventHandler(this.btnsinifara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(354, 14);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dtgridogrlistele
            // 
            this.dtgridogrlistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridogrlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridogrlistele.Location = new System.Drawing.Point(0, 76);
            this.dtgridogrlistele.Name = "dtgridogrlistele";
            this.dtgridogrlistele.Size = new System.Drawing.Size(820, 334);
            this.dtgridogrlistele.TabIndex = 15;
            // 
            // FrmOgretmenOgrenciİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.grpOgrenciAra);
            this.Name = "FrmOgretmenOgrenciİslem";
            this.Load += new System.EventHandler(this.FrmOgretmenOgrenciİslem_Load);
            this.grpOgrenciAra.ResumeLayout(false);
            this.grpOgrenciAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridogrlistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenciAra;
        private System.Windows.Forms.ComboBox cmbsinifara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnsinifara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.DataGridView dtgridogrlistele;
        private System.Windows.Forms.Button btndonemiara;
    }
}