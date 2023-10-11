namespace Banka_Otomasyon1._1
{
    partial class FrmHesapGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHesapGecmisi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDogrula = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeTarih2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTarih1 = new System.Windows.Forms.DateTimePicker();
            this.btnGoster = new System.Windows.Forms.Button();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioBireysel = new System.Windows.Forms.RadioButton();
            this.RadioTicari = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtHesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewYatir = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHavale = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCekim = new System.Windows.Forms.DataGridView();
            this.banka_OtomasyonDataSet7 = new Banka_Otomasyon1._1.Banka_OtomasyonDataSet7();
            this.tblYatirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_YatirTableAdapter = new Banka_Otomasyon1._1.Banka_OtomasyonDataSet7TableAdapters.Tbl_YatirTableAdapter();
            this.banka_OtomasyonDataSet8 = new Banka_Otomasyon1._1.Banka_OtomasyonDataSet8();
            this.tblHavaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_HavaleTableAdapter = new Banka_Otomasyon1._1.Banka_OtomasyonDataSet8TableAdapters.Tbl_HavaleTableAdapter();
            this.banka_OtomasyonDataSet9 = new Banka_Otomasyon1._1.Banka_OtomasyonDataSet9();
            this.tblCekimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CekimTableAdapter = new Banka_Otomasyon1._1.Banka_OtomasyonDataSet9TableAdapters.Tbl_CekimTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYatir)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHavale)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_OtomasyonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYatirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_OtomasyonDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHavaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_OtomasyonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCekimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.lblDogrula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1590, 100);
            this.panel1.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri_ikonu.png");
            // 
            // lblDogrula
            // 
            this.lblDogrula.AutoSize = true;
            this.lblDogrula.Location = new System.Drawing.Point(1127, 54);
            this.lblDogrula.Name = "lblDogrula";
            this.lblDogrula.Size = new System.Drawing.Size(44, 16);
            this.lblDogrula.TabIndex = 1;
            this.lblDogrula.Text = "label7";
            this.lblDogrula.Visible = false;
            this.lblDogrula.TextChanged += new System.EventHandler(this.lblDogrula_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimeTarih2);
            this.groupBox1.Controls.Add(this.dateTimeTarih1);
            this.groupBox1.Controls.Add(this.btnGoster);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TxtBakiye);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RadioBireysel);
            this.groupBox1.Controls.Add(this.RadioTicari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtHesapNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(219, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Hesap Bilgileri";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(351, 125);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(121, 32);
            this.TxtSoyad.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(351, 75);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(121, 32);
            this.TxtAd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ad:";
            // 
            // dateTimeTarih2
            // 
            this.dateTimeTarih2.CalendarFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTarih2.Location = new System.Drawing.Point(807, 124);
            this.dateTimeTarih2.Name = "dateTimeTarih2";
            this.dateTimeTarih2.Size = new System.Drawing.Size(200, 32);
            this.dateTimeTarih2.TabIndex = 14;
            // 
            // dateTimeTarih1
            // 
            this.dateTimeTarih1.CalendarFont = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTarih1.Location = new System.Drawing.Point(807, 72);
            this.dateTimeTarih1.Name = "dateTimeTarih1";
            this.dateTimeTarih1.Size = new System.Drawing.Size(200, 32);
            this.dateTimeTarih1.TabIndex = 13;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Black;
            this.btnGoster.ForeColor = System.Drawing.Color.White;
            this.btnGoster.Location = new System.Drawing.Point(807, 183);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(200, 44);
            this.btnGoster.TabIndex = 12;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Enabled = false;
            this.TxtBakiye.Location = new System.Drawing.Point(807, 25);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(200, 32);
            this.TxtBakiye.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bakiye:";
            // 
            // RadioBireysel
            // 
            this.RadioBireysel.AutoSize = true;
            this.RadioBireysel.Enabled = false;
            this.RadioBireysel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBireysel.Location = new System.Drawing.Point(351, 197);
            this.RadioBireysel.Name = "RadioBireysel";
            this.RadioBireysel.Size = new System.Drawing.Size(166, 26);
            this.RadioBireysel.TabIndex = 8;
            this.RadioBireysel.TabStop = true;
            this.RadioBireysel.Text = "Bireysel Hesap";
            this.RadioBireysel.UseVisualStyleBackColor = true;
            this.RadioBireysel.CheckedChanged += new System.EventHandler(this.RadioBireysel_CheckedChanged_1);
            // 
            // RadioTicari
            // 
            this.RadioTicari.AutoSize = true;
            this.RadioTicari.Enabled = false;
            this.RadioTicari.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioTicari.Location = new System.Drawing.Point(351, 176);
            this.RadioTicari.Name = "RadioTicari";
            this.RadioTicari.Size = new System.Drawing.Size(147, 26);
            this.RadioTicari.TabIndex = 7;
            this.RadioTicari.TabStop = true;
            this.RadioTicari.Text = "Ticari Hesap";
            this.RadioTicari.UseVisualStyleBackColor = true;
            this.RadioTicari.CheckedChanged += new System.EventHandler(this.RadioTicari_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hesap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "2. Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "1. Tarih:";
            // 
            // TxtHesapNo
            // 
            this.TxtHesapNo.Location = new System.Drawing.Point(351, 24);
            this.TxtHesapNo.Name = "TxtHesapNo";
            this.TxtHesapNo.Size = new System.Drawing.Size(121, 32);
            this.TxtHesapNo.TabIndex = 1;
            this.TxtHesapNo.TextChanged += new System.EventHandler(this.TxtHesapNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesap No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.dataGridViewYatir);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(70, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 324);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yatırma İşlemleri                                                                " +
    "                    ";
            // 
            // dataGridViewYatir
            // 
            this.dataGridViewYatir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewYatir.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridViewYatir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYatir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewYatir.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewYatir.Name = "dataGridViewYatir";
            this.dataGridViewYatir.RowHeadersWidth = 51;
            this.dataGridViewYatir.RowTemplate.Height = 24;
            this.dataGridViewYatir.Size = new System.Drawing.Size(451, 296);
            this.dataGridViewYatir.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gold;
            this.groupBox3.Controls.Add(this.dataGridViewHavale);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(530, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 324);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Havale İşlemleri                                                                 " +
    "           ";
            // 
            // dataGridViewHavale
            // 
            this.dataGridViewHavale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHavale.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridViewHavale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHavale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHavale.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewHavale.Name = "dataGridViewHavale";
            this.dataGridViewHavale.RowHeadersWidth = 51;
            this.dataGridViewHavale.RowTemplate.Height = 24;
            this.dataGridViewHavale.Size = new System.Drawing.Size(571, 296);
            this.dataGridViewHavale.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gold;
            this.groupBox4.Controls.Add(this.dataGridViewCekim);
            this.groupBox4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1110, 423);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 324);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Çekim İşlemleri                                                                  " +
    "                              ";
            // 
            // dataGridViewCekim
            // 
            this.dataGridViewCekim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCekim.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridViewCekim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCekim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCekim.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewCekim.Name = "dataGridViewCekim";
            this.dataGridViewCekim.RowHeadersWidth = 51;
            this.dataGridViewCekim.RowTemplate.Height = 24;
            this.dataGridViewCekim.Size = new System.Drawing.Size(462, 296);
            this.dataGridViewCekim.TabIndex = 0;
            // 
            // banka_OtomasyonDataSet7
            // 
            this.banka_OtomasyonDataSet7.DataSetName = "Banka_OtomasyonDataSet7";
            this.banka_OtomasyonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblYatirBindingSource
            // 
            this.tblYatirBindingSource.DataMember = "Tbl_Yatir";
            this.tblYatirBindingSource.DataSource = this.banka_OtomasyonDataSet7;
            // 
            // tbl_YatirTableAdapter
            // 
            this.tbl_YatirTableAdapter.ClearBeforeFill = true;
            // 
            // banka_OtomasyonDataSet8
            // 
            this.banka_OtomasyonDataSet8.DataSetName = "Banka_OtomasyonDataSet8";
            this.banka_OtomasyonDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHavaleBindingSource
            // 
            this.tblHavaleBindingSource.DataMember = "Tbl_Havale";
            this.tblHavaleBindingSource.DataSource = this.banka_OtomasyonDataSet8;
            // 
            // tbl_HavaleTableAdapter
            // 
            this.tbl_HavaleTableAdapter.ClearBeforeFill = true;
            // 
            // banka_OtomasyonDataSet9
            // 
            this.banka_OtomasyonDataSet9.DataSetName = "Banka_OtomasyonDataSet9";
            this.banka_OtomasyonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCekimBindingSource
            // 
            this.tblCekimBindingSource.DataMember = "Tbl_Cekim";
            this.tblCekimBindingSource.DataSource = this.banka_OtomasyonDataSet9;
            // 
            // tbl_CekimTableAdapter
            // 
            this.tbl_CekimTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çiftlik   bank";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banka_Otomasyon1._1.Properties.Resources.banka;
            this.pictureBox1.Location = new System.Drawing.Point(24, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.White;
            this.btnGeri.ImageKey = "geri_ikonu.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(4, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(58, 29);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Banka_Otomasyon1._1.Properties.Resources.pngwing_com;
            this.pictureBox2.Location = new System.Drawing.Point(848, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FrmHesapGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1590, 784);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHesapGecmisi";
            this.Text = "FrmHesapGecmisi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYatir)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHavale)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_OtomasyonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYatirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_OtomasyonDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHavaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banka_OtomasyonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCekimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioTicari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RadioBireysel;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label lblDogrula;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewYatir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewHavale;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewCekim;
        private Banka_OtomasyonDataSet7 banka_OtomasyonDataSet7;
        private System.Windows.Forms.BindingSource tblYatirBindingSource;
        private Banka_OtomasyonDataSet7TableAdapters.Tbl_YatirTableAdapter tbl_YatirTableAdapter;
        private Banka_OtomasyonDataSet8 banka_OtomasyonDataSet8;
        private System.Windows.Forms.BindingSource tblHavaleBindingSource;
        private Banka_OtomasyonDataSet8TableAdapters.Tbl_HavaleTableAdapter tbl_HavaleTableAdapter;
        private Banka_OtomasyonDataSet9 banka_OtomasyonDataSet9;
        private System.Windows.Forms.BindingSource tblCekimBindingSource;
        private Banka_OtomasyonDataSet9TableAdapters.Tbl_CekimTableAdapter tbl_CekimTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimeTarih2;
        private System.Windows.Forms.DateTimePicker dateTimeTarih1;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}