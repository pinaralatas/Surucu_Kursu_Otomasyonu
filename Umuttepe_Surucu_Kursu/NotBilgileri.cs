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
    public partial class NotBilgileri : Form
    {
        public NotBilgileri()
        {
            InitializeComponent();
        }
        
        private void NotBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'surucu_kursuDataSet12.aday_bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aday_bilgileriTableAdapter.Fill(this.surucu_kursuDataSet12.aday_bilgileri);
            
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa f1 = new AnaSayfa();
            f1.Show();
            Hide();
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

        private void trafikNot_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void motorNot_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guncelle_Click_1(object sender, EventArgs e)
        {
           VeriBaglanti baglanti = new VeriBaglanti();

            try
            {
                if (tc.Text == "" || motorNot.Text == "" || trafikNot.Text == "")
                {
                    MessageBox.Show("Bütün boşlukları doldurunuz!!");
                }
                else
                {              
                    
                    SqlDataReader reader = baglanti.VeriOkuyucu("select  * from aday_bilgileri where tc='" + tc.Text.ToString() + "'");
                    if (reader.HasRows)
                    {
                        baglanti.CloseConnection();

                        baglanti.SqlProcess("update aday_bilgileri SET trafik_sinav_notu='" + trafikNot.Text + "',motor_sinav_notu='" + motorNot.Text + "',sinav_tarihi='" + sinavTarihi.Value + "' where tc='" + tc.Text + "' ");

                        MessageBox.Show("Not durumu başarıyla güncellendi");
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

        private void adayid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
