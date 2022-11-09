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


namespace obenimdeoyuncagim
{
    public partial class emanetoyuncakverfrm : Form
    {
        public emanetoyuncakverfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();
        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }
        private void sepettekioyuncaksayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(oyuncaksayisi) from sepet", baglanti);
            lblsepettekioyuncaksayisi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
                

        }
        private void emanetoyuncakverfrm_Load(object sender, EventArgs e)
        {
            sepetlistele();
            sepettekioyuncaksayisi();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,oyuncakadi,ureticifirma,oyuncakboyutu,oyuncakyasgrubu,oyuncaksayisi,teslimtarihi,iadetarihi) values(@barkodno,@oyuncakadi,@ureticifirma,@oyuncakboyutu,@oyuncakyasgrubu,@oyuncaksayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
            komut.Parameters.AddWithValue("@oyuncakadi", txtoyuncakadi.Text);
            komut.Parameters.AddWithValue("@ureticifirma", txtureticifirma.Text);
            komut.Parameters.AddWithValue("@oyuncakboyutu", txtoyuncakboyutu.Text);
            komut.Parameters.AddWithValue("@oyuncakyasgrubu", txtyasgrubu.Text);
            komut.Parameters.AddWithValue("@oyuncaksayisi", int.Parse(txtoyuncaksayisi.Text));
            komut.Parameters.AddWithValue("@teslimtarihi",dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oyuncak(lar) Sepete Eklendi", "Ekleme İşlemi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblsepettekioyuncaksayisi.Text = "";
            sepettekioyuncaksayisi();
            foreach(Control item in grpoyuncakbilgi.Controls)
            {
                if(item is TextBox)
                {
                    if(item!=txtoyuncaksayisi)
                    {
                        item.Text = "";
                    }

                }
            }
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where tc='"+txttcara.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtadsoyad.Text = read["adsoyad"].ToString();
                txtyas.Text = read["yas"].ToString();
                txttelefon.Text = read["telefon"].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum (oyuncaksayisi) from emanetoyuncaklar where tc='"+txttcara.Text+"'", baglanti);
            label15.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if(txttcara.Text=="")
            {
                foreach(Control item in grpuyebilgi.Controls)
                    {
                    if(item is TextBox)
                    {
                        item.Text = "";
                        label15.Text = "";

                    }
                   
                }

            }

        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Oyuncak where barkodno like '" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtoyuncakadi.Text = read["oyuncakadi"].ToString();
                txtureticifirma.Text = read["ureticifirma"].ToString();
                txtoyuncakboyutu.Text = read["oyuncakboyutu"].ToString();
                txtyasgrubu.Text = read["oyuncakyasgrubu"].ToString();
               
               
            }
            baglanti.Close();
            if(txtbarkodno.Text=="")
            {
                foreach (Control item in grpoyuncakbilgi.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtoyuncaksayisi)
                        {
                            item.Text = "";
                        }
                    }
                }

            }
           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Silmek İstediğinize emin misiniz?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı", "Silme İşlemi");
                daset.Tables["sepet"].Clear();
                sepetlistele();
                lblsepettekioyuncaksayisi.Text = "";
                sepettekioyuncaksayisi();

            }
           
        }

        private void btnteslimet_Click(object sender, EventArgs e)
        {

            if (lblsepettekioyuncaksayisi.Text != "")
            {
                if (lblkayitlioyuncaksayisi.Text=="" && int.Parse(lblsepettekioyuncaksayisi.Text)<=3 || lblkayitlioyuncaksayisi.Text!="" && int.Parse(lblkayitlioyuncaksayisi.Text) + int.Parse(lblsepettekioyuncaksayisi.Text) <=3)
                {
                    if (txttcara.Text != "" && txtadsoyad.Text != "" && txtyas.Text != "" && txttelefon.Text != "")
                    {
                        for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into emanetoyuncaklar(tc,adsoyad,yas,telefon,barkodno,oyuncakadi,ureticifirma,oyuncakboyutu,oyuncakyasgrubu,oyuncaksayisi,teslimtarihi,iadetarihi) values(@tc,@adsoyad,@yas,@telefon,@barkodno,@oyuncakadi,@ureticifirma,@oyuncakboyutu,@oyuncakyasgrubu,@oyuncaksayisi,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc", txttcara.Text);
                            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
                            komut.Parameters.AddWithValue("@yas", txtyas.Text);
                            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                            komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("@oyuncakadi", dataGridView1.Rows[i].Cells["oyuncakadi"].Value.ToString());
                            komut.Parameters.AddWithValue("@ureticifirma", dataGridView1.Rows[i].Cells["ureticifirma"].Value.ToString());
                            komut.Parameters.AddWithValue("@oyuncakboyutu", dataGridView1.Rows[i].Cells["oyuncakboyutu"].Value.ToString());
                            komut.Parameters.AddWithValue("@oyuncakyasgrubu", dataGridView1.Rows[i].Cells["oyuncakyasgrubu"].Value.ToString());
                            komut.Parameters.AddWithValue("@oyuncaksayisi",int.Parse(dataGridView1.Rows[i].Cells["oyuncaksayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update Uye set oyuncaksayisi=oyuncaksayisi+'" + int.Parse(dataGridView1.Rows[i].Cells["oyuncaksayisi"].Value.ToString()) + "' where tc='" + txttcara.Text + "'", baglanti);
                            komut2.ExecuteNonQuery();
                            
                            SqlCommand komut3 = new SqlCommand("update Oyuncak set stoksayisi=stoksayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["oyuncaksayisi"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                            komut3.ExecuteNonQuery();
                            baglanti.Close();
                           
                        }
                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Oyuncak(lar) emanet verildi");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txttcara.Text = "";
                        lblsepettekioyuncaksayisi.Text = "";
                        sepettekioyuncaksayisi();
                        label15.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("Önce üye ismini seçmeniz gerekir", "Uyarı");

                    }
                }

                else
                {
                    MessageBox.Show("Üzgünüz,Emanet Oyuncak sayısı 3'ten fazla olamaz !!! ", "Uyarı");

                }
            }
            else
            {
                MessageBox.Show("Önce sepete oyuncak eklenmelidir", "Uyarı");

            }




        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    }

