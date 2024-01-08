using OkulApp.BLL;  // İş mantığı katmanını içeri aktar
using OkulApp.MODEL;    // Model sınıflarını içeri aktar
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

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        // Buton tıklama olayı
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                // İş mantığı katmanından OgrenciBL sınıfının bir örneğini oluştur
                var obl = new OgrenciBL();
                // Girilen bilgileri kullanarak yeni bir öğrenci eklemeye çalış
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                // Sonuca bağlı olarak başarı veya başarısızlık mesajı görüntüle
                MessageBox.Show(sonuc ? "Ekleme başarılı!" : "Ekleme başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!" + ex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!!");
            }
        }

        private void frmOgrKayit_Load(object sender, EventArgs e)
        {

        }
    }

}
