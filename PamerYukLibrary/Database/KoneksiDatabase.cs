using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace PamerYukLibrary.Database
{
    public class KoneksiDatabase
    {
        #region DATA MEMBER
        private MySqlConnection koneksi;

        #endregion

        #region CONSTRUCTOR
        public KoneksiDatabase(string server, string database, string uid, string pwd)
        {
            string ConnString = "Server=" + server + ";Database=" + database + ";Uid=" + uid + ";Pwd=" + pwd + ";";
            Koneksi = new MySqlConnection();
            this.Koneksi.ConnectionString = ConnString;
            Hubungkan_Database();
        }
        public KoneksiDatabase()
        {
            string ConnString = "Server= localhost;Database=pameryuk;Uid=root;Pwd=;";
            Koneksi = new MySqlConnection();
            this.Koneksi.ConnectionString = ConnString;
            Hubungkan_Database();
        }

        #endregion

        #region PROPERTIES
        //Properties yang akan diakses oleh luar
        public MySqlConnection Koneksi { get => koneksi; private set => koneksi = value; }
        #endregion

        #region METHOD

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool Status_Database()
        {
            //Mengecek koneksi dengan database terbuka atau tertutup, jika terbuka ditutup terlebih dahulu.
            return Koneksi.State == System.Data.ConnectionState.Open;
        }

        /// <summary>
        /// 
        /// </summary>
        private void Hubungkan_Database()
        {
            //Jika koneksi dengan database terbuka
            if(Status_Database())
            {
                //Tutup koneksi
                Koneksi.Close();
            }
            //Buka koneksi kembali
            Koneksi.Open();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static MySqlDataReader DatabaseQueryCommand(string command)
        {
            MySqlCommand cmd = new MySqlCommand();
            KoneksiDatabase c = new KoneksiDatabase();
            cmd.Connection = c.Koneksi;
            cmd.CommandText = command;
            MySqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public static void DatabaseDMLCommand(string command)
        {
            MySqlCommand cmd = new MySqlCommand();
            KoneksiDatabase c = new KoneksiDatabase(); 
            cmd.Connection = c.Koneksi;
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }

        #endregion
    }
}
