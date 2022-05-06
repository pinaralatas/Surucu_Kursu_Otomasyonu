namespace Umuttepe_Surucu_Kursu
{
    partial class SifreYenileme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreTekrar = new System.Windows.Forms.TextBox();
            this.yeniSifre = new System.Windows.Forms.TextBox();
            this.kullanıcıAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 316);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(38, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 35);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(443, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.guncelle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sifreTekrar);
            this.panel3.Controls.Add(this.yeniSifre);
            this.panel3.Controls.Add(this.kullanıcıAd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(38, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 281);
            this.panel3.TabIndex = 2;
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.Location = new System.Drawing.Point(177, 217);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(109, 31);
            this.guncelle.TabIndex = 6;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.button1_Click);
            this.guncelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Şifre Tekrar :";
            // 
            // sifreTekrar
            // 
            this.sifreTekrar.Location = new System.Drawing.Point(233, 157);
            this.sifreTekrar.Name = "sifreTekrar";
            this.sifreTekrar.Size = new System.Drawing.Size(134, 20);
            this.sifreTekrar.TabIndex = 4;
            this.sifreTekrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // yeniSifre
            // 
            this.yeniSifre.Location = new System.Drawing.Point(233, 98);
            this.yeniSifre.Name = "yeniSifre";
            this.yeniSifre.Size = new System.Drawing.Size(134, 20);
            this.yeniSifre.TabIndex = 3;
            this.yeniSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // kullanıcıAd
            // 
            this.kullanıcıAd.Location = new System.Drawing.Point(233, 42);
            this.kullanıcıAd.Name = "kullanıcıAd";
            this.kullanıcıAd.Size = new System.Drawing.Size(134, 20);
            this.kullanıcıAd.TabIndex = 2;
            this.kullanıcıAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // SifreYenileme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 317);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SifreYenileme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Yenileme";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreTekrar;
        private System.Windows.Forms.TextBox yeniSifre;
        private System.Windows.Forms.TextBox kullanıcıAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label4;
    }
}