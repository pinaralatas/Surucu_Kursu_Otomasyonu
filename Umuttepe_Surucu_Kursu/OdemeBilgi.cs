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
            // TODO: Bu kod satırı 'surucu_kursuDataSet14.borc' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borcTableAdapter1.Fill(this.surucu_kursuDataSet14.borc);



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
                if (kredi.Checked)
                {


                    if (kartNo.Text.ToString() == "" || kartAd.Text == "" || kartSoyad.Text == ""
                        || cvv.Text == "" || ay.Text == "" || yıl.Text == "" || adayid.Text == ""|| odenecek_miktar.Text == "")
                    {
                        MessageBox.Show("Bütün boşlukları doldurunuz!!");
                    }
                    else
                    {

                        SqlDataReader reader = baglanti.VeriOkuyucu("select  * from borc where adayid='" + adayid.Text.ToString() + "'");

                        if (reader.HasRows)
                        {
                            baglanti.CloseConnection();
                            SqlDataReader reader1 = baglanti.VeriOkuyucu("select  * from borc where adayid='" + adayid.Text.ToString() + "'and kalan_borc+1>'" + Convert.ToInt32(odenecek_miktar.Text) + "'");
                            if (reader1.HasRows)
                            {
                                baglanti.SqlProcess("update borc SET cvv='" + cvv.Text + "'," +
                                                               "kart_sahibinin_adi='" + kartAd.Text + "'," +
                                                               "kart_sahibinin_soyad='" + kartSoyad.Text + "'," +
                                                               "son_ay='" + ay.Text + "',son_yil='" + yıl.Text + "'," +
                                                               "kart_no='" + kartNo.Text.ToString() + "',son_odenen_tutar='" + odenecek_miktar.Text + "',kalan_borc=(kalan_borc-'" + odenecek_miktar.Text + "'), son_odeme_turu='Kredi Kartı' where adayid='" + adayid.Text.ToString() + "' ");

                                MessageBox.Show("Ödeme bilgileri başarıyla güncellendi");
                                AnaSayfa anaSayfa = new AnaSayfa();
                                anaSayfa.Show(this);
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kalan borç ödenicek miktardan az olamaz!!!");
                            }

                           

                        }
                        else
                        {
                            MessageBox.Show("Böyle bir kullanıcı bulunamadı!!");
                        }


                    }
                }
                else
                {

                    if (odenecek_miktar.Text == "" || adayid.Text.ToString() == "")
                    {
                        MessageBox.Show("Bütün boşlukları doldurunuz!!");
                    }
                    else
                    {

                        SqlDataReader reader = baglanti.VeriOkuyucu("select  * from borc where adayid='" + adayid.Text.ToString() + "'");

                        if (reader.HasRows)
                        {
                          
                            baglanti.CloseConnection();
                            SqlDataReader reader1 = baglanti.VeriOkuyucu("select  * from borc where adayid='" + adayid.Text.ToString() + "'and kalan_borc+1>'"+Convert.ToInt32(odenecek_miktar.Text)+"'");
                            if (reader1.HasRows)
                            {
                                baglanti.CloseConnection();
                                baglanti.SqlProcess("update borc SET son_odenen_tutar='" + odenecek_miktar.Text + "'," +
                                "kalan_borc=(kalan_borc-'" + odenecek_miktar.Text + "'), " +
                                "son_odeme_turu='Nakit' where adayid='" + adayid.Text.ToString() + "' ");
                                MessageBox.Show("Ödeme bilgileri başarıyla güncellendi");
                                AnaSayfa anaSayfa = new AnaSayfa();
                                anaSayfa.Show(this);
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kalan borç ödenicek miktardan az olamaz!!!");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Böyle bir kullanıcı bulunamadı!!");
                        }

                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + error.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
