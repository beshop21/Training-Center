using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusLayaer
{
    public class clsUsers
    {
        enum EnMode { Addnew=0,Update=1}

        EnMode Mode = EnMode.Addnew;

        int UserID { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        int RoleID { get; set; }





        public clsUsers()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.RoleID = -1;
            Mode = EnMode.Addnew;
        }



        private clsUsers(int id,string username,string password,int roleid)
        {
            this.UserID = id;
            this.UserName = username;
            this.Password = password;
            this.RoleID = roleid;
            Mode = EnMode.Update;

        }


        private bool _Add()
        {
            this.UserID = UsersData.InsertNewUser(this.UserName, this.Password, this.RoleID);
            return (this.UserID != -1);
        }

        private bool _Update()
        {
            return UsersData.UpdateUser(this.UserID, this.UserName, this.Password, this.RoleID);
        }





        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.Addnew:
                    if (_Add())
                    {
                        Mode = EnMode.Update;
                        return true;
                    }
                    else
                        return false;
                case EnMode.Update:
                    return _Update();
            }
            return false;
        }

        public static DataTable Get()
        {
            return UsersData.GetAllUsers();
        }
    }
}
