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
    public partial class nufus_bilgi : Form
    {
        public nufus_bilgi()
        {
            InitializeComponent();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa form1 = new AnaSayfa();
            form1.Show();
            Hide();

            
        }

        private void nufus_bilgi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'surucu_kursuDataSet9.nufus_bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.nufus_bilgileriTableAdapter1.Fill(this.surucu_kursuDataSet9.nufus_bilgileri);

            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);

           
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

        private void seriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void babaAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void anneAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void dogumYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();

            try
            {
                if (seriNo.Text == "" || babaAd.Text == "" || anneAd.Text == ""
                    ||dogumYeri.Text == "" || dogumTarihi.Text == "" 
                    || kanGrubu.Text == "" || medeniHal.Text == "")
                {

                }
                else
                {

                    SqlDataReader reader = baglanti.VeriOkuyucu("select  * from aday_bilgileri where seri_no='" + seriNo.Text.ToString() + "'");

                    if (reader.HasRows)
                    {
                        baglanti.CloseConnection();

                       
                        baglanti.SqlProcess("update nufus_bilgileri SET baba_adi='" + babaAd.Text + "',anne_adi='" + anneAd.Text + "'," +
                            "dogum_yeri='" + dogumYeri.Text + "',dogum_tarih='" + dogumTarihi.Value + "',kan_grubu='" + kanGrubu.Text + "'," +
                            "medeni_hal='" + medeniHal.Text + "'where seri_no='" + seriNo.Text.ToString() + "' ");

                        MessageBox.Show("Nüfus bilgileri başarıyla güncellendi");
                        AnaSayfa anaSayfa = new AnaSayfa();
                        anaSayfa.Show(this);
                        Hide();

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
