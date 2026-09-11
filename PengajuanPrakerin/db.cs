
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace PengajuanPrakerin
{
    class db
    {
        // Sesuaikan server/username/password sesuai konfigurasi MySQL di komputer masing-masing
        public static MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1; username=root; password=; database=db_prakerin");

        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string sql)
        {
            Console.WriteLine(sql);
            ds.Tables.Clear();
            perintah = new MySqlCommand(sql, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
    }
}
