using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace obenimdeoyuncagim
{

    public partial class AnaSayfafrm : Form
    {

        public AnaSayfafrm()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEklefrm frm = new UyeEklefrm();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyeliste = new UyeListelemefrm();
            uyeliste.ShowDialog();
        }

        private void btnOyuncakEkle_Click(object sender, EventArgs e)
        {
            OyuncakEklefrm oyuncakekle= new OyuncakEklefrm();
            oyuncakekle.ShowDialog();        }

        private void btnOyuncakListele_Click(object sender, EventArgs e)
        {
            oyuncaklistelefrm oyuncaklistele = new oyuncaklistelefrm();
            oyuncaklistele.ShowDialog();
        }

        private void AnaSayfafrm_Load(object sender, EventArgs e)
        {

        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            emanetoyuncakverfrm emanetoyuncakver = new emanetoyuncakverfrm();
            emanetoyuncakver.ShowDialog();
        }

        private void OyuncakListele_Click(object sender, EventArgs e)
        {
            emanetoyuncaklistelefrm listele = new emanetoyuncaklistelefrm();
            listele.ShowDialog();
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            emanetoyuncakiadefrm iade = new emanetoyuncakiadefrm();
            iade.ShowDialog();
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            sıralamafrm sırala = new sıralamafrm();
            sırala.ShowDialog();
        }

        private void BtnTrafik_Click(object sender, EventArgs e)
        {
            grafikfrm grafik= new grafikfrm();
            grafik.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            mailgonderfrm mailgonder = new mailgonderfrm();
            mailgonder.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grafikfrm2 grafik2 = new grafikfrm2();
            grafik2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grafikfrm3 grafik3 = new grafikfrm3();
            grafik3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grafikfrm4 grafik4 = new grafikfrm4();
            grafik4.ShowDialog();
        }
    }
}