using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Web.Security;
using System.ServiceModel;

namespace MOICT
{

public class CustomValidator : UserNamePasswordValidator 


     { 

    
         public override void Validate(string userName, string password) 

         {

             //string ProcedureName = "ESB_USERS_PKG.CHECK_USER_PRC";

             //using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString))
             //{
             //    OracleCommand command = new OracleCommand(ProcedureName, connection);
             //    command.CommandType = System.Data.CommandType.StoredProcedure;

             //    OracleParameter USERID = new OracleParameter("P_USER_NAME", userName);
             //    USERID.OracleDbType = OracleDbType.NVarchar2;

             //    OracleParameter PASSWORD = new OracleParameter("P_PASS_WORD", password);
             //    PASSWORD.OracleDbType = OracleDbType.NVarchar2;

             //    OracleParameter RESULT = new OracleParameter("P_USER_CORRECT", OracleDbType.Int32);
             //    RESULT.Direction = System.Data.ParameterDirection.Output;

             //    command.Parameters.Add(USERID);
             //    command.Parameters.Add(PASSWORD);
             //    command.Parameters.Add(RESULT);

             //    connection.Open();

             //    command.ExecuteNonQuery();

             bool IsAuthenticated = false;
             string RESULT = "";
             if (userName == "MoICT" && password == "M0!cT@123")
             {
                 RESULT = "1";
                 if (RESULT != "")
                 {
                     if (RESULT.ToString() == "1")
                         IsAuthenticated = true;
                 }
             }
             if (IsAuthenticated)
             {
                 return;
             }
             else
             {
                 throw new FaultException("Incorrect Username or Password", new FaultCode("Access Denied"));

             }
             return;
                


            


         } 
   


     }


}