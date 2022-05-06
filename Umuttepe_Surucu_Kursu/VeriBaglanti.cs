using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umuttepe_Surucu_Kursu
{
    public class VeriBaglanti
    {
        public string baglantiStr;

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataReader okuyucu;

        public VeriBaglanti()
        {

            baglantiStr = "server=DESKTOP-P9EIUR1\\SQLEXPRESS; Initial Catalog=surucu_kursu;Integrated Security=True";
            baglanti = new SqlConnection(baglantiStr);
        }

      
        public SqlDataReader VeriOkuyucu(string query)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(query, baglanti);
            var execute = cmd.ExecuteReader();
            return execute;
        }

        public void SqlProcess(string query)
        { 
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand(query, baglanti);
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
        }

        public void CloseConnection()
        {
            baglanti.Close();
        }
        public void OpenConnection()
        {
            baglanti.Open();
        }


    }
}
