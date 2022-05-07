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
    public partial class OdemeBilgi : Form
    {
        public OdemeBilgi()
        {
            InitializeComponent();
        }     

        private void OdemeBilgi_Load(object sender, EventArgs e)
        {

            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;

            kartAd.Enabled = false;
            kartSoyad.Enabled = false;
            cvv.Enabled = false;
            kartNo.Enabled = false;

            ay.Enabled = false;
            yıl.Enabled = false;


            panel3.BackColor = Color.FromArgb(150, 0, 0, 0);

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa f2 = new AnaSayfa();
            f2.Show();
            Hide();
        }       

        private void kredi_CheckedChanged(object sender, EventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;

            kartAd.Enabled = true;
            kartSoyad.Enabled = true;
            cvv.Enabled = true;
            kartNo.Enabled = true;

            ay.Enabled = true;
            yıl.Enabled = true;
        }

        private void nakit_CheckedChanged(object sender, EventArgs e)
        {
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;

            kartAd.Enabled = false;
            kartSoyad.Enabled = false;
            cvv.Enabled = false;
            kartNo.Enabled = false;

            ay.Enabled = false;
            yıl.Enabled = false;

        }

        private void TusaBasilinca(object sender, KeyEventArgs e)
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

        private void kartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kartAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void kartSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();

            try
            {
                if (kartNo.Text == "" || kartAd.Text == "" || kartSoyad.Text == "" || kartSoyad.Text == "" || cvv.Text == "" || ay.Text == "" || yıl.Text == "")
                {

                }
                else
                {

                    SqlDataReader reader = baglanti.VeriOkuyucu("select  * from odeme_bilgileri where tc='" + tc.Text.ToString() + "'");
                    if (reader.HasRows)
                    {
                        baglanti.CloseConnection();

                        baglanti.SqlProcess("update odeme_bilgileri SET cvv='" + cvv.Text + "',kart_sahibinin_adi='" + kartAd.Text + "',kart_sahibinin_soyadi='" + kartSoyad.Text + "',son_ay='" + ay.Text + "',son_yil='" + yıl.Text + "',tc='" + tc.Text + "' where kart_no='" + kartNo.Text + "' ");

                        MessageBox.Show("Ödeme bilgileri başarıyla güncellendi");
                        AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show(this);
                        Hide();
                        //idodeme_tur için formda doldurulması gereken alan yok?
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı bulunamadı!!");
                    }


                }
            }
            catch (Exception error)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + error.Message);
            }
        }
    }
}
