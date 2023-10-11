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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I790538;Initial Catalog=Banka_Otomasyon;Integrated Security=True");
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmAna AnaForm = new FrmAna();
            this.Hide();
            AnaForm.Show();
        }

       public void Temizle()
        {
            radioBireysel.Checked = false;
            radioTicari.Checked = false;
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtBakiye.Text = "";
            TxtSifre.Text = "";
            TxtAd.Focus();
        }

        private void radioTicari_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTicari.Checked == true)
            {
                label8.Text="True";
            }
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text=="True")
            {
                radioTicari.Checked = true;
            }
            else if(label8.Text=="False")
            {
                radioBireysel.Checked= true;
            }
        }

        private void radioBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if(radioBireysel.Checked == true) 
            {
                label8.Text="False";            
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Musteri_1 (Ad,Soyad,Bakiye,Musteri_Tipi,Sifre) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtBakiye.Text);
            komut.Parameters.AddWithValue("@p4", label8.Text);
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);

            komut.ExecuteNonQuery();// insert update delete ile kullanılır
            baglanti.Close();
            MessageBox.Show("Kişi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if(TxtSifre.UseSystemPasswordChar==true)
            {
                TxtSifre.UseSystemPasswordChar= false;
            }
            else if(TxtSifre.UseSystemPasswordChar== false)
            {
                TxtSifre.UseSystemPasswordChar= true;
            }
        }
    }
}
