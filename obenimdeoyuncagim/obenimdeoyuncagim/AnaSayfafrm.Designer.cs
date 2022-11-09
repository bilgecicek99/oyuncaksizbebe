namespace obenimdeoyuncagim
{
    partial class AnaSayfafrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfafrm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSiralama = new System.Windows.Forms.Button();
            this.BtnTrafik = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.OyuncakListele = new System.Windows.Forms.Button();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOyuncakEkle = new System.Windows.Forms.Button();
            this.btnOyuncakListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "growth.png");
            this.ımageList1.Images.SetKeyName(1, "to-do-list.png");
            this.ımageList1.Images.SetKeyName(2, "toys (1).png");
            this.ımageList1.Images.SetKeyName(3, "customer.png");
            this.ımageList1.Images.SetKeyName(4, "add-friend.png");
            this.ımageList1.Images.SetKeyName(5, "children.png");
            this.ımageList1.Images.SetKeyName(6, "baby-boy.png");
            this.ımageList1.Images.SetKeyName(7, "baby-girl.png");
            this.ımageList1.Images.SetKeyName(8, "toys.png");
            this.ımageList1.Images.SetKeyName(9, "teddy-bear.png");
            this.ımageList1.Images.SetKeyName(10, "donation (1).png");
            this.ımageList1.Images.SetKeyName(11, "donation.png");
            this.ımageList1.Images.SetKeyName(12, "toy-shop.png");
            this.ımageList1.Images.SetKeyName(13, "storage-box (1).png");
            this.ımageList1.Images.SetKeyName(14, "sending.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(6, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Üye Listeleme işlemleri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Üye Ekleme İşlemleri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye işlemleri";
            // 
            // btnSiralama
            // 
            this.btnSiralama.BackColor = System.Drawing.Color.White;
            this.btnSiralama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiralama.ImageIndex = 1;
            this.btnSiralama.ImageList = this.ımageList1;
            this.btnSiralama.Location = new System.Drawing.Point(32, 14);
            this.btnSiralama.Name = "btnSiralama";
            this.btnSiralama.Size = new System.Drawing.Size(314, 46);
            this.btnSiralama.TabIndex = 7;
            this.btnSiralama.Text = "Sıralama";
            this.btnSiralama.UseVisualStyleBackColor = false;
            this.btnSiralama.Click += new System.EventHandler(this.btnSiralama_Click);
            // 
            // BtnTrafik
            // 
            this.BtnTrafik.BackColor = System.Drawing.Color.White;
            this.BtnTrafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrafik.ImageIndex = 0;
            this.BtnTrafik.ImageList = this.ımageList1;
            this.BtnTrafik.Location = new System.Drawing.Point(33, 69);
            this.BtnTrafik.Name = "BtnTrafik";
            this.BtnTrafik.Size = new System.Drawing.Size(314, 42);
            this.BtnTrafik.TabIndex = 10;
            this.BtnTrafik.Text = "Oyuncak Sayısı - Kişi Grafiği";
            this.BtnTrafik.UseVisualStyleBackColor = false;
            this.BtnTrafik.Click += new System.EventHandler(this.BtnTrafik_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.BtnTrafik);
            this.groupBox4.Controls.Add(this.btnSiralama);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(406, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 253);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.White;
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.ImageIndex = 9;
            this.btnEmanetVer.ImageList = this.ımageList1;
            this.btnEmanetVer.Location = new System.Drawing.Point(17, 14);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(311, 44);
            this.btnEmanetVer.TabIndex = 4;
            this.btnEmanetVer.Text = "Emanet Oyuncak Verme İşlemleri";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // OyuncakListele
            // 
            this.OyuncakListele.BackColor = System.Drawing.Color.White;
            this.OyuncakListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OyuncakListele.ImageIndex = 13;
            this.OyuncakListele.ImageList = this.ımageList1;
            this.OyuncakListele.Location = new System.Drawing.Point(16, 69);
            this.OyuncakListele.Name = "OyuncakListele";
            this.OyuncakListele.Size = new System.Drawing.Size(311, 43);
            this.OyuncakListele.TabIndex = 5;
            this.OyuncakListele.Text = "Oyuncak Listeleme İşlemleri";
            this.OyuncakListele.UseVisualStyleBackColor = false;
            this.OyuncakListele.Click += new System.EventHandler(this.OyuncakListele_Click);
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.BackColor = System.Drawing.Color.White;
            this.btnEmanetİade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetİade.ImageIndex = 12;
            this.btnEmanetİade.ImageList = this.ımageList1;
            this.btnEmanetİade.Location = new System.Drawing.Point(16, 118);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(311, 49);
            this.btnEmanetİade.TabIndex = 6;
            this.btnEmanetİade.Text = "Oyuncak Emanet İade İşlemleri";
            this.btnEmanetİade.UseVisualStyleBackColor = false;
            this.btnEmanetİade.Click += new System.EventHandler(this.btnEmanetİade_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 14;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(17, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "Mail Gönderme İşlemleri";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btnEmanetİade);
            this.groupBox3.Controls.Add(this.OyuncakListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Location = new System.Drawing.Point(3, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 235);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Oyuncak İşlemleri";
            // 
            // btnOyuncakEkle
            // 
            this.btnOyuncakEkle.BackColor = System.Drawing.Color.White;
            this.btnOyuncakEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOyuncakEkle.ImageIndex = 8;
            this.btnOyuncakEkle.ImageList = this.ımageList1;
            this.btnOyuncakEkle.Location = new System.Drawing.Point(33, 21);
            this.btnOyuncakEkle.Name = "btnOyuncakEkle";
            this.btnOyuncakEkle.Size = new System.Drawing.Size(314, 47);
            this.btnOyuncakEkle.TabIndex = 2;
            this.btnOyuncakEkle.Text = "Oyuncak Ekleme İşlemleri";
            this.btnOyuncakEkle.UseVisualStyleBackColor = false;
            this.btnOyuncakEkle.Click += new System.EventHandler(this.btnOyuncakEkle_Click);
            // 
            // btnOyuncakListele
            // 
            this.btnOyuncakListele.BackColor = System.Drawing.Color.White;
            this.btnOyuncakListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOyuncakListele.ImageIndex = 2;
            this.btnOyuncakListele.ImageList = this.ımageList1;
            this.btnOyuncakListele.Location = new System.Drawing.Point(33, 74);
            this.btnOyuncakListele.Name = "btnOyuncakListele";
            this.btnOyuncakListele.Size = new System.Drawing.Size(314, 53);
            this.btnOyuncakListele.TabIndex = 3;
            this.btnOyuncakListele.Text = "Oyuncak Listeleme İşlemleri";
            this.btnOyuncakListele.UseVisualStyleBackColor = false;
            this.btnOyuncakListele.Click += new System.EventHandler(this.btnOyuncakListele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnOyuncakListele);
            this.groupBox2.Controls.Add(this.btnOyuncakEkle);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(406, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyuncak İşlemleri";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(136, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 543);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(32, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(313, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Yaş Grubu- Oyuncak Sayısı Grafiği";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(32, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(313, 41);
            this.button5.TabIndex = 12;
            this.button5.Text = "Oyuncak Türü - Stok Sayısı Grafiği";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageIndex = 0;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(32, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(313, 39);
            this.button6.TabIndex = 13;
            this.button6.Text = "Cinsiyet-Oyuncak Sayısı Grafiği";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AnaSayfafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1136, 539);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "AnaSayfafrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfafrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSiralama;
        private System.Windows.Forms.Button BtnTrafik;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button OyuncakListele;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOyuncakEkle;
        private System.Windows.Forms.Button btnOyuncakListele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

