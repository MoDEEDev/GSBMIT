using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using MoICT.Entities;
using System.Collections;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Diagnostics;
using System.Data;


namespace MOICT.DataAccess
{

    public partial class CentralRegistrationRepository : MOICT.IDAL.IMITService
    {
        public List<MoICT.Entities.TradeMark> GetRegisteryTradeMarksBy(string reggov, string regrn)
        {
            string aim = string.Empty;
            string select = "idnumber_mark1";
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString))
            {
                OracleCommand command = new OracleCommand(select, connection);
                command.CommandType = CommandType.StoredProcedure;
                OracleParameter paramRegGov = new OracleParameter("reggov", reggov);
                command.Parameters.Add(paramRegGov);

                OracleParameter paramRegRn = new OracleParameter("regrn", regrn);
                command.Parameters.Add(paramRegRn);

                OracleParameter RefCurs = new OracleParameter("idnumber1", OracleDbType.RefCursor);
                RefCurs.Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    List<TradeMark> lstMarks = new List<TradeMark>();
                    TradeMark TM = new TradeMark();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            lstMarks.Add(GetTradeMarksHelper(reader));
                        }
                        return lstMarks;
                    }
                    else return null;
                }
            }
        }

        public List<TradeMark> getTradeMark(String key, int keyCode)
        {
            CentralRegistrationRepository objMITServiceDAL = new CentralRegistrationRepository();

            switch (keyCode)
            {
                case 1:
                    return objMITServiceDAL.GetTradeMarkByKey(string.Format("AND A.TRDMARK_NAMA1 like '%{0}%'", key));
                case 2:
                    return objMITServiceDAL.GetTradeMarkByKey(string.Format("AND A.TRDMARK_NAME1 like '%{0}%'", key));
                case 3:
                    return objMITServiceDAL.GetTradeMarkByKey(string.Format("AND A.TRDMARK_OWNA1 like '%{0}%'", key));
                case 4:
                    return objMITServiceDAL.GetTradeMarkByKey(string.Format("AND A.TRDMARK_OWNE1 like '%{0}%'", key));
                case 5:
                    return objMITServiceDAL.GetTradeMarkByKey(string.Format("AND A.TRDMARK_NO = {0}", key));
                case 6:
                    return objMITServiceDAL.GetTradeMarkByKey(string.Format("AND A.COMPANY_NO = {0}", key));
                default:
                    return null;
            }

        }
    }
}
        
    



