using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            frmOgrKayit frm1 = new frmOgrKayit();
            frm1.Show();
            this.Hide();
        }

        private void btnOgretmenKayit_Click(object sender, EventArgs e)
        {
            frmOgretmenKayit frm2 = new frmOgretmenKayit();
            frm2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            frmKisiBul frm3 = new frmKisiBul();
            frm3.Show();
            this.Hide();
        }
    }
}
