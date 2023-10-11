using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banka_Otomasyon1._1
{
    public partial class FrmHavale : Form
    {
        public FrmHavale()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I790538;Initial Catalog=Banka_Otomasyon;Integrated Security=True");
        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAna Anaform = new FrmAna();
            this.Hide();
            Anaform.Show();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar == true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else if (TxtSifre.UseSystemPasswordChar == false)
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }
        private void RadioTicari_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTicari.Checked == true)
            {
                lblTicariDogrula.Text = "True";
            }
        }

        private void RadioBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBireysel.Checked == true)
            {
                lblTicariDogrula.Text = "False";
            }
        }

        private void lblTicariDogrula_TextChanged(object sender, EventArgs e)
        {
            if (lblTicariDogrula.Text == "True")
            {
                RadioTicari.Checked = true;
            }
            else if (lblTicariDogrula.Text == "False")
            {
                RadioBireysel.Checked = true;
            }
        }
        private void TxtHesaspNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select *from Tbl_Musteri_1 where Hesap_No like '" + TxtHesapNo.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtAd.Text = read[1].ToString();
                TxtSoyad.Text = read[2].ToString();
                TxtBakiye.Text = read[3].ToString();
                lblTicariDogrula.Text = read[4].ToString();  // ticari veya bireysel olduğunu gösterme
                TxtSifre.Text = read[5].ToString();

            }
            baglanti.Close();
        }
        private void TxtAliciHesapNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select *from Tbl_Musteri_1 where Hesap_No like '" + TxtAliciHesapNo.Text + "' ", baglanti);
            SqlDataReader read1 = komut1.ExecuteReader();
            while (read1.Read())
            {
                TxtAliciBakiye.Text = read1["Bakiye"].ToString();

            }
            baglanti.Close();
        }
        private void FrmHavale_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutBankaHesabiToplam = new SqlCommand("Select *from Tbl_BankaHesabi", baglanti);
            SqlDataReader readBankaHesabiToplam = komutBankaHesabiToplam.ExecuteReader();
            while (readBankaHesabiToplam.Read())
            {
                TxtBankaHesabi.Text = readBankaHesabiToplam[0].ToString();
            }
            baglanti.Close();
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            int Gonderen, Alici,GonderilenMiktar, ToplamBankaHesapla;
            GonderilenMiktar =Convert.ToInt32(TxtMiktar.Text);
            Alici = Convert.ToInt32(TxtAliciBakiye.Text) + Convert.ToInt32(TxtMiktar.Text);

            //***************************** Banka Hesabı Tutma *********************************************************************
            if (RadioTicari.Checked == false)
            {
                Gonderen = Convert.ToInt32(TxtBakiye.Text) - Convert.ToInt32(TxtMiktar.Text)-((GonderilenMiktar*2)/100);
                TxtBakiye.Text = Gonderen.ToString();
                TxtYuzde2.Text = ((GonderilenMiktar * 2) / 100).ToString();
                ToplamBankaHesapla = Convert.ToInt32(TxtBankaHesabi.Text) + Convert.ToInt32(TxtYuzde2.Text);
                TxtBankaHesabi.Text = ToplamBankaHesapla.ToString();

                MessageBox.Show("Paranız gönderilmiştir\nBakiyenizden, Gönderdiğiniz Miktarın %2' lik kısmı da kesilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(RadioTicari.Checked == true) 
            {
                Gonderen = Convert.ToInt32(TxtBakiye.Text) - Convert.ToInt32(TxtMiktar.Text);
                TxtBakiye.Text = Gonderen.ToString();
                MessageBox.Show("Paranız gönderilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TxtAliciBakiye.Text = Alici.ToString();

            baglanti.Open();
            SqlCommand komutBankaHesabi = new SqlCommand("Update Tbl_BankaHesabi Set BankaHesabi=@a1", baglanti);
            komutBankaHesabi.Parameters.AddWithValue("@a1", TxtBankaHesabi.Text);
            komutBankaHesabi.ExecuteNonQuery();
            baglanti.Close();


            baglanti.Open();
            SqlCommand komutAlici = new SqlCommand("Update Tbl_Musteri_1 Set Bakiye=@a1 where Hesap_No=@a2", baglanti);
            komutAlici.Parameters.AddWithValue("@a1", TxtAliciBakiye.Text);
            komutAlici.Parameters.AddWithValue("@a2", TxtAliciHesapNo.Text);
            komutAlici.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutGonderen = new SqlCommand("Update Tbl_Musteri_1 Set Bakiye=@g1 where Hesap_No=@g2", baglanti);
            komutGonderen.Parameters.AddWithValue("@g1", TxtBakiye.Text);
            komutGonderen.Parameters.AddWithValue("@g2", TxtHesapNo.Text);
            komutGonderen.ExecuteNonQuery();
            baglanti.Close();

            //***************************************** Kullanıcı Havale İşlemleri Kaydediliyor ********************************************************************//
            baglanti.Open();
            SqlCommand komutHavale = new SqlCommand("insert into Tbl_Havale (GonderenHesapNo,Miktar,AliciHesapNo,Tarih) values(@p1,@p2,@p3,@p4)", baglanti);
            komutHavale.Parameters.AddWithValue("@p1", TxtHesapNo.Text);
            komutHavale.Parameters.AddWithValue("@p2", TxtMiktar.Text);
            komutHavale.Parameters.AddWithValue("@p3", TxtAliciHesapNo.Text);
            komutHavale.Parameters.AddWithValue("@p4", dateTarih.Value);
            komutHavale.ExecuteNonQuery();
            baglanti.Close();
        }     
    }
}
