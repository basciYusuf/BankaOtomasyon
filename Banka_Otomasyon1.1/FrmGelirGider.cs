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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I790538;Initial Catalog=Banka_Otomasyon;Integrated Security=True");
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'banka_OtomasyonDataSet13.Tbl_Yatir' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_YatirTableAdapter.Fill(this.banka_OtomasyonDataSet13.Tbl_Yatir);
            // TODO: Bu kod satırı 'banka_OtomasyonDataSet12.Tbl_Havale' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_HavaleTableAdapter.Fill(this.banka_OtomasyonDataSet12.Tbl_Havale);
            // TODO: Bu kod satırı 'banka_OtomasyonDataSet11.Tbl_Cekim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_CekimTableAdapter.Fill(this.banka_OtomasyonDataSet11.Tbl_Cekim);

            baglanti.Open();
            SqlCommand komutBankaHesabiToplam = new SqlCommand("Select *from Tbl_BankaHesabi", baglanti);
            SqlDataReader readBankaHesabiToplam = komutBankaHesabiToplam.ExecuteReader();
            while (readBankaHesabiToplam.Read())
            {
                lblToplamBankaHesabi.Text = readBankaHesabiToplam[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutGider = new SqlCommand("Select sum(Cekim) From Tbl_Cekim", baglanti);
            SqlDataReader drGider = komutGider.ExecuteReader();
            while (drGider.Read())
            {
                lblGider.Text = drGider[0].ToString();
            }
            baglanti.Close();




            baglanti.Open();
            SqlCommand komutGelir = new SqlCommand("Select sum(Yatirilan_Tutar) From Tbl_Yatir", baglanti);
            SqlDataReader drGelir = komutGelir.ExecuteReader();
            while (drGelir.Read())
            {
                lblGelir.Text = drGelir[0].ToString();
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komutToplam = new SqlCommand("Select sum(Bakiye) From Tbl_Musteri_1", baglanti);
            SqlDataReader drToplam = komutToplam.ExecuteReader();
            while (drToplam.Read())
            {
                lblToplamPara.Text = drToplam[0].ToString();
            }
            baglanti.Close();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAna Anaform = new FrmAna();
            this.Hide();
            Anaform.Show();

        }
    }
}
