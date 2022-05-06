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
    public partial class Kursiyer_bilgileri : Form
    {
        public Kursiyer_bilgileri()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa f1 = new AnaSayfa();
            f1.Show();
            Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            AnaSayfa f1 = new AnaSayfa();
            f1.Show();
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

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telefon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ekle_Click(object sender, EventArgs e)
        {
            
        }
       
        private void Kursiyer_bilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'surucu_kursuDataSet7.aday_bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aday_bilgileriTableAdapter3.Fill(this.surucu_kursuDataSet7.aday_bilgileri);


        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();

            try
            {
                if (adayid.Text == "" || tc.Text == "" || ad.Text == "" || soyad.Text == "" || yas.Text == "" || telefon.Text == "" || saglik.Text == "" || adli.Text == "" || kayıtTarihi.Text == "" || ehliyetTur.Text == "" || ogrenim.Text == "")
                {

                }
                else
                {
                    if (tc.TextLength < 11 || tc.TextLength > 11)
                    {

                        MessageBox.Show("Lütfen 11 haneli TC Kimlik numaranızı giriniz!");

                    }
                    else
                    {
                        baglanti.SqlProcess("insert into not_bilgileri(adayid)values('" + adayid.Text + "') ");
                        baglanti.SqlProcess("insert into aday_bilgileri(adayid,tc,ad,soyad,yas,telefon,saglik_raporu,adli_belge,kayit_tarihi,ehliyet_tur,ogrenim_durumu)values('" + adayid.Text + "','" + tc.Text + "','" + ad.Text + "','" + soyad.Text + "','" + yas.Text + "','" + telefon.Text + "','" + saglik.Text + "','" + adli.Text + "','" + kayıtTarihi.Value + "','" +ehliyetTur.Text + "','" + ogrenim.Text + "')");
                        
                        MessageBox.Show("Bilgiler Başarıyla Güncellendi");


                        AnaSayfa f1 = new AnaSayfa();
                        f1.Show();
                        Hide();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu!!" + error.Message);
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();

            try
            {

                if (tc.TextLength < 11 || tc.TextLength > 11)
                {
                    MessageBox.Show("Hatalı TC girdiniz!!");
                }
                else
                {
                    SqlDataReader okuyucu = baglanti.VeriOkuyucu("select  * from aday_bilgileri where tc='" + tc.Text + "'");
                    if (okuyucu.HasRows)
                    {
                        baglanti.CloseConnection();
                        baglanti.SqlProcess("DELETE from aday_bilgileri where tc='" + tc.Text + "'");
                        baglanti.SqlProcess("DELETE from not_bilgileri where tc'" + tc.Text + "'");
                        MessageBox.Show("Kullanıcı silindi!");
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
                MessageBox.Show("Hatalı giriş!!" + error.Message);
            }
        }

        private void ehliyetTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
