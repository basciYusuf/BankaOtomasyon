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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-I790538;Initial Catalog=Banka_Otomasyon;Integrated Security=True");
        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle ekle = new MusteriEkle();
            this.Hide();
            ekle.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaCekme Cekme = new ParaCekme();
            this.Hide();
            Cekme.Show();
        }

        private void paraYatırmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ParaYatirma Yatirma = new ParaYatirma();
            this.Hide();
            Yatirma.Show();
        }

        private void hesabaHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHavale Havale = new FrmHavale();
            this.Hide();
            Havale.Show();
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBilgi Bilgi = new FrmBilgi();
            this.Hide();
            Bilgi.Show();
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'banka_OtomasyonDataSet5.Tbl_Musteri_1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_Musteri_1TableAdapter1.Fill(this.banka_OtomasyonDataSet5.Tbl_Musteri_1);



        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSilGuncelle silGuncelle= new FrmSilGuncelle();
            this.Hide();
            silGuncelle.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void müşteriHesapGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHesapGecmisi HesapGecmisi = new FrmHesapGecmisi();
            this.Hide();
            HesapGecmisi.Show();
        }

        private void bankaGelirGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmGelirGider gelirGider = new FrmGelirGider();
            this.Hide();
            gelirGider.Show();
        }
    }
}
