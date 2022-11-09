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
using System.Data.SqlClient;

namespace obenimdeoyuncagim
{
    public partial class mailgonderfrm : Form
    {
        public mailgonderfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = oyuncakisterim; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
           MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("oyuncakotomasyonu@outlook.com", "123b123.");
            istemci.Port = 587;
            istemci.Host = "smtp.office365.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(textBox1.Text);
            mesajım.From = new MailAddress("oyuncakotomasyonu@outlook.com");
            mesajım.Subject= textBox2.Text;
            mesajım.Body = textBox3.Text;
            istemci.Send(mesajım);

            MessageBox.Show("Mail Gönderildi!!");
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
