namespace Anaokulu_Otomasyon
{
    partial class FrmOgretmenVeliislem
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
            this.txtveliadara = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbdonemara = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.dtgridvelilistele = new System.Windows.Forms.DataGridView();
            this.grpOgrenciAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvelilistele)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOgrenciAra
            // 
            this.grpOgrenciAra.Controls.Add(this.txtveliadara);
            this.grpOgrenciAra.Controls.Add(this.label23);
            this.grpOgrenciAra.Controls.Add(this.cmbdonemara);
            this.grpOgrenciAra.Controls.Add(this.label18);
            this.grpOgrenciAra.Controls.Add(this.btnara);
            this.grpOgrenciAra.Controls.Add(this.btnyenile);
            this.grpOgrenciAra.Controls.Add(this.dtgridvelilistele);
            this.grpOgrenciAra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgrenciAra.Location = new System.Drawing.Point(97, 12);
            this.grpOgrenciAra.Name = "grpOgrenciAra";
            this.grpOgrenciAra.Size = new System.Drawing.Size(782, 403);
            this.grpOgrenciAra.TabIndex = 5;
            this.grpOgrenciAra.TabStop = false;
            this.grpOgrenciAra.Text = "Veli Ara";
            // 
            // txtveliadara
            // 
            this.txtveliadara.Location = new System.Drawing.Point(101, 11);
            this.txtveliadara.Name = "txtveliadara";
            this.txtveliadara.Size = new System.Drawing.Size(165, 22);
            this.txtveliadara.TabIndex = 47;
            this.txtveliadara.TextChanged += new System.EventHandler(this.txtveliadara_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(6, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(81, 20);
            this.label23.TabIndex = 46;
            this.label23.Text = "Ad-Soyad:";
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
            this.cmbdonemara.Location = new System.Drawing.Point(106, 59);
            this.cmbdonemara.Name = "cmbdonemara";
            this.cmbdonemara.Size = new System.Drawing.Size(160, 21);
            this.cmbdonemara.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "Dönemi:";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnara.Image = global::Anaokulu_Otomasyon.Properties.Resources.search;
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(293, 38);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(106, 42);
            this.btnara.TabIndex = 39;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyenile.Image = global::Anaokulu_Otomasyon.Properties.Resources.loop;
            this.btnyenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyenile.Location = new System.Drawing.Point(445, 38);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(99, 42);
            this.btnyenile.TabIndex = 38;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // dtgridvelilistele
            // 
            this.dtgridvelilistele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridvelilistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridvelilistele.Location = new System.Drawing.Point(0, 83);
            this.dtgridvelilistele.Name = "dtgridvelilistele";
            this.dtgridvelilistele.Size = new System.Drawing.Size(779, 314);
            this.dtgridvelilistele.TabIndex = 15;
            // 
            // FrmOgretmenVeliislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.grpOgrenciAra);
            this.Name = "FrmOgretmenVeliislem";
            this.Load += new System.EventHandler(this.FrmOgretmenVeliislem_Load);
            this.grpOgrenciAra.ResumeLayout(false);
            this.grpOgrenciAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvelilistele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenciAra;
        private System.Windows.Forms.ComboBox cmbdonemara;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.DataGridView dtgridvelilistele;
        private System.Windows.Forms.TextBox txtveliadara;
        private System.Windows.Forms.Label label23;
    }
}