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
    public partial class frmKisiBul : Form
    {
        private SqlConnection connection;
        private  string connectionString = "Data Source=DESKTOP-LUBM8JD\\SQLEXPRESS;Initial Catalog=BerkeOdev;Integrated Security=True;"; // Veritabanı bağlantı dizesi

        public frmKisiBul()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void frmKisiBul_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenciBul_Click(object sender, EventArgs e)
        {
            string ogrenciAd = txtOgrenciAd.Text;
            string ogrenciSoyad = txtOgrenciSoyad.Text;
            string ogrenciNumara = txtOgrenciNo.Text;

            string query = "SELECT * FROM Ogrenciler WHERE OgrenciAd = @OgrenciAd OR OgrenciSoyad = @OgrenciSoyad OR OgrenciNumara = @OgrenciNumara";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@OgrenciAd", ogrenciAd);
                command.Parameters.AddWithValue("@OgrenciSoyad", ogrenciSoyad);
                command.Parameters.AddWithValue("@OgrenciNumara", ogrenciNumara);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

               dataview.DataSource = dataTable;

                connection.Close();
            }
        }

        private void btnOgrtBul_Click(object sender, EventArgs e)
        {
            string ogretmenAd = txtOgrtAd.Text;
            string ogretmenSoyad = txtOgrtSoyad.Text;
            string ogretmenTc = txtOgrtTc.Text;

            string query = "SELECT * FROM Ogretmenler WHERE OgretmenAd = @OgretmenAd OR OgretmenSoyad = @OgretmenSoyad OR OgretmenTc = @OgretmenTc";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@OgretmenAd", ogretmenAd);
                command.Parameters.AddWithValue("@OgretmenSoyad", ogretmenSoyad);
                command.Parameters.AddWithValue("@OgretmenTc", ogretmenTc);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataview.DataSource = dataTable; // Burada dataview yerine DataGridView kullanıyoruz.

                connection.Close();
            }
        }
    }
}
