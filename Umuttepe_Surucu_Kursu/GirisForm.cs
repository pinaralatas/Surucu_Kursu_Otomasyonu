using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umuttepe_Surucu_Kursu
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();

            if (KullanıcıAd.Text==""|| sifre.Text.ToString()=="")
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı boş geçilemez!");
            }            
            else
            {
                SqlDataReader okuyucu = baglanti.VeriOkuyucu("select  * from kullanici where kullanici_adi='" + KullanıcıAd.Text + "'and sifre='"+sifre.Text.ToString()+"'");
                if (okuyucu.Read())
                {
                    MessageBox.Show("Giriş başarılı.");
                    AnaSayfa giriş = new AnaSayfa();
                    giriş.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Şifre veya Kullanıcı Adı hatalı.");
                }

            }
        }

        private void sifreUnut_Click(object sender, EventArgs e)
        {
            SifreYenileme f9 = new SifreYenileme();
            f9.Show();
            Hide();
        }

        private void TusaBasinca(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
        }

        
    }
}
