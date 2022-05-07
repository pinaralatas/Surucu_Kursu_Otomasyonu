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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AdayBilgileri_Click(object sender, EventArgs e)
        {
            Kursiyer_bilgileri k1 = new Kursiyer_bilgileri();
            k1.Show();
            Hide();

        }

        private void NufusBilgileri_Click(object sender, EventArgs e)
        {
            nufus_bilgi n1 = new nufus_bilgi();
            n1.Show();
            Hide();
            
        }

        private void not_bilgi_kaydet_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            GirisForm f1 = new GirisForm();
            f1.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void NotBilgileri_Click(object sender, EventArgs e)
        {
            NotBilgileri f1 = new NotBilgileri();
            f1.Show();
            Hide();

        }

        private void Odemeler_Click(object sender, EventArgs e)
        {
            OdemeBilgi f6 =new OdemeBilgi();
            f6.Show();
            Hide();
                
        }

        private void PersonelBilgi_Click(object sender, EventArgs e)
        {
            PersonelBilgi f7 = new PersonelBilgi();
            f7.Show();
            Hide();
        }

        

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
