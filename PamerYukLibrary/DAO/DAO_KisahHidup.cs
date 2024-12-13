using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_KisahHidup
    {
        public static List<KisahHidup> Select_ListKisahHidup(string username)
        {
            string command;
            command = "select * from kisahhidup kh	inner join organisasi o ON o.ID = kh.Organisasi_id inner join Kota K on o.Kota_Id = k.id where kh.username ='" + username + "';";

            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<KisahHidup> listData = new List<KisahHidup>();

            while (dr.Read() == true)
            {
                //Taken from database
                //KisahHidup
                int organisasi_ID_fk = int.Parse(dr.GetValue(0).ToString());
                string username_fk = dr.GetValue(1).ToString();
                int thawal = int.Parse(dr.GetValue(2).ToString());
                int thakhir = int.Parse(dr.GetValue(3).ToString());
                string deskripsi = dr.GetValue(4).ToString();

                //Organisasi 
                int id_organisasi = int.Parse(dr.GetValue(5).ToString());
                string nama_organisasi = dr.GetValue(6).ToString();
                int kota_id_fk = int.Parse(dr.GetValue(7).ToString());

                //Kota
                int kota_id = int.Parse(dr.GetValue(8).ToString());
                string nama_Kota = dr.GetValue(9).ToString();

                //Create Kota
                Kota newKota = new Kota(kota_id, nama_Kota);

                //Create Organisasi
                Organisasi newOrganisasi = new Organisasi(id_organisasi, nama_organisasi, newKota);

                //Create Kisah Hidup
                KisahHidup newKisah = new KisahHidup(newOrganisasi, thawal, thakhir, deskripsi);

                //tambahkan ke list
                listData.Add(newKisah);
            }
            //kirim kembali list ke pemanggilnya
            return listData;
        }

        public static void Insert_KisahHidup(KisahHidup newKisah, User current_user)
        {
            string command = "INSERT INTO `pameryuk`.`kisahhidup` (`organisasi_id`, `username`, `thawal`, `thakhir`, `deskripsi`) VALUES ('" + newKisah.Organisasi.Id + "', '" + current_user.Username + "', '" + newKisah.Thawal + "', '" + newKisah.Thakhir + "', '"+newKisah.Deskripsi+"');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }
    }
}
