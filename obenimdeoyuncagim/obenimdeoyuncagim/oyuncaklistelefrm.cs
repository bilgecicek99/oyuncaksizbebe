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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace obenimdeoyuncagim
{
    public partial class oyuncaklistelefrm : Form
    {
        public oyuncaklistelefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();
        private void oyuncaklistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Oyuncak", baglanti);
            adtr.Fill(daset, "Oyuncak");
            dataGridView1.DataSource = daset.Tables["Oyuncak"];
            baglanti.Close();
        }
        private void oyuncaklistelefrm_Load(object sender, EventArgs e)
        {
          oyuncaklistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kaydı Silmek İstediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oyuncak where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı");
                daset.Tables["Oyuncak"].Clear();
                oyuncaklistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Oyuncak set oyuncakadi=@oyuncakadi,oyuncakboyutu=@oyuncakboyutu,oyuncakyasgrubu=@yasgrubu,ureticifirma=@ureticifirma,oyuncakturu=@oyuncakturu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            komut.Parameters.AddWithValue("@oyuncakadi", txtoyuncakadi.Text);
            komut.Parameters.AddWithValue("@oyuncakboyutu", txtoyuncakboyutu.Text);
            komut.Parameters.AddWithValue("@yasgrubu", txtyasgrubu.Text);
            komut.Parameters.AddWithValue("@ureticifirma", txtureticifirma.Text);
            komut.Parameters.AddWithValue("@oyuncakturu", comboturu.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtstoksayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtrafno.Text);
            komut.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Tamamlandı");
            daset.Tables["Oyuncak"].Clear();
            oyuncaklistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void textbarkodara_TextChanged(object sender, EventArgs e)
        {

            daset.Tables["Oyuncak"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Oyuncak where barkodno like '%" + txtbarkodara.Text + "%'", baglanti);
            adtr.Fill(daset, "Oyuncak");
            dataGridView1.DataSource = daset.Tables["Oyuncak"];
            baglanti.Close();
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oyuncak where barkodno like '" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtoyuncakadi.Text = read["oyuncakadi"].ToString();
                txtoyuncakboyutu.Text = read["oyuncakboyutu"].ToString();
                txtyasgrubu.Text = read["oyuncakyasgrubu"].ToString();
                comboturu.Text = read["oyuncakturu"].ToString();
                txtstoksayisi.Text = read["stoksayisi"].ToString();
                txtrafno.Text = read["rafno"].ToString();
                txtaciklama.Text = read["aciklama"].ToString();

            }
            baglanti.Close();

        }
    }
}
