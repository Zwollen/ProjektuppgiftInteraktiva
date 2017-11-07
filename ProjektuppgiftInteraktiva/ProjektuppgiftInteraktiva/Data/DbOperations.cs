using ProjektuppgiftInteraktiva.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektuppgiftInteraktiva.Data
{
    public class DbOperations
    {
        private TVtoppenEntities db = new TVtoppenEntities();

        public bool CheckUserCredentials(string username, string password)
        {
            var user = db.User.Where(u => u.UserName.Equals(username) && u.Password.Equals(password));

            if (user.Any())            
                return true;            
            else
                return false;
        }
    }
}