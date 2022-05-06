using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (kullanıcıAd.Text == "Bilişim")
            {

                if (yeniSifre.Text == sifreTekrar.Text)
                {
                    MessageBox.Show("Şifreniz başarıyla güncellenmiştir");
                    GirisForm f4 = new GirisForm();
                    f4.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Yazdığınız şifreler birbiriyle uyuşmamaktadır!");
                }
            }
            else if (kullanıcıAd.Text=="")
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez!");

            }
            else
            {
                MessageBox.Show("Kullanıcı adını yanlış girdiniz!");
                
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
