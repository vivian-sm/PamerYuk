using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Komen
    {
        public static List<Komen> Select_Komen(int konten_id)
        {
            string command = "select * from komen where konten_id = '"+konten_id+"';";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            List<Komen> listKomen = new List<Komen>();
            Komen komen;
            while (dr.Read())
            {
                //User
                int id = int.Parse(dr.GetValue(0).ToString());
                string komentar = dr.GetValue(1).ToString();
                DateTime tglUpload = DateTime.Parse(dr.GetValue(2).ToString());
                string username = dr.GetValue(3).ToString();

                komen = new Komen(id, komentar, tglUpload, username);
                listKomen.Add(komen);
            }
            return listKomen;
        }

        public static void Insert_Komen(Komen newKomen, int konten_id)
        {
            string command = "INSERT INTO `pameryuk`.`komen` (`id`, `Komentar`, `tgl`, `username`, `Konten_id`) VALUES ('"+Get_NewComment_Id().ToString()+"', '"+newKomen.Komentar+"', '"+newKomen.Tgl.ToString("yyyy-MM-dd HH:mm:ss")+"', '"+newKomen.User+"', '"+konten_id+"');";
            KoneksiDatabase.DatabaseDMLCommand(command);
        }

        private static int Get_NewComment_Id()
        {
            string command = "select id from komen order by id desc limit 1;";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(command);
            int result=-1;
            if (dr.Read())
            {
                //User
                result = int.Parse(dr.GetValue(0).ToString());
                result++;
            }
            return result;
        }

    }
}
