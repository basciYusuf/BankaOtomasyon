namespace Banka_Otomasyon1._1
{
    partial class FrmHavale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHavale));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TxtAliciBakiye = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBireysel = new System.Windows.Forms.RadioButton();
            this.RadioTicari = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEye = new System.Windows.Forms.Button();
            this.TxtHesapNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGonder = new System.Windows.Forms.Button();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAliciHesapNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTicariDogrula = new System.Windows.Forms.Label();
            this.TxtBankaHesabi = new System.Windows.Forms.TextBox();
            this.TxtYuzde2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Banka_Otomasyon1._1.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(516, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 72);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çiftlik   bank";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.White;
            this.btnGeri.ImageKey = "geri_ikonu.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(4, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(58, 31);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri_ikonu.png");
            this.ımageList1.Images.SetKeyName(1, "eye-icon-1462.png");
            // 
            // TxtAliciBakiye
            // 
            this.TxtAliciBakiye.Location = new System.Drawing.Point(744, 237);
            this.TxtAliciBakiye.Name = "TxtAliciBakiye";
            this.TxtAliciBakiye.Size = new System.Drawing.Size(100, 22);
            this.TxtAliciBakiye.TabIndex = 2;
            this.TxtAliciBakiye.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.RadioBireysel);
            this.groupBox1.Controls.Add(this.RadioTicari);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dateTarih);
            this.groupBox1.Controls.Add(this.btnEye);
            this.groupBox1.Controls.Add(this.TxtHesapNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtBakiye);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtAliciHesapNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtSifre);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // RadioBireysel
            // 
            this.RadioBireysel.AutoSize = true;
            this.RadioBireysel.Enabled = false;
            this.RadioBireysel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBireysel.Location = new System.Drawing.Point(152, 285);
            this.RadioBireysel.Name = "RadioBireysel";
            this.RadioBireysel.Size = new System.Drawing.Size(152, 26);
            this.RadioBireysel.TabIndex = 24;
            this.RadioBireysel.TabStop = true;
            this.RadioBireysel.Text = "Bireysel Hesap";
            this.RadioBireysel.UseVisualStyleBackColor = true;
            this.RadioBireysel.CheckedChanged += new System.EventHandler(this.RadioBireysel_CheckedChanged);
            // 
            // RadioTicari
            // 
            this.RadioTicari.AutoSize = true;
            this.RadioTicari.Enabled = false;
            this.RadioTicari.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioTicari.Location = new System.Drawing.Point(152, 264);
            this.RadioTicari.Name = "RadioTicari";
            this.RadioTicari.Size = new System.Drawing.Size(135, 26);
            this.RadioTicari.TabIndex = 23;
            this.RadioTicari.TabStop = true;
            this.RadioTicari.Text = "Ticari Hesap";
            this.RadioTicari.UseVisualStyleBackColor = true;
            this.RadioTicari.CheckedChanged += new System.EventHandler(this.RadioTicari_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hesap:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banka_Otomasyon1._1.Properties.Resources.banka;
            this.pictureBox1.Location = new System.Drawing.Point(327, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // dateTarih
            // 
            this.dateTarih.Location = new System.Drawing.Point(346, 149);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(294, 32);
            this.dateTarih.TabIndex = 20;
            // 
            // btnEye
            // 
            this.btnEye.BackColor = System.Drawing.Color.White;
            this.btnEye.ImageKey = "eye-icon-1462.png";
            this.btnEye.ImageList = this.ımageList1;
            this.btnEye.Location = new System.Drawing.Point(254, 213);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(33, 32);
            this.btnEye.TabIndex = 19;
            this.btnEye.UseVisualStyleBackColor = false;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // TxtHesapNo
            // 
            this.TxtHesapNo.Location = new System.Drawing.Point(175, 70);
            this.TxtHesapNo.Name = "TxtHesapNo";
            this.TxtHesapNo.Size = new System.Drawing.Size(112, 32);
            this.TxtHesapNo.TabIndex = 18;
            this.TxtHesapNo.TextChanged += new System.EventHandler(this.TxtHesaspNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hesap No:";
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Enabled = false;
            this.TxtBakiye.Location = new System.Drawing.Point(175, 329);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(112, 32);
            this.TxtBakiye.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(306, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 343);
            this.panel2.TabIndex = 15;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.Black;
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(528, 211);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(112, 34);
            this.btnGonder.TabIndex = 14;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(528, 101);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(112, 32);
            this.TxtMiktar.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gönderilecek Miktar:";
            // 
            // TxtAliciHesapNo
            // 
            this.TxtAliciHesapNo.Location = new System.Drawing.Point(528, 59);
            this.TxtAliciHesapNo.Name = "TxtAliciHesapNo";
            this.TxtAliciHesapNo.Size = new System.Drawing.Size(112, 32);
            this.TxtAliciHesapNo.TabIndex = 11;
            this.TxtAliciHesapNo.TextChanged += new System.EventHandler(this.TxtAliciHesapNo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Alıcı Hesap No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bakiyeniz:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(175, 213);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(73, 32);
            this.TxtSifre.TabIndex = 6;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(175, 166);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(112, 32);
            this.TxtSoyad.TabIndex = 5;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(175, 121);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(112, 32);
            this.TxtAd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(624, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "--------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Müşteri Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Ad:";
            // 
            // lblTicariDogrula
            // 
            this.lblTicariDogrula.AutoSize = true;
            this.lblTicariDogrula.Location = new System.Drawing.Point(771, 218);
            this.lblTicariDogrula.Name = "lblTicariDogrula";
            this.lblTicariDogrula.Size = new System.Drawing.Size(51, 16);
            this.lblTicariDogrula.TabIndex = 3;
            this.lblTicariDogrula.Text = "label11";
            this.lblTicariDogrula.TextChanged += new System.EventHandler(this.lblTicariDogrula_TextChanged);
            // 
            // TxtBankaHesabi
            // 
            this.TxtBankaHesabi.Location = new System.Drawing.Point(744, 278);
            this.TxtBankaHesabi.Name = "TxtBankaHesabi";
            this.TxtBankaHesabi.Size = new System.Drawing.Size(100, 22);
            this.TxtBankaHesabi.TabIndex = 4;
            this.TxtBankaHesabi.Visible = false;
            // 
            // TxtYuzde2
            // 
            this.TxtYuzde2.Location = new System.Drawing.Point(744, 315);
            this.TxtYuzde2.Name = "TxtYuzde2";
            this.TxtYuzde2.Size = new System.Drawing.Size(100, 22);
            this.TxtYuzde2.TabIndex = 5;
            this.TxtYuzde2.Visible = false;
            // 
            // FrmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 636);
            this.Controls.Add(this.TxtYuzde2);
            this.Controls.Add(this.TxtBankaHesabi);
            this.Controls.Add(this.lblTicariDogrula);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtAliciBakiye);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHavale";
            this.Text = "FrmHavale";
            this.Load += new System.EventHandler(this.FrmHavale_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtAliciHesapNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox TxtHesapNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBakiye;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.TextBox TxtAliciBakiye;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RadioBireysel;
        private System.Windows.Forms.RadioButton RadioTicari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTicariDogrula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtBankaHesabi;
        private System.Windows.Forms.TextBox TxtYuzde2;
    }
}