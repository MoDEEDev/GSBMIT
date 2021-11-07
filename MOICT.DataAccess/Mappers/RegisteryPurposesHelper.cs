

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using MoICT.Entities;
using Oracle.ManagedDataAccess.Client;



namespace MOICT.DataAccess
{
    public partial class CentralRegistrationRepository
    {

        private static RegisteryPurposes GetRegisteryPurposesHelper(OracleDataReader reader)
        {
            RegisteryPurposes purposes = new RegisteryPurposes();
            if (reader["aimsdesc"] != DBNull.Value)
            {
                purposes.aim_desc = Convert.ToString(reader["aimsdesc"]);
            }
            if (reader["amis_code"] != DBNull.Value)
            {
                purposes.aims_code = Convert.ToString(reader["amis_code"]);
            }
            if (reader["STATUS"] != DBNull.Value)
            {
                purposes.status = Convert.ToString(reader["STATUS"]);
            }
            if (reader["isic_flag"] != DBNull.Value)
            {
                purposes.isic_flag = Convert.ToString(reader["isic_flag"]);
            }
            return purposes;
        }
    }
}







