using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Umuttepe_Surucu_Kursu
{
    public partial class KursiyerArama : Form
    {
        public KursiyerArama()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        private void KursiyerArama_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(200, 0, 0, 0);

            build.Server = "localhost";
            build.UserID = "root";
            build.Password = "Donki6612.";
            build.Database = "Umuttepe_Surucu_Kursu";
            baglanti = new MySqlConnection(build.ToString());
            Listele_Ara("Select*from aday_bılgılerı");
        }

        public DataTable Listele_Ara(string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter(sql, baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();

            return tbl;
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

        private void adayTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
