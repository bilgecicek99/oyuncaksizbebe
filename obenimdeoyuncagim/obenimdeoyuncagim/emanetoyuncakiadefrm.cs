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
    public partial class emanetoyuncakiadefrm : Form

    {
        public emanetoyuncakiadefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();
        private void emanetlistele()
        {
            if(baglanti.State == ConnectionState.Open)
                {

            }
            else { baglanti.Open(); }
            SqlDataAdapter adtr = new SqlDataAdapter("select * from emanetoyuncaklar", baglanti);
            adtr.Fill(daset, "emanetoyuncaklar");
            dataGridView1.DataSource = daset.Tables["emanetoyuncaklar"];
            baglanti.Close();
        }

        

        private void emanetoyuncakiadefrm_Load(object sender, EventArgs e)
        {
            emanetlistele();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Close();   
                
        }

        

        private void barkodnoara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetoyuncaklar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from emanetoyuncaklar where barkodno like '%" + barkodnoara.Text + "%'", baglanti);
            adtr.Fill(daset, "emanetoyuncaklar");
            baglanti.Close();
            if (barkodnoara.Text == "")
            {
                daset.Tables["emanetoyuncaklar"].Clear();
                emanetlistele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from emanetoyuncaklar where tc=@tc and barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update oyuncak set stoksayisi=stoksayisi+'" + dataGridView1.CurrentRow.Cells["oyuncaksayisi"].Value.ToString() + "' where barkodno=@barkodno", baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            MessageBox.Show("oyuncak(lar) iade edildi");
            daset.Tables["emanetoyuncaklar"].Clear();
            emanetlistele();

        }

        private void tcara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["emanetoyuncaklar"].Clear();
            baglanti.Open();
           
            SqlDataAdapter adtr= new SqlDataAdapter("select * from emanetoyuncaklar where tc like '%"+tcara.Text+"%'", baglanti);
            adtr.Fill(daset, "emanetoyuncaklar");
            baglanti.Close();
            if (tcara.Text == "")
            {
                daset.Tables["emanetoyuncaklar"].Clear();
                emanetlistele();
            }
        }
    }
}
