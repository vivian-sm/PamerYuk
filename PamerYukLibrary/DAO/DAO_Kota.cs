using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Kota
    {
        public static List<Kota> Select_ListKota()
        {
            string command = "SELECT * FROM kota;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<Kota> result=new List<Kota>();
            while(dr.Read())
            {
                int id = int.Parse(dr.GetValue(0).ToString());
                string nama = dr.GetValue(1).ToString();
                Kota newKota = new Kota(id,nama);
                result.Add(newKota);
            }
            return result;
        }
    }
}
