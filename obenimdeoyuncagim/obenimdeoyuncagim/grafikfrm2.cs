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
    public partial class grafikfrm2 : Form
    {
        public grafikfrm2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True"); 
        DataSet daset = new DataSet();

        private void grafikfrm2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select oyuncakadi,oyuncakyasgrubu from emanetoyuncaklar ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Oyuncak Yaş Grubu"].Points.AddXY(read["oyuncakadi"].ToString(), read["oyuncakyasgrubu"]);
            }
            baglanti.Close();
            chart1.Series["Oyuncak Yaş Grubu"].Color = Color.Orange;
        }
    }
}
