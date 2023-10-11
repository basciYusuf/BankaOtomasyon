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
    public partial class FrmHesapGecmisi : Form
    {
        public FrmHesapGecmisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-I790538;Initial Catalog=Banka_Otomasyon; Integrated Security = True");
        

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
                lblDogrula.Text = read[4].ToString();

            }
            baglanti.Close();
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

        private void RadioTicari_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioTicari.Checked == true)
            {
                lblDogrula.Text = "True";
            }
        }
        private void RadioBireysel_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioBireysel.Checked == true)
            {
                lblDogrula.Text = "False";
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAna Anaform = new FrmAna();
            this.Hide();
            Anaform.Show();
        }

        DataTable DataListByHavale()
        {
            string sql = "Select * from Tbl_Havale Where GonderenHesapNo like '"+TxtHesapNo.Text+"' and (Tarih between @p1 and @p2)";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr= new SqlDataAdapter(sql,baglanti);
            adtr.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimeTarih1.Value;
            adtr.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimeTarih2.Value;
            adtr.Fill(tbl);
            dataGridViewHavale.DataSource = tbl;
            return tbl;
        }
        DataTable DataListByCekim()
        {
            string sql = "Select * from Tbl_Cekim Where HesapNo like '"+TxtHesapNo.Text+"' and (Tarih between @p1 and @p2)";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimeTarih1.Value;
            adtr.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimeTarih2.Value;
            adtr.Fill(tbl);
            dataGridViewCekim.DataSource = tbl;
            return tbl;
        }
        DataTable DataListByYatirim()
        {
            string sql = "Select * from Tbl_Yatir Where HesapNo like '"+TxtHesapNo.Text+"' and (Tarih between @p1 and @p2)";
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimeTarih1.Value;
            adtr.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimeTarih2.Value;
            adtr.Fill(tbl);
            dataGridViewYatir.DataSource = tbl;
            return tbl;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DataListByHavale();
            DataListByCekim();
            DataListByYatirim();

        }       
    }
}
