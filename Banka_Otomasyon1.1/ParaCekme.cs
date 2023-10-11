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
    public partial class ParaCekme : Form
    {
        public ParaCekme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I790538;Initial Catalog=Banka_Otomasyon;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAna AnaForm = new FrmAna();
            this.Hide();
            AnaForm.Show();
        }
        

        private void TxtHesapNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select *from Tbl_Musteri_1 where Hesap_No like '" + TxtHesapNo.Text + "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtAd.Text = read[1].ToString();
                TxtSoyad.Text = read[2].ToString();
                TxtBakiye.Text = read[3].ToString();
                //lblDogrula.Text = read[4].ToString();
                TxtSifre.Text = read[5].ToString();

            }
            baglanti.Close();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar == true)
            {
                TxtSifre.UseSystemPasswordChar= false;
            }
            else if(TxtSifre.UseSystemPasswordChar== false)
            {
                TxtSifre.UseSystemPasswordChar= true;
            }
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            if(TxtCekim.Enabled == true) 
            {
                TxtCekim.Enabled= false;
            }
            else if(TxtCekim.Enabled==false)
            {
                TxtCekim.Enabled= true;
            }

            if(btnCekme.Enabled == true)
            {
                btnCekme.Enabled= false;
            }
            else if (btnCekme.Enabled == false)
            {
                btnCekme.Enabled= true;
            }
        }

        private void btnCekme_Click(object sender, EventArgs e)
        {
            int cekim = Convert.ToInt32(TxtCekim.Text);
            int Bakiye = Convert.ToInt32(TxtBakiye.Text);  

            if (cekim > 750)
            {
                MessageBox.Show("Maksimum 750 Tl Çekim Yapabilirsiniz","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cekim > Bakiye)
            {
                MessageBox.Show("Bakiye Yetersiz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Sonuc;
                Sonuc = Convert.ToInt32(TxtBakiye.Text) - Convert.ToInt32(TxtCekim.Text);
                
                TxtBakiye.Text=Sonuc.ToString();

                baglanti.Open();

                SqlCommand komutCekme = new SqlCommand("Update Tbl_Musteri_1 Set Bakiye=@a1 where Hesap_No=@a2", baglanti);
                komutCekme.Parameters.AddWithValue("@a1", TxtBakiye.Text);
                komutCekme.Parameters.AddWithValue("@a2", TxtHesapNo.Text);
                komutCekme.ExecuteNonQuery();
                baglanti.Close();
                //*************************************** Kullanıcı Çekim İşlemleri Kayıt Yeri********************************************//
                baglanti.Open();
                SqlCommand komutCekimGecmisi = new SqlCommand("insert into Tbl_Cekim (HesapNo,Cekim,Tarih) values(@p1,@p2,@p3)", baglanti);
                komutCekimGecmisi.Parameters.AddWithValue("@p1", TxtHesapNo.Text);
                komutCekimGecmisi.Parameters.AddWithValue("@p2", TxtCekim.Text);
                komutCekimGecmisi.Parameters.AddWithValue("@p3", DateTarih.Value);
                komutCekimGecmisi.ExecuteNonQuery();
                baglanti.Close();


                

                MessageBox.Show("Kayıtlı Kişinin parası çekilmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
    }
}
