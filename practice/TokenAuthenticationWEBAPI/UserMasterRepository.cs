using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAuthenticationWEBAPI
{
    public static class UserMasterRepository
    {
        public static User ValidateUser(string username, string password)
        {
            if (username == "Rajesh")
            {
                return new User() { UserEmailID = "rajeshpww@gmail.com", UserName = "Rajesh", UserPassword = "Maa@567", UserRoles = "Admin1" };
            }
            else
            {
                return new User() ;
            }
            
        }
    }
}