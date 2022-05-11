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

    public partial class PersonelBilgi : Form
    {
        public PersonelBilgi()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa f1 = new AnaSayfa();
            f1.Show();
            Hide();

        }

        private void PersonelBilgi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'surucu_kursuDataSet.personel_bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personel_bilgileriTableAdapter.Fill(this.surucu_kursuDataSet.personel_bilgileri);
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

        //https://www.youtube.com/watch?v=6Qw73qDj8VQ&ab_channel=AhmetHakanErg%C3%BCn 

        private void tc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gorev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();

            try
            {
                if (tc1.Text == "" || ad.Text == "" || soyad.Text == ""||telefon.Text==""||eposta.Text==""||gorev.Text==""||adres.Text=="")
                {

                }
                else
                {
                    if (tc1.TextLength < 11 || tc1.TextLength > 11)
                    {
                        MessageBox.Show("Lütfen 11 haneli TC Kimlik numaranızı giriniz!!");

                    }
                    else
                    {
                        baglanti.SqlProcess("insert into personel_bilgileri(per_tc,per_ad,per_soyad,telefon,e_posta,gorev,adres)values('" + tc1.Text + "','" + ad.Text + "','" + soyad.Text + "','" + telefon.Text+ "','" + eposta.Text + "','" + gorev.Text + "','" + adres.Text + "')");
                        MessageBox.Show("Bilgiler Başarıyla Güncellendi");

                        AnaSayfa f1 = new AnaSayfa();
                        f1.Show();
                        Hide();
                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("İşlem Sırasında Hata Oluştu." + error.Message);
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            VeriBaglanti baglanti = new VeriBaglanti();

            try
            {
                
                if (tc1.TextLength < 11 || tc1.TextLength > 11)
                {
                    MessageBox.Show("Hatalı TC girdiniz!!");
                }
                else
                {
                    SqlDataReader okuyucu = baglanti.VeriOkuyucu("select  * from personel_bilgileri where per_tc='" + tc1.Text + "'");
                    if (okuyucu.HasRows)
                    {
                        baglanti.CloseConnection();
                        baglanti.SqlProcess("DELETE from personel_bilgileri where per_tc='" + tc1.Text + "'");
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

        private void tc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
