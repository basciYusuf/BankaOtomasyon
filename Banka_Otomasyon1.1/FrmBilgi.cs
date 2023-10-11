using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyon1._1
{
    public partial class FrmBilgi : Form
    {
        public FrmBilgi()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmAna Anaform = new FrmAna();
            this.Hide();
            Anaform.Show();
        }
    }
}
