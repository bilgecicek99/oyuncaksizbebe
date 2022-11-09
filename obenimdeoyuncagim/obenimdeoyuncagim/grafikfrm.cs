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

namespace obenimdeoyuncagim
{
    public partial class grafikfrm : Form
    {
        public grafikfrm()

        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();

        private void grafikfrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad,oyuncaksayisi from Uye ",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                chart1.Series["Alınan Oyuncak Sayısı"].Points.AddXY(read["adsoyad"].ToString(), read["oyuncaksayisi"]);
            }
            baglanti.Close();
            chart1.Series["Alınan Oyuncak Sayısı"].Color = Color.Pink;
        }
    }
}   
