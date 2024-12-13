using PamerYukLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamerYukLibrary.Repositories
{
    public class Repositories
    {
        private List<Teman> listTeman;

        public Repositories()
        {
        }
        public List<Teman> ListTeman 
        { 
            get => listTeman; 
            set => listTeman = value; 
        }
    }
}
