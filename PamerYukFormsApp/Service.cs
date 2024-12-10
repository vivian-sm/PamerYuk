using PamerYukLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PamerYukLibrary;
using PamerYukLibrary.DAO;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace PamerYukFormsApp
{
    public class Service //On Load
    {
        #region VARIABLES
        private User current_user;
        private List<Kota> listKota;
        private List<Organisasi> listOrganisasi;
        #endregion

        #region CONSTRUCTOR
        public Service()
        {
            this.ListOrganisasi = DAO_Organisasi.Select_Organisasi();
            this.ListKota = DAO_Kota.Select_ListKota(); //Harusnya dari repository (Untuk sementara gini dulu)
        }
        #endregion

        #region PROPERTIES

        public User Current_user { get => current_user; set => current_user = value; }
        public List<Kota> ListKota { get => listKota; set => listKota = value; }
        public List<Organisasi> ListOrganisasi { get => listOrganisasi; set => listOrganisasi = value; }
        #endregion

        #region METHOD (USER) 
        //For User
        public void LogIn(string username, string password)
        {
            this.Current_user = DAO_Users.User_Log_In(username, password);
        }

        public User Daftar(string username, string password, DateTime tglLahir, string noKTP, string foto, Kota kota)
        {
            User new_user = new User(username, password, tglLahir, noKTP, foto, kota);
            DAO_Users.User_Daftar(username, password, tglLahir, noKTP, foto, kota);
            return new_user;
        }

        #endregion
        #region METHOD (KISAH HIDUP)
        //For Kisah Hidup




        #endregion

        #region METHOD (ORGANISASI)


        #endregion

        

    }
}
