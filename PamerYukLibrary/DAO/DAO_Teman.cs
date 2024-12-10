using MySql.Data.MySqlClient;
using PamerYukLibrary.Database;
using PamerYukLibrary.Value;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.DAO
{
    public class DAO_Teman
    {
        public static List<Teman> Select_ListTeman(string username)
        {
            string perintah;
            perintah = "SELECT * FROM teman inner join user on teman.username2 = user.username WHERE teman.username1 = '"+username+"' UNION SELECT * FROM teman inner join user on teman.username1 = user.username WHERE teman.username2 = '"+username+"';\r\n";
            MySqlDataReader dr = KoneksiDatabase.DatabaseQueryCommand(perintah);
            List<Teman> listTeman = new List<Teman>();
            while (dr.Read())
            {
                //Teman
                string username1 = dr.GetValue(0).ToString();
                string username2 = dr.GetValue(1).ToString();
                DateTime tglBerteman = DateTime.Parse(dr.GetValue(2).ToString());
                string status = dr.GetValue(3).ToString();

                string friendUSN = username1;
                if(friendUSN == username)
                {
                    friendUSN = username2;
                }

                //Create Teman(buffer)
                Teman newTeman = new Teman(friendUSN,tglBerteman,status);

                //Add to list teman
                listTeman.Add(newTeman);

            }
            return listTeman;
        }
    }
}
