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
    public partial class grafikfrm4 : Form
    {
        public grafikfrm4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();

        private void grafikfrm4_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select cinsiyet,oyuncaksayisi from Uye ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Cinsiyet"].Points.AddXY(read["cinsiyet"].ToString(), read["oyuncaksayisi"]);
            }
            baglanti.Close();
            chart1.Series["Cinsiyet"].Color = Color.Green;
        }
    }
}
