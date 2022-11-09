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
    public partial class grafikfrm3 : Form
    {
        public grafikfrm3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();


        private void grafikfrm3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select oyuncakturu,stoksayisi from Oyuncak ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Oyuncak Türü"].Points.AddXY(read["oyuncakturu"].ToString(), read["stoksayisi"]);
            }
            baglanti.Close();
            chart1.Series["Oyuncak Türü"].Color = Color.Purple;
        }
    }
}
