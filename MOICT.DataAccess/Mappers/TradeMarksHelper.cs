

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
        private TradeMark GetTradeMarksHelper(OracleDataReader reader)
        {
            TradeMark TM = new TradeMark();
            if (reader["trdmark_nama1"] != DBNull.Value)
            {
                TM.strTradeMarkArName = (string)reader["trdmark_nama1"];
            }
            if (reader["trdmark_name1"] != DBNull.Value)
            {
                TM.strTradeMarkEnName = (string)reader["trdmark_name1"];
            }
            if (reader["trdmark_no"] != DBNull.Value)
            {
                TM.decTradeMarkNo = (decimal)reader["trdmark_no"];
            }
            if (reader["trdmark_status"] != DBNull.Value)
            {
                TM.trdmark_status = (string)reader["trdmark_status"];
            }
            if (reader["dist"] != DBNull.Value)
            {
                TM.dist = (Int16)reader["dist"];
            }
            return TM;
        }

        private TradeMarksLogo GetTradeMarksLogoHelper(OracleDataReader reader)
        {
            TradeMarksLogo TM = new TradeMarksLogo();
            if (reader["tms_pict"] != DBNull.Value)
            {
                TM.tms_pict = (byte[])reader["tms_pict"];
            }
            return TM;
        }
    }
}







