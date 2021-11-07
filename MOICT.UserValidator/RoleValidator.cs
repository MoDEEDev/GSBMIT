using System.Web.Security;
using System.Configuration.Provider;
using System.Collections.Specialized;
using System;
using System.Data;
using System.Data.Odbc;
using System.Configuration;
using System.Diagnostics;
using System.Web;
using System.Globalization;
using System.ServiceModel;


namespace MOICT
{
    
    public sealed class RoleValidator : RoleProvider 
    {
        public override bool IsUserInRole(string username, string password)
        {

            bool IsAuthenticated = false;
            string RESULT = "";
            if (username == "MoICT" && password == "M0!cT@123")
            {
                RESULT = "1";
                if (RESULT != "")
                {
                    if (RESULT.ToString() == "1")
                        IsAuthenticated = true;
                    return true;
                }



                if (IsAuthenticated)
                {
                    return true;
                }
                else
                {
                    return false;
                    throw new FaultException("User not in Role", new FaultCode("Access Denied"));

                }
            }
            else
            {
                return false;
            }
        }


        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            string[] UserRoles = { "test1", "test2" };
            return UserRoles;
        }

        public override string[] GetAllRoles()
        {
            string[] UserRoles = { "test1", "test2" };
            return UserRoles;
        }

        public override string[] GetRolesForUser(string username)
        {

            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
    

    
}



