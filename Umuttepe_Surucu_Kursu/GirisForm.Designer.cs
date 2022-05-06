namespace Umuttepe_Surucu_Kursu
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sifreUnut = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.KullanıcıAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.sifreUnut);
            this.panel1.Controls.Add(this.giris);
            this.panel1.Controls.Add(this.sifre);
            this.panel1.Controls.Add(this.KullanıcıAd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(211, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 299);
            this.panel1.TabIndex = 0;
            // 
            // sifreUnut
            // 
            this.sifreUnut.Location = new System.Drawing.Point(273, 259);
            this.sifreUnut.Name = "sifreUnut";
            this.sifreUnut.Size = new System.Drawing.Size(102, 23);
            this.sifreUnut.TabIndex = 8;
            this.sifreUnut.Text = "Şifremi Unuttum";
            this.sifreUnut.UseVisualStyleBackColor = true;
            this.sifreUnut.Click += new System.EventHandler(this.sifreUnut_Click);
            this.sifreUnut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // giris
            // 
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.Color.Black;
            this.giris.Location = new System.Drawing.Point(138, 208);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(124, 33);
            this.giris.TabIndex = 7;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            this.giris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(100, 159);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(191, 20);
            this.sifre.TabIndex = 5;
            this.sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // KullanıcıAd
            // 
            this.KullanıcıAd.Location = new System.Drawing.Point(100, 101);
            this.KullanıcıAd.Name = "KullanıcıAd";
            this.KullanıcıAd.Size = new System.Drawing.Size(191, 20);
            this.KullanıcıAd.TabIndex = 4;
            this.KullanıcıAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TusaBasinca);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Formu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(753, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sifreUnut;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox KullanıcıAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}