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
    public partial class SifreYenileme : Form
    {
        public SifreYenileme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();
            SqlDataReader okuyucu = baglanti.VeriOkuyucu("select  * from kullanici where kullanici_adi='" + kullanıcıAd.Text + "'");

            try
            {
                if (kullanıcıAd.Text==""||yeniSifre.Text.ToString()==""||sifreTekrar.Text.ToString()=="")
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız!!");
                }
                else
                {
                    if (yeniSifre.Text.ToString() == sifreTekrar.Text.ToString())
                    {
                        baglanti.CloseConnection();
                        baglanti.SqlProcess("update kullanici SET sifre='" + yeniSifre.Text.ToString() + "'where kullanici_adi='" + kullanıcıAd.Text + "'");
                        MessageBox.Show("Şifre başarıyla güncellenmiştir");
                        GirisForm f1 = new GirisForm();
                        f1.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz şifreler birbiriyle uyuşmamaktadır!!");
                    }

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("İşleminiz başarısız,lütfen tekrar deneyin!!");

                throw;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            GirisForm f4 = new GirisForm();
            f4.Show();
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
