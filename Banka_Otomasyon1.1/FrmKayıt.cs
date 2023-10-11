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
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-I790538;Initial Catalog=Banka_Otomasyon; Integrated Security = True");

       

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Bank_Otomasyon (KullaniciAd,Sifre) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifreOlustur.Text);
            komut.ExecuteNonQuery();

            MessageBox.Show("Kaydınız Başarıyla Tanımlanmıştır \nGiriş Ekranından Giriş Yapabilirsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Bank_Otomasyon Where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifreOlustur.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmGiris Giris = new FrmGiris();
                this.Hide();
                Giris.Show();
            }
            else
            {
                MessageBox.Show("Hesap No veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmGiris Giris= new FrmGiris();
            this.Hide();
            Giris.Show();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (TxtSifreOlustur.UseSystemPasswordChar == true)
            {
                TxtSifreOlustur.UseSystemPasswordChar= false;
            }
            else if(TxtSifreOlustur.UseSystemPasswordChar== false)
            {
                TxtSifreOlustur.UseSystemPasswordChar= true;
            }
        }
    }
}
