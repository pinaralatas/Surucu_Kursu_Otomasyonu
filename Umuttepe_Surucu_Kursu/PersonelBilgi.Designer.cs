namespace Umuttepe_Surucu_Kursu
{
    partial class PersonelBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelBilgi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelbilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surucu_kursuDataSet = new Umuttepe_Surucu_Kursu.surucu_kursuDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.gorev = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.eposta = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.tc1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personel_bilgileriTableAdapter = new Umuttepe_Surucu_Kursu.surucu_kursuDataSetTableAdapters.personel_bilgileriTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.pertcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelbilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surucu_kursuDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 449);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pertcDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.gorevDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelbilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // personelbilgileriBindingSource
            // 
            this.personelbilgileriBindingSource.DataMember = "personel_bilgileri";
            this.personelbilgileriBindingSource.DataSource = this.surucu_kursuDataSet;
            // 
            // surucu_kursuDataSet
            // 
            this.surucu_kursuDataSet.DataSetName = "surucu_kursuDataSet";
            this.surucu_kursuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.sil);
            this.panel2.Controls.Add(this.guncelle);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.adres);
            this.panel2.Controls.Add(this.gorev);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.eposta);
            this.panel2.Controls.Add(this.telefon);
            this.panel2.Controls.Add(this.soyad);
            this.panel2.Controls.Add(this.ad);
            this.panel2.Controls.Add(this.tc1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 289);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(590, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 29);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(711, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(703, 248);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(82, 33);
            this.sil.TabIndex = 18;
            this.sil.Text = "            SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(587, 248);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(110, 33);
            this.guncelle.TabIndex = 17;
            this.guncelle.Text = "           GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(694, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "          GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(369, 140);
            this.adres.MaxLength = 255;
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(367, 93);
            this.adres.TabIndex = 14;
            // 
            // gorev
            // 
            this.gorev.Location = new System.Drawing.Point(369, 100);
            this.gorev.Name = "gorev";
            this.gorev.Size = new System.Drawing.Size(118, 20);
            this.gorev.TabIndex = 13;
            this.gorev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasilinca);
            this.gorev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gorev_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(338, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Personel Bilgileri";
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(369, 59);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(118, 20);
            this.eposta.TabIndex = 11;
            this.eposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasilinca);
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(124, 186);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(118, 20);
            this.telefon.TabIndex = 10;
            this.telefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasilinca);
            this.telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefon_KeyPress);
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(124, 143);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(118, 20);
            this.soyad.TabIndex = 9;
            this.soyad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasilinca);
            this.soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_KeyPress);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(124, 100);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(118, 20);
            this.ad.TabIndex = 8;
            this.ad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasilinca);
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // tc1
            // 
            this.tc1.Location = new System.Drawing.Point(124, 59);
            this.tc1.MaxLength = 11;
            this.tc1.Name = "tc1";
            this.tc1.Size = new System.Drawing.Size(118, 20);
            this.tc1.TabIndex = 7;
            this.tc1.TextChanged += new System.EventHandler(this.tc1_TextChanged);
            this.tc1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasilinca);
            this.tc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(311, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(311, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Görev :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(304, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-posta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "**T.C Kimlik :";
            // 
            // personel_bilgileriTableAdapter
            // 
            this.personel_bilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(55, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "**Lütfen silmek istediğiniz personelin TC\'sini giriniz!";
            // 
            // pertcDataGridViewTextBoxColumn
            // 
            this.pertcDataGridViewTextBoxColumn.DataPropertyName = "per_tc";
            this.pertcDataGridViewTextBoxColumn.HeaderText = "T.C";
            this.pertcDataGridViewTextBoxColumn.Name = "pertcDataGridViewTextBoxColumn";
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "per_ad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "Personel Ad";
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "per_soyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "Personel Soyad";
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "e_posta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "E-Posta";
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            // 
            // gorevDataGridViewTextBoxColumn
            // 
            this.gorevDataGridViewTextBoxColumn.DataPropertyName = "gorev";
            this.gorevDataGridViewTextBoxColumn.HeaderText = "Görev";
            this.gorevDataGridViewTextBoxColumn.Name = "gorevDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // PersonelBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "PersonelBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Bilgileri";
            this.Load += new System.EventHandler(this.PersonelBilgi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelbilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surucu_kursuDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox gorev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox tc1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private surucu_kursuDataSet surucu_kursuDataSet;
        private System.Windows.Forms.BindingSource personelbilgileriBindingSource;
        private surucu_kursuDataSetTableAdapters.personel_bilgileriTableAdapter personel_bilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pertcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}