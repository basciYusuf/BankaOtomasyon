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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-I790538;Initial Catalog=Banka_Otomasyon; Integrated Security = True");
        
        private void btnKayit_Click(object sender, EventArgs e)
        {
            FrmKayıt Kayit = new FrmKayıt();
            this.Hide();
            Kayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Bank_Otomasyon Where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtHesapNoGiris.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifreGiris.Text);
            SqlDataReader dr=komut.ExecuteReader();

            if(dr.Read())
            {
                FrmAna AnaForm = new FrmAna();
                this.Hide();
                AnaForm.Show();
            }
            else
            {
                MessageBox.Show("Hesap No veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (TxtSifreGiris.UseSystemPasswordChar == true)
            {
                TxtSifreGiris.UseSystemPasswordChar= false;
            }
            else if(TxtSifreGiris.UseSystemPasswordChar==false)
            {
                TxtSifreGiris.UseSystemPasswordChar= true;
            }
        }
    }
}
