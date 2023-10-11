using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banka_Otomasyon1._1
{
    public partial class ParaYatirma : Form
    {
        public ParaYatirma()
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
                TxtSifre.UseSystemPasswordChar= false;
            }
            else if (TxtSifre.UseSystemPasswordChar == false)
            {
                TxtSifre.UseSystemPasswordChar= true;
            }
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            if (TxtYatir.Enabled == true)
            {
                TxtYatir.Enabled = false;
            }
            else if (TxtYatir.Enabled == false)
            {
                TxtYatir.Enabled = true;
            }

            if (btnYatir.Enabled == true)
            {
                btnYatir.Enabled = false;
            }
            else if (btnYatir.Enabled == false)
            {
                btnYatir.Enabled = true;
            }
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
                //lblDogrula.Text = read[4].ToString();  // ticari veya bireysel olduğunu gösterme
                TxtSifre.Text = read[5].ToString();

            }
            baglanti.Close();
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            int Sonuc;
            Sonuc = Convert.ToInt32(TxtBakiye.Text) + Convert.ToInt32(TxtYatir.Text);

            TxtBakiye.Text = Sonuc.ToString();

            baglanti.Open();

            SqlCommand komutYatir = new SqlCommand("Update Tbl_Musteri_1 Set Bakiye=@a1 where Hesap_No=@a2", baglanti);
            komutYatir.Parameters.AddWithValue("@a1", TxtBakiye.Text);
            komutYatir.Parameters.AddWithValue("@a2", TxtHesapNo.Text);
            komutYatir.ExecuteNonQuery();
            baglanti.Close();
            //********************************************* Hesap Yatırma geçmişi Kayıt ediliyor ******************************************************//

            baglanti.Open();
            SqlCommand komutYatirGecmisi = new SqlCommand("insert into Tbl_Yatir (HesapNo,Yatirilan_Tutar,Tarih) values(@p1,@p2,@p3)", baglanti);
            komutYatirGecmisi.Parameters.AddWithValue("@p1", TxtHesapNo.Text);
            komutYatirGecmisi.Parameters.AddWithValue("@p2", TxtYatir.Text);
            komutYatirGecmisi.Parameters.AddWithValue("@p3", DateTarih.Value);
            komutYatirGecmisi.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıtlı Kişinin parası Yatırılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
