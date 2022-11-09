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
    public partial class OyuncakEklefrm : Form
    {
        public OyuncakEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        private void OyuncakEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Oyuncak(barkodno,oyuncakadi,oyuncakboyutu,oyuncakyasgrubu,ureticifirma,oyuncakturu,stoksayisi,rafno,aciklama,kayittarihi) values(@barkodno,@oyuncakadi,@oyuncakboyutu,@oyuncakyasgrubu,@ureticifirma,@oyuncakturu,@stoksayisi,@rafno,@aciklama,@kayittarihi)",baglanti);
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            komut.Parameters.AddWithValue("@oyuncakadi", txtoyuncakadi.Text);
            komut.Parameters.AddWithValue("@oyuncakboyutu", txtoyuncakboyutu.Text);
            komut.Parameters.AddWithValue("@oyuncakyasgrubu", txtyasgrubu.Text);
            komut.Parameters.AddWithValue("@ureticifirma", txtureticifirma.Text);
            komut.Parameters.AddWithValue("@oyuncakturu", comboturu.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtstoksayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtrafno.Text);
            komut.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
            komut.Parameters.AddWithValue("@kayittarihi",DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Oyuncak Kaydı Tamamlandı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    {
                        item.Text = "";
                    }
                }
            }
        }
    }
}
