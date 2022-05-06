namespace Mobilya_Proje
{
    internal class MySqlDataAdapter
    {
        private string sql;
        private MySqlConnection connection;

        public MySqlDataAdapter(string sql, MySqlConnection connection)
        {
            this.sql = sql;
            this.connection = connection;
        }
    }
}