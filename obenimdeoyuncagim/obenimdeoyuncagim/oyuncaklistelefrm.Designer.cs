namespace obenimdeoyuncagim
{
    partial class oyuncaklistelefrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyuncaklistelefrm));
            this.comboturu = new System.Windows.Forms.ComboBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtrafno = new System.Windows.Forms.TextBox();
            this.txtstoksayisi = new System.Windows.Forms.TextBox();
            this.txtureticifirma = new System.Windows.Forms.TextBox();
            this.txtyasgrubu = new System.Windows.Forms.TextBox();
            this.txtoyuncakboyutu = new System.Windows.Forms.TextBox();
            this.txtoyuncakadi = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtbarkodara = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboturu
            // 
            this.comboturu.FormattingEnabled = true;
            this.comboturu.Items.AddRange(new object[] {
            "Ahşap Oyuncaklar",
            "Peluş Oyuncaklar",
            "Kutu Oyunları",
            "Bebek Oyuncaklar",
            "Araba Oyuncaklar",
            "Eğitici Oyuncaklar",
            "Puzzle"});
            this.comboturu.Location = new System.Drawing.Point(155, 199);
            this.comboturu.Name = "comboturu";
            this.comboturu.Size = new System.Drawing.Size(158, 24);
            this.comboturu.TabIndex = 44;
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageIndex = 2;
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(232, 385);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(98, 38);
            this.btnİptal.TabIndex = 43;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "refresh.png");
            this.ımageList1.Images.SetKeyName(1, "plus.png");
            this.ımageList1.Images.SetKeyName(2, "cancel (1).png");
            this.ımageList1.Images.SetKeyName(3, "deliver.png");
            this.ımageList1.Images.SetKeyName(4, "delete.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 0;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(94, 385);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 38);
            this.btnGuncelle.TabIndex = 42;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Üretici Firma:";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(155, 321);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(158, 22);
            this.txtaciklama.TabIndex = 40;
            // 
            // txtrafno
            // 
            this.txtrafno.Location = new System.Drawing.Point(155, 282);
            this.txtrafno.Name = "txtrafno";
            this.txtrafno.Size = new System.Drawing.Size(158, 22);
            this.txtrafno.TabIndex = 39;
            // 
            // txtstoksayisi
            // 
            this.txtstoksayisi.Location = new System.Drawing.Point(155, 244);
            this.txtstoksayisi.Name = "txtstoksayisi";
            this.txtstoksayisi.Size = new System.Drawing.Size(158, 22);
            this.txtstoksayisi.TabIndex = 38;
            // 
            // txtureticifirma
            // 
            this.txtureticifirma.Location = new System.Drawing.Point(155, 164);
            this.txtureticifirma.Name = "txtureticifirma";
            this.txtureticifirma.Size = new System.Drawing.Size(158, 22);
            this.txtureticifirma.TabIndex = 37;
            // 
            // txtyasgrubu
            // 
            this.txtyasgrubu.Location = new System.Drawing.Point(155, 127);
            this.txtyasgrubu.Name = "txtyasgrubu";
            this.txtyasgrubu.Size = new System.Drawing.Size(158, 22);
            this.txtyasgrubu.TabIndex = 36;
            // 
            // txtoyuncakboyutu
            // 
            this.txtoyuncakboyutu.Location = new System.Drawing.Point(155, 89);
            this.txtoyuncakboyutu.Name = "txtoyuncakboyutu";
            this.txtoyuncakboyutu.Size = new System.Drawing.Size(158, 22);
            this.txtoyuncakboyutu.TabIndex = 35;
            // 
            // txtoyuncakadi
            // 
            this.txtoyuncakadi.Location = new System.Drawing.Point(155, 51);
            this.txtoyuncakadi.Name = "txtoyuncakadi";
            this.txtoyuncakadi.Size = new System.Drawing.Size(158, 22);
            this.txtoyuncakadi.TabIndex = 34;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(155, 13);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(158, 22);
            this.txtbarkodno.TabIndex = 33;
            this.txtbarkodno.TextChanged += new System.EventHandler(this.txtbarkodno_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Raf No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Stok Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Oyuncak Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Oyuncak Yaş Grubu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Oyuncak Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Oyuncak Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Oyuncak Barkod No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 302);
            this.dataGridView1.TabIndex = 45;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 4;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(863, 385);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 45);
            this.btnSil.TabIndex = 46;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtbarkodara
            // 
            this.txtbarkodara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtbarkodara.Location = new System.Drawing.Point(659, 19);
            this.txtbarkodara.Name = "txtbarkodara";
            this.txtbarkodara.Size = new System.Drawing.Size(171, 22);
            this.txtbarkodara.TabIndex = 48;
            this.txtbarkodara.TextChanged += new System.EventHandler(this.textbarkodara_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Oyuncak Barkod No Ara";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtbarkodara);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.comboturu);
            this.groupBox1.Controls.Add(this.btnİptal);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.txtrafno);
            this.groupBox1.Controls.Add(this.txtstoksayisi);
            this.groupBox1.Controls.Add(this.txtureticifirma);
            this.groupBox1.Controls.Add(this.txtyasgrubu);
            this.groupBox1.Controls.Add(this.txtoyuncakboyutu);
            this.groupBox1.Controls.Add(this.txtoyuncakadi);
            this.groupBox1.Controls.Add(this.txtbarkodno);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 438);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // oyuncaklistelefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "oyuncaklistelefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyuncak Listeleme Sayfası";
            this.Load += new System.EventHandler(this.oyuncaklistelefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboturu;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtrafno;
        private System.Windows.Forms.TextBox txtstoksayisi;
        private System.Windows.Forms.TextBox txtureticifirma;
        private System.Windows.Forms.TextBox txtyasgrubu;
        private System.Windows.Forms.TextBox txtoyuncakboyutu;
        private System.Windows.Forms.TextBox txtoyuncakadi;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtbarkodara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}