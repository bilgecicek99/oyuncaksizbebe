using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace obenimdeoyuncagim
{
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
            InitializeComponent();
        }


        //SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - 6CT4PB0; Initial Catalog = OyuncakOtomasyonu; Integrated Security = True");
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnUyeEkle_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,oyuncaksayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@oyuncaksayisi)");
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", textBox6.Text);
            komut.Parameters.AddWithValue("@email", textBox7.Text);
            komut.Parameters.AddWithValue("@oyuncaksayisi",int.Parse(txtOyuncakSayisi.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Üye Kaydı Tamamlandı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txttoplam)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void UyeEklefrm_Load(object sender, EventArgs e)
        {

        }
    }
}
