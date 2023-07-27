namespace Anaokulu_Otomasyon
{
    partial class FrmGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsaat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYönetici = new System.Windows.Forms.Button();
            this.txtsifreyönetici = new System.Windows.Forms.TextBox();
            this.txtkuladyönetici = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnögretmen = new System.Windows.Forms.Button();
            this.txtsifreogretmen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtkuladogretmen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnveli = new System.Windows.Forms.Button();
            this.txtsifreveli = new System.Windows.Forms.TextBox();
            this.txtkuladveli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblsaat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 440);
            this.panel1.TabIndex = 1;
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsaat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsaat.Location = new System.Drawing.Point(703, 9);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(19, 20);
            this.lblsaat.TabIndex = 7;
            this.lblsaat.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(241, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 124);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "KULLANICI GİRİŞİ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYönetici);
            this.groupBox1.Controls.Add(this.txtsifreyönetici);
            this.groupBox1.Controls.Add(this.txtkuladyönetici);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 211);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YÖNETİCİ GİRİŞ";
            // 
            // btnYönetici
            // 
            this.btnYönetici.BackColor = System.Drawing.Color.Blue;
            this.btnYönetici.Location = new System.Drawing.Point(120, 154);
            this.btnYönetici.Name = "btnYönetici";
            this.btnYönetici.Size = new System.Drawing.Size(119, 36);
            this.btnYönetici.TabIndex = 4;
            this.btnYönetici.Text = "Giriş Yap";
            this.btnYönetici.UseVisualStyleBackColor = false;
            this.btnYönetici.Click += new System.EventHandler(this.btnYönetici_Click);
            // 
            // txtsifreyönetici
            // 
            this.txtsifreyönetici.Location = new System.Drawing.Point(120, 87);
            this.txtsifreyönetici.Name = "txtsifreyönetici";
            this.txtsifreyönetici.PasswordChar = '*';
            this.txtsifreyönetici.Size = new System.Drawing.Size(119, 21);
            this.txtsifreyönetici.TabIndex = 3;
            // 
            // txtkuladyönetici
            // 
            this.txtkuladyönetici.Location = new System.Drawing.Point(120, 28);
            this.txtkuladyönetici.Name = "txtkuladyönetici";
            this.txtkuladyönetici.Size = new System.Drawing.Size(119, 21);
            this.txtkuladyönetici.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnögretmen);
            this.groupBox2.Controls.Add(this.txtsifreogretmen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtkuladogretmen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(307, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 211);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÖĞRETMEN GİRİŞ";
            // 
            // btnögretmen
            // 
            this.btnögretmen.BackColor = System.Drawing.Color.Blue;
            this.btnögretmen.Location = new System.Drawing.Point(142, 154);
            this.btnögretmen.Name = "btnögretmen";
            this.btnögretmen.Size = new System.Drawing.Size(119, 36);
            this.btnögretmen.TabIndex = 6;
            this.btnögretmen.Text = "Giriş Yap";
            this.btnögretmen.UseVisualStyleBackColor = false;
            this.btnögretmen.Click += new System.EventHandler(this.btnögretmen_Click);
            // 
            // txtsifreogretmen
            // 
            this.txtsifreogretmen.Location = new System.Drawing.Point(142, 93);
            this.txtsifreogretmen.Name = "txtsifreogretmen";
            this.txtsifreogretmen.PasswordChar = '*';
            this.txtsifreogretmen.Size = new System.Drawing.Size(119, 21);
            this.txtsifreogretmen.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Şifre:";
            // 
            // txtkuladogretmen
            // 
            this.txtkuladogretmen.Location = new System.Drawing.Point(142, 34);
            this.txtkuladogretmen.Name = "txtkuladogretmen";
            this.txtkuladogretmen.Size = new System.Drawing.Size(119, 21);
            this.txtkuladogretmen.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnveli);
            this.groupBox3.Controls.Add(this.txtsifreveli);
            this.groupBox3.Controls.Add(this.txtkuladveli);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(597, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VELİ GİRİŞ";
            // 
            // btnveli
            // 
            this.btnveli.BackColor = System.Drawing.Color.Blue;
            this.btnveli.Location = new System.Drawing.Point(133, 154);
            this.btnveli.Name = "btnveli";
            this.btnveli.Size = new System.Drawing.Size(119, 36);
            this.btnveli.TabIndex = 6;
            this.btnveli.Text = "Giriş Yap";
            this.btnveli.UseVisualStyleBackColor = false;
            this.btnveli.Click += new System.EventHandler(this.btnveli_Click);
            // 
            // txtsifreveli
            // 
            this.txtsifreveli.Location = new System.Drawing.Point(133, 87);
            this.txtsifreveli.Name = "txtsifreveli";
            this.txtsifreveli.PasswordChar = '*';
            this.txtsifreveli.Size = new System.Drawing.Size(119, 21);
            this.txtsifreveli.TabIndex = 5;
            // 
            // txtkuladveli
            // 
            this.txtkuladveli.Location = new System.Drawing.Point(133, 28);
            this.txtkuladveli.Name = "txtkuladveli";
            this.txtkuladveli.Size = new System.Drawing.Size(119, 21);
            this.txtkuladveli.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Şifre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kullanıcı Adı:";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 440);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGiris";
            this.Text = "MİNİKLER KALESİ ANAOKUL OTOMASYONU";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnYönetici;
        private System.Windows.Forms.TextBox txtsifreyönetici;
        private System.Windows.Forms.TextBox txtkuladyönetici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnögretmen;
        private System.Windows.Forms.TextBox txtsifreogretmen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkuladogretmen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnveli;
        private System.Windows.Forms.TextBox txtsifreveli;
        private System.Windows.Forms.TextBox txtkuladveli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}