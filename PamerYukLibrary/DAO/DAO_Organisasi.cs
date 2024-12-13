using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Organisasi
    {
        public static List<Organisasi> Select_Organisasi()
        {

            string command;
            command = "SELECT * FROM organisasi inner join kota on organisasi.kota_id = kota.id;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<Organisasi> result = new List<Organisasi>();
            while(dr.Read())
            {
                //Organisasi
                int id = int.Parse(dr.GetValue(0).ToString());
                string nama = dr.GetValue(1).ToString();
                int kota_id_fk = int.Parse(dr.GetValue(2).ToString());

                //Kota (join)
                int kota_id = int.Parse(dr.GetValue(3).ToString());
                string kota_nama = dr.GetValue(4).ToString();

                //Create Kota (buffer)
                Kota newKota = new Kota(kota_id,kota_nama);

                //Create Kota (buffer)
                Organisasi newOrganisasi = new Organisasi(id,nama,newKota);

                //Add to list
                result.Add(newOrganisasi);
            }
            return result;
        }

        public static void Insert_Organisasi(Organisasi organisasi)
        {
            string command = "INSERT INTO organisasi (`id`, `nama`, `Kota_id`) VALUES ('"+ new_id_organisasi().ToString() +"', '"+organisasi.Nama+"', '"+organisasi.Kota.Id+"');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        private static int new_id_organisasi()
        {
            string command = "SELECT o.id FROM organisasi o ORDER BY o.id DESC LIMIT 1;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            int result = -1;
            if (dr.Read())
            {
                result = int.Parse(dr.GetValue(0).ToString());
                result++;
            }
            return result;
        }
    }
}
