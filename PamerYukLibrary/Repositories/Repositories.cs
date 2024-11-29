using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.Repositories
{
    public class Repositories
    {
        List<User> listUsers;
        List<Organisasi> listOrganisasi;
        List<Kota> listKota;
        List<Teman> listTeman;

        public Repositories()
        {
        }

        public List<User> ListUsers { get => listUsers; set => listUsers = value; }
        public List<Organisasi> ListOrganisasi { get => listOrganisasi; set => listOrganisasi = value; }
        public List<Kota> ListKota { get => listKota; set => listKota = value; }
        public List<Teman> ListTeman { get => listTeman; set => listTeman = value; }
    }
}
