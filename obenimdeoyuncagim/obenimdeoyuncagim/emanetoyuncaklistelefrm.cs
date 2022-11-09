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
    public partial class emanetoyuncaklistelefrm : Form
    {
        public emanetoyuncaklistelefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();
        private void emanetoyuncaklistelefrm_Load(object sender, EventArgs e)
        {
            emanetlistele();
            comboBox1.SelectedIndex = 0;
        }
        private void emanetlistele()
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from emanetoyuncaklar", baglanti);
            adtr.Fill(daset, "emanetoyuncaklar");
            dataGridView1.DataSource = daset.Tables["emanetoyuncaklar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetoyuncaklar"].Clear();
            if(comboBox1.SelectedIndex==0)
            {
                emanetlistele();

            }
            else if (comboBox1.SelectedIndex==1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from emanetoyuncaklar where '"+DateTime.Now.ToShortTimeString()+"'>iadetarihi", baglanti);
                adtr.Fill(daset, "emanetoyuncaklar");
                dataGridView1.DataSource = daset.Tables["emanetoyuncaklar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from emanetoyuncaklar where '" + DateTime.Now.ToShortTimeString() + "'<=iadetarihi", baglanti);
                adtr.Fill(daset, "emanetoyuncaklar");
                dataGridView1.DataSource = daset.Tables["emanetoyuncaklar"];
                baglanti.Close();
            }
        }
    }
}
