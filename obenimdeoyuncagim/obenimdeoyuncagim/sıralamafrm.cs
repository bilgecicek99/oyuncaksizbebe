﻿using System;
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
    public partial class sıralamafrm : Form
    {
        public sıralamafrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        DataSet daset = new DataSet();
        private void sıralamafrm_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Uye order by oyuncaksayisi desc", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
            label3.Text = "";
            label4.Text = "";
            label3.Text = daset.Tables["Uye"].Rows[0]["adsoyad"].ToString()+"=";
            label3.Text+=daset.Tables["Uye"].Rows[0]["oyuncaksayisi"].ToString();
            label4.Text = daset.Tables["Uye"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString()+"=";
            label4.Text += daset.Tables["Uye"].Rows[dataGridView1.Rows.Count - 2]["oyuncaksayisi"].ToString();
        }
    }
}
