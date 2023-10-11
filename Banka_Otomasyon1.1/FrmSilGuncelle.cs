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
using System.Reflection.Emit;

namespace Banka_Otomasyon1._1
{
    public partial class FrmSilGuncelle : Form
    {
        public FrmSilGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-I790538;Initial Catalog=Banka_Otomasyon; Integrated Security = True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAna Anaform = new FrmAna();
            this.Hide();
            Anaform.Show();
        }

        private void FrmSilGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
           
        }
        public void Temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSifre.Text = "";
            RadioBireysel.Checked = false;
            RadioTicari.Checked = false;
            TxtBakiye.Text = "0";
        }
        private void TxtHesapNo_TextChanged(object sender, EventArgs e)
        {     
            //if(TxtHesapNo.Text=="") foreach(Control item in Controls) if(item is TextBox) item.Text = "";
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select *from Tbl_Musteri_1 where Hesap_No like '" +TxtHesapNo.Text+ "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                TxtAd.Text = read[1].ToString();
                TxtSoyad.Text = read[2].ToString();
                TxtBakiye.Text = read[3].ToString();
                lblDogrula.Text = read[4].ToString();
                TxtSifre.Text = read[5].ToString();

            }
            baglanti.Close();
        }

        private void RadioTicari_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioTicari.Checked==true) 
            {
                lblDogrula.Text = "True";
            }
        }

        private void RadioBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBireysel.Checked == true)
            {
                lblDogrula.Text = "False";
            }
        }

        private void lblDogrula_TextChanged(object sender, EventArgs e)
        {
            if (lblDogrula.Text == "True")
            {
                RadioTicari.Checked = true;
            }
            else if (lblDogrula.Text == "False")
            {
                RadioBireysel.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(TxtBakiye.Text);
            
            if (sonuc != 0)
            {
                MessageBox.Show("Müşteri Bakiyesi sıfır olmadığından \nMüşteriyi Silemezsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komutsil = new SqlCommand("Delete from Tbl_Musteri_1 where Hesap_No=@k1", baglanti);
                komutsil.Parameters.AddWithValue("@k1", TxtHesapNo.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıtlı Kişi Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Musteri_1 Set Ad=@a1,Soyad=@a2,Bakiye=@a3,Musteri_Tipi=@a4,Sifre=@a5 where Hesap_No=@a6", baglanti);
            komutGuncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", TxtBakiye.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", lblDogrula.Text);
            komutGuncelle.Parameters.AddWithValue("@a5", TxtSifre.Text);
            komutGuncelle.Parameters.AddWithValue("@a6", TxtHesapNo.Text);
            komutGuncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıtlı Kişi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
