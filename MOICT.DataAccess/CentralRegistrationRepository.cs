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
        List<CentralRegistration> IDAL.IMITService.getRegisteryInfoByIndividualNationalNumber(string NationalNo)
        {
            string select = "Select * from indv_all_info where owner_nationalid=" + NationalNo;
                using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
                {
                    OracleCommand command = new OracleCommand(select, connection);
                   // command.CommandType = CommandType.StoredProcedure;
                 //   OracleParameter ParamNationalNo = new OracleParameter("natno", NationalNo);
                   // command.Parameters.Add(ParamNationalNo);

               //     OracleParameter RefCurs = new OracleParameter("indv_q1a", OracleDbType.RefCursor);
                  //  RefCurs.Direction = System.Data.ParameterDirection.Output;
                   // command.Parameters.Add(RefCurs);

                    connection.Open();

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            List<CentralRegistration> CentralRegistrationList = new List<CentralRegistration>();

                            while (reader.Read())
                            {
                                CentralRegistration c = new CentralRegistration();
                                c = GetCentarlRegistrationHelper(reader);
                                //optimiza - 20-04-2020
                                c.strRegistryOwnerNatNo = NationalNo;
                                //optimiza - 20-04-2020
                                if ( c.p_indv_id > 0)
                                {
                                    c.strRegisteryPurposes = GetRegistryPurposeByIndvID(c.p_indv_id);
                                }
                                else
                                {
                                    c.strRegisteryPurposes = null;
                                }
                               CentralRegistrationList.Add(c);
                            }
                            return CentralRegistrationList;
                        }
                        else
                            return null;
                    }
                }
        }
        List<CapitalHistory> IDAL.IMITService.getcapitalhistory(string natno)
        {
            DataSet ds = new DataSet();
            string select = "SELECT INDV_MODS_NATID.REGMODAFTER, INDV_MODS_NATID.REGMODBEFOR as REGMODBEFORE , INDV_MODS_NATID.REGDMOD FROM INDV_MODS_NATID INNER JOIN INDV_LICEN_BASIC1 ON INDV_MODS_NATID.INDVID = INDV_LICEN_BASIC1.INDV_ID WHERE INDV_MODS_NATID.Legal_modification_code = 4 AND INDV_LICEN_BASIC1.id_number ='" + natno + "'";
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
                // command.CommandType = CommandType.StoredProcedure;

                //     OracleParameter ParamNationalNo = new OracleParameter("idnumber", NationalNo);
                //   command.Parameters.Add(ParamNationalNo);

                // OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
                //RefCurs.Direction = System.Data.ParameterDirection.Output;
                // command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<CapitalHistory> comml = new List<CapitalHistory>();
                        CapitalHistory com = new CapitalHistory();
                        while (reader.Read())
                        {

                            com = GetCapitalHistoryHelper(reader);


                            comml.Add(com);
                        }
                        return comml;

                    }
                    else
                    { return null; }
                }
            }
        }
        List<comminfo> IDAL.IMITService.getcomminfo(string regNo, string regctCode)
        {
            DataSet ds = new DataSet();
            string select = "SELECT regct_code,regno,Ar_regcnown,ar_regcn,Stat_code FROM COMM_NAME_BASIC1 WHERE regno = '" + regNo + "' AND regct_code ='" + regctCode + "'";
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
                // command.CommandType = CommandType.StoredProcedure;

                //     OracleParameter ParamNationalNo = new OracleParameter("idnumber", NationalNo);
                //   command.Parameters.Add(ParamNationalNo);

                // OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
                //RefCurs.Direction = System.Data.ParameterDirection.Output;
                // command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<comminfo> comml = new List<comminfo>();
                        comminfo com = new comminfo();
                        while (reader.Read())
                        {

                            com = GetInfocomminfoHelper(reader);


                            comml.Add(com);
                        }
                        return comml;

                    }
                    else
                    { return null; }
                }
            }
        }
        CentralRegistration IDAL.IMITService.getRegisteryInfoByEstablishmentNationalNumber(string NationalNo)
        {
            DataSet ds = new DataSet();
            string select = "select indv_all_info.*,Indv_delegate_natid.* from indv_all_info left join Indv_delegate_natid on indv_all_info.indv_national_id = Indv_delegate_natid.indv_national_id where  indv_all_info.indv_national_id=" + NationalNo + "";
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
               // command.CommandType = CommandType.StoredProcedure;

           //     OracleParameter ParamNationalNo = new OracleParameter("idnumber", NationalNo);
             //   command.Parameters.Add(ParamNationalNo);

               // OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
                //RefCurs.Direction = System.Data.ParameterDirection.Output;
               // command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                       // List<CentralRegistration> CentralRegistrationList = new List<CentralRegistration>();
                        CentralRegistration objCentralRegistration = new CentralRegistration();
                        while (reader.Read())
                        {
                          
                            objCentralRegistration = GetInfoByEstablishmentNatNoHelper(reader);
                            if (objCentralRegistration.p_indv_id > 0)
                            {
                                objCentralRegistration.strRegisteryPurposes = GetRegistryPurposeByIndvID(NationalNo);
                                objCentralRegistration.lstTradeMarks = GetRegisteryTradeMarksBy(objCentralRegistration.reggov, objCentralRegistration.decRegistryNo);
                            }
                            else
                            {
                                objCentralRegistration.strRegisteryPurposes = null;
                            }
                          //  CentralRegistrationList.Add(c);
                        }
                        return objCentralRegistration;

                    }
                    else
                    { return null; }
                }
            }
        }


        List<ccd_name> IDAL.IMITService.getccd_name(string NationalNo)
        {
            DataSet ds = new DataSet();
            string select = "ccd_name";
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter ParamNationalNo = new OracleParameter("idnumber", NationalNo);
                command.Parameters.Add(ParamNationalNo);

                OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
                RefCurs.Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<ccd_name> ccdName = new List<ccd_name>();
                        ccd_name objCentralRegistration = new ccd_name();
                        while (reader.Read())
                        {

                            objCentralRegistration = GetInfoByccd_nameEstablishmentNatNoHelper(reader);
                            ccdName.Add(objCentralRegistration);
                        }
                        return ccdName;

                    }
                    else
                        return null;
                }
            }
        }

        List<Logo_mark> IDAL.IMITService.getccd_mark(string NationalNo, string typeid)
        {
            DataSet ds = new DataSet();
            string select = "mark";
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString))
            {
                OracleCommand command = new OracleCommand(select, connection);
                command.CommandType = CommandType.StoredProcedure;

                OracleParameter ParamNationalNo = new OracleParameter("idnumber", NationalNo);
                command.Parameters.Add(ParamNationalNo);

                OracleParameter Paratypeid = new OracleParameter("idtype", typeid);
                command.Parameters.Add(Paratypeid);

                OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
                RefCurs.Direction = System.Data.ParameterDirection.Output;
                command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<Logo_mark> objLogoList = new List<Logo_mark>();

                        while (reader.Read())
                        {
                            Logo_mark c = new Logo_mark();
                            c = GetInfoByccd_markEstablishmentNatNoHelper(reader);
                           
                            objLogoList.Add(c);
                        }
                        return objLogoList;
                    }
                    else
                        return null;
                }
            }
        }


        TradeMarksLogo IDAL.IMITService.getTradeMarkLogoBy(string trdmark_n, string dis)
        {
            try
            {
                string select = "idnumber_mark2";
                using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString))
                {
                    OracleCommand command = new OracleCommand(select, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    OracleParameter paramTradeMarkNo = new OracleParameter("trdmk", trdmark_n);
                    command.Parameters.Add(paramTradeMarkNo);
                    paramTradeMarkNo.Direction = ParameterDirection.Input;

                    OracleParameter ParamDist = new OracleParameter("dist_1", dis);
                    command.Parameters.Add(ParamDist);
                    ParamDist.Direction = ParameterDirection.Input;

                    OracleParameter RefCurs = new OracleParameter("idnumber2", OracleDbType.RefCursor);
                    RefCurs.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(RefCurs);

                    connection.Open();
                    TradeMarksLogo trdMarkLogo = new TradeMarksLogo();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            reader.Read();

                            return GetTradeMarksLogoHelper(reader);

                            // return trdMarkLogo;



                        }

                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                string SourceName = "WindowsService.ExceptionLog";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }

                EventLog eventLog = new EventLog();
                eventLog.Source = SourceName;
                string message = string.Format("Exception: {0} \n\nStack: {1}", ex.Message, ex.StackTrace);

                eventLog.WriteEntry(message, EventLogEntryType.Error);
                throw ex;
            }
        } 


        //old web services---------------------------------------------------------------------------------
        public CentralRegistration GetIndividualRegistry(long registryNationalNo)
        {
            CentralRegistration objCentralRegistration = new CentralRegistration();

            OracleConnection objConn = new OracleConnection(MOICT.Helper.Global.ConnectionString2);
            DataSet ds = new DataSet();

            try
            {
                objConn.Open();
                OracleDataAdapter da = new OracleDataAdapter(string.Format("SELECT  a.reg_no as regrn,a.reg_gov_code as reggov,b.desc_a as gov_ardesc,a.reg_date_a as regrd,a.current_capital as regfc,a.ownername as armerchantname,a.owner_nationalid as regnatno,c.desc_a as nat_ardesc,a.Status_code as regstc,d.desc_a as STAT_ARDESC,a.ID as id_number,a.owner_nationalid as regnatno,a.regcn,a.address_desc as regadcn,a.indv_national_id as indv_id," +
                    "(SELECT Max(indv_delegate_natid.Delegate_name) FROM indv_delegate_natid WHERE a.indv_national_id = indv_delegate_natid.indv_national_id )AS regps01, " +
                    "(SELECT Max(indv_delegate_natid.Delegate_authority) FROM indv_delegate_natid WHERE a.indv_national_id = indv_delegate_natid.indv_national_id) AS regps02, " +
                    "(SELECT comm_name_master.cn_reg_no as regncn FROM comm_name_master WHERE a.reg_no = comm_name_master.cn_reg_no AND comm_name_master.cn_reg_type_code = 66 AND a.reg_gov_code = comm_name_master.reg_gov_code AND comm_name_master.reg_date = (SELECT MAX (comm_name_master_inner.reg_date) FROM comm_name_master comm_name_master_inner WHERE comm_name_master_inner.cn_reg_no = comm_name_master.cn_reg_no AND comm_name_master_inner.cn_reg_type_code = 66 AND comm_name_master.reg_gov_code = comm_name_master_inner.reg_gov_code)) AS regncn, " +
                    "(SELECT MAX(comm_name_master_inner.reg_date) FROM comm_name_master comm_name_master_inner WHERE comm_name_master_inner.cn_reg_type_code = 66 AND a.reg_gov_code = comm_name_master_inner.reg_gov_code AND comm_name_master_inner.cn_reg_no = a.reg_no) AS regrdcn " +
                    "FROM indv_all_info a, code_reg_gov b, code_nationality c, code_reg_status d WHERE a.reg_gov_code = b.reg_gov_code AND a.Nationality_code = c.Nationality_code AND a.status_code = d.reg_status_code AND A.indv_national_id = {0}", registryNationalNo), objConn);
             da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    objCentralRegistration.intID_Number = string.IsNullOrEmpty(dr["indv_id"].ToString()) ? (Int64?)null : Int64.Parse(dr["indv_id"].ToString());
                    objCentralRegistration.intIndv_ID = string.IsNullOrEmpty(dr["id_number"].ToString()) ? (Int64?)null : Int64.Parse(dr["id_number"].ToString());
                    objCentralRegistration.decCapitalValue =string.IsNullOrEmpty(dr["REGFC"].ToString())? (Decimal?)null: Decimal.Parse(dr["REGFC"].ToString());
                    objCentralRegistration.strGovernorateName = string.IsNullOrEmpty(dr["GOV_ARDESC"].ToString()) ? "" : dr["GOV_ARDESC"].ToString();
                    objCentralRegistration.strRegistryAddress =string.IsNullOrEmpty(dr["REGADCN"].ToString())?"": dr["REGADCN"].ToString();
                    objCentralRegistration.dtmRegistryDate = string.IsNullOrEmpty(dr["REGRD"].ToString()) ? null :Convert.ToString(dr["REGRD"]);
                    objCentralRegistration.strRegistryName = string.IsNullOrEmpty(dr["REGCN"].ToString()) ? "" : (String)dr["REGCN"].ToString();
                    objCentralRegistration.decRegistryNationalNo = string.IsNullOrEmpty(dr["REGNATNO"].ToString()) ? (Decimal?)null : Decimal.Parse(dr["REGNATNO"].ToString());
                    objCentralRegistration.strRegistryNationality = string.IsNullOrEmpty(dr["NAT_ARDESC"].ToString()) ? "" : dr["NAT_ARDESC"].ToString();
                    objCentralRegistration.decRegistryNo = string.IsNullOrEmpty(dr["REGRN"].ToString())? "" : dr["REGRN"].ToString();
                    objCentralRegistration.strRegistryOwner = string.IsNullOrEmpty(dr["ARMERCHANTNAME"].ToString()) ? "" : dr["ARMERCHANTNAME"].ToString();
                    objCentralRegistration.strRegistryStatus = string.IsNullOrEmpty(dr["STAT_ARDESC"].ToString()) ? "" : (String)dr["STAT_ARDESC"].ToString();
                    objCentralRegistration.intCommercialNameNo = string.IsNullOrEmpty(dr["regncn"].ToString()) ? (Int64?)null : Int64.Parse(dr["regncn"].ToString());
                    objCentralRegistration.dtmCommercialNameDate = string.IsNullOrEmpty(dr["regrdcn"].ToString()) ? (String)null : Convert.ToString(dr["regrdcn"]);
                    objCentralRegistration.strAuthorizedSignatoryForManagement = string.IsNullOrEmpty(dr["regps01"].ToString()) ? (String)dr["ARMERCHANTNAME"] : (String)dr["regps01"].ToString();
                    objCentralRegistration.strAuthorizedSignatoryForFinancial = string.IsNullOrEmpty(dr["regps02"].ToString()) ? (String)dr["ARMERCHANTNAME"] : (String)dr["regps02"].ToString();
                    objCentralRegistration.Regps01 = string.IsNullOrEmpty(dr["Regps01"].ToString()) ? (String)dr["ARMERCHANTNAME"] : (String)dr["Regps01"].ToString();
                    objCentralRegistration.REGAUTZD = string.IsNullOrEmpty(dr["regps02"].ToString()) ? "الإداريــة,المــالية,القضــائية" : (String)dr["regps02"].ToString();
                    objCentralRegistration.HasData = true;
                    List <RegisteryPurposes> Purpose = new List<RegisteryPurposes>();

                    if (objCentralRegistration.intIndv_ID > 0)
                    {
                        objCentralRegistration.strRegisteryPurposes = GetRegistryPurposeByIndvID(registryNationalNo);
                     }
                    else
                    {
                        objCentralRegistration.strRegisteryPurposes = null;
                    }
                  
                         
                }
         
                return objCentralRegistration;
            }
            catch (Exception ex)
            {
                 string SourceName = "WindowsService.ExceptionLog";
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }

                EventLog eventLog = new EventLog();
                eventLog.Source = SourceName;
                string message = string.Format("Exception: {0} \n\nStack: {1}", ex.Message, ex.StackTrace);

                eventLog.WriteEntry(message, EventLogEntryType.Error);
                throw ex;
            }
        }

         InstituteInformation2 IDAL.IMITService.GetInstitiuteInfobyIDNumber(string ID_Number)
        {
            string select = "select indv_all_info.*,Indv_delegate_natid.* from indv_all_info left join Indv_delegate_natid  on Indv_delegate_natid.indv_national_id=indv_all_info.indv_national_id where indv_all_info.indv_national_id=" + ID_Number;
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
    

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        InstituteInformation2 InstituteInformationObject = new InstituteInformation2();

                        while (reader.Read())
                        {
                            InstituteInformationObject = GetInstituteInformationHelper(reader);
                        }
                        return InstituteInformationObject;
                    }
                    else
                        return null;
                }
            }
        }


         List<Intended> IDAL.IMITService.getIntendedBySharedCode(string sharedCode)
                    
        {
            DataSet ds = new DataSet();
            string select = "select * from indv_aims_natid where ID_NUMBER="+sharedCode;
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
            //    command.CommandType = CommandType.StoredProcedure;

               // OracleParameter ParamIndvID = new OracleParameter("indvid", sharedCode);
               // command.Parameters.Add(ParamIndvID);

              //  OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
               // RefCurs.Direction = System.Data.ParameterDirection.Output;
              //  command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<Intended> objIntendedList = new List<Intended>();

                        while (reader.Read())
                        {
                            Intended c = new Intended();
                            c = getIntendedBySharedCodeHelper(reader);

                            objIntendedList.Add(c);
                        }
                        return objIntendedList;
                    }
                    else
                        return null;
                }
            }
        }

         List<Modifications> IDAL.IMITService.getModificationsByRegistrationNoGover(string sharedCode)

        {
            DataSet ds = new DataSet();
            string select = "select * from indv_mods_natid where INDVID=" +sharedCode;
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
                //command.CommandType = CommandType.StoredProcedure;

              //  OracleParameter ParamIndvID = new OracleParameter("indvid", sharedCode);
               // command.Parameters.Add(ParamIndvID);

              //  OracleParameter RefCurs = new OracleParameter("indvid_q1a", OracleDbType.RefCursor);
               // RefCurs.Direction = System.Data.ParameterDirection.Output;
              //  command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<Modifications> objModificationsList = new List<Modifications>();

                        while (reader.Read())
                        {
                            Modifications c = new Modifications();
                            c = getModificationsByRegistrationNoGoverHelper(reader);

                            objModificationsList.Add(c);
                        }
                        return objModificationsList;
                    }
                    else
                        return null;
                }
            }
        }


        /// <summary>
        /// *
        /// </summary>
        /// <param name="ID_Number"></param>
        /// <returns></returns>
         public List<MoICT.Entities.RegisteryPurposes> GetRegistryPurposeByIndvID(string intIndvID)
         {
             string aim = string.Empty;
             string select = "select  indv_aims_natid.* from indv_aims_natid,aims_codes where indv_aims_natid.inv_national_id='" + intIndvID + "'  and aims_codes.aim_code=indv_aims_natid.amis_code";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 
                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                {
                    List<RegisteryPurposes> lstPurposes = new List<RegisteryPurposes>();
                    RegisteryPurposes purpose = new RegisteryPurposes();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            lstPurposes.Add(GetRegisteryPurposesHelper(reader));
                        }
                        return lstPurposes;
                    }
                   else { return null; }
                }
            }
             }
         public List<MoICT.Entities.Modifications> GetRegistryModNatID(string NationalNo)
         {
             string aim = string.Empty;
             string select = "indv_mod_by_nat_id";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 command.CommandType = CommandType.StoredProcedure;

                 OracleParameter ParamNationalNo = new OracleParameter("indvid", NationalNo);
                 command.Parameters.Add(ParamNationalNo);

                 OracleParameter RefCurs = new OracleParameter("indvid_mod", OracleDbType.RefCursor);
                 RefCurs.Direction = System.Data.ParameterDirection.Output;
                 command.Parameters.Add(RefCurs);

                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                 {
                     List<Modifications> lstMod = new List<Modifications>();
                    
                     if (reader.HasRows)
                     {

                         while (reader.Read())
                         {
                             lstMod.Add(getModificationsByRegistrationNoGoverHelper(reader));
                         }
                         return lstMod;
                     }
                     else { return null; }
                 }
             }
         }
         public List<MoICT.Entities.Branches> GetRegistryBranchNatID(string NationalNo)
         {
             string aim = string.Empty;
             string select = "indv_branch_by_nat_id";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 command.CommandType = CommandType.StoredProcedure;

                 OracleParameter ParamNationalNo = new OracleParameter("indvid", NationalNo);
                 command.Parameters.Add(ParamNationalNo);

                 OracleParameter RefCurs = new OracleParameter("branch_nat_id", OracleDbType.RefCursor);
                 RefCurs.Direction = System.Data.ParameterDirection.Output;
                 command.Parameters.Add(RefCurs);

                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                 {
                     List<Branches> lstBranches = new List<Branches>();

                     if (reader.HasRows)
                     {

                         while (reader.Read())
                         {
                             lstBranches.Add(getBranchesByRegistrationNoGoverHelper(reader));
                         }
                         return lstBranches;
                     }
                     else { return null; }
                 }
             }
         }
         public List<MoICT.Entities.Delegates> GetRegistryDelagates(string NationalNo)
         {
            
             string aim = string.Empty;
             string select = "indv_delegate_by_nat_id";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 command.CommandType = CommandType.StoredProcedure;

                 OracleParameter ParamNationalNo = new OracleParameter("id_num", NationalNo);
                 command.Parameters.Add(ParamNationalNo);

                 OracleParameter RefCurs = new OracleParameter("id_num_del", OracleDbType.RefCursor);
                 RefCurs.Direction = System.Data.ParameterDirection.Output;
                 command.Parameters.Add(RefCurs);

                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                 {
                     List<Delegates> lstBranches = new List<Delegates>();

                     if (reader.HasRows)
                     {

                         while (reader.Read())
                         {
                             lstBranches.Add(getDelegatesByRegistrationNoGoverHelper(reader));
                         }
                         return lstBranches;
                     }
                     else { return null; }
                 }
             }
         }
         List<InstituteInformation> IDAL.IMITService.GetInstitiuteInfobyTradeName(string strTradeName)
         {
             string select = "dvld_name2";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 command.CommandType = CommandType.StoredProcedure;
                 OracleParameter ParamIDNumber = new OracleParameter("name2", strTradeName);
                 command.Parameters.Add(ParamIDNumber);

                 OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
                 RefCurs.Direction = System.Data.ParameterDirection.Output;
                 command.Parameters.Add(RefCurs);

                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                 {
                     if (reader.HasRows)
                     {

                         List<InstituteInformation> InstituteInformationObject = new List<InstituteInformation>();

                         while (reader.Read())
                         {
                             InstituteInformation i = new InstituteInformation();
                             i = GetInstituteInformationHelper2(reader);
                             InstituteInformationObject.Add(i);
                         }
                         return InstituteInformationObject;
                     }
                     else
                         return null;
                 }
             }
         }
         CentralRegistrationS IDAL.IMITService.getRegisteryInfoByRegNumber(string RegNo, string gov)
         {
             DataSet ds = new DataSet();
             string select = "regno";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 command.CommandType = CommandType.StoredProcedure;

                 OracleParameter ParamNationalNo = new OracleParameter("regrn", RegNo);
                 command.Parameters.Add(ParamNationalNo);
                 OracleParameter ParamNationalNo2 = new OracleParameter("gov", gov);
                 command.Parameters.Add(ParamNationalNo2);
                 OracleParameter RefCurs = new OracleParameter("idnumber_q1a", OracleDbType.RefCursor);
                 RefCurs.Direction = System.Data.ParameterDirection.Output;
                 command.Parameters.Add(RefCurs);

                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                 {
                     if (reader.HasRows)
                     {
                         
                         List<CentralRegistrationS> objCentralRegistrationL = new List<CentralRegistrationS>();
                         CentralRegistrationS objCentralRegistration= new CentralRegistrationS();
                         while (reader.Read())
                         {

                          objCentralRegistration=GetInfoByEstablishmentNatNoHelperS(reader);

                         }
                         return objCentralRegistration;

                     }
                     else { return null; }

                 }
             }
         }
         CentralRegistrationRS IDAL.IMITService.getRegisteryInfoRS(string NationalNo)
         {
             DataSet ds = new DataSet();
             string select = "RS_INDV_ALL_ANFO";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 command.CommandType = CommandType.StoredProcedure;

                 OracleParameter ParamNationalNo = new OracleParameter("id_num", NationalNo);
                 command.Parameters.Add(ParamNationalNo);

                 OracleParameter RefCurs = new OracleParameter("id_num_q1a", OracleDbType.RefCursor);
                 RefCurs.Direction = System.Data.ParameterDirection.Output;
                 command.Parameters.Add(RefCurs);

                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                 {
                     if (reader.HasRows)
                     {
                         // List<CentralRegistration> CentralRegistrationList = new List<CentralRegistration>();
                         CentralRegistrationRS objCentralRegistration = new CentralRegistrationRS();
                         while (reader.Read())
                         {

                             objCentralRegistration = GetAllInfo(reader);
                             objCentralRegistration.aims = GetRegistryPurposeByIndvID(NationalNo);
                             objCentralRegistration.modifications = GetRegistryModNatID(NationalNo);
                             objCentralRegistration.Branches = GetRegistryBranchNatID(NationalNo);
                             objCentralRegistration.Delegates = GetRegistryDelagates(NationalNo);
                         }
                         return objCentralRegistration;

                     }
                     else
                     { return null; }
                 }
             }
         }
         List<comm_names> IDAL.IMITService.CommNamesRS(string NationalNo)
         {
             DataSet ds = new DataSet();
             string select = "active_comm_names";
             using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
             {
                 OracleCommand command = new OracleCommand(select, connection);
                 command.CommandType = CommandType.StoredProcedure;

                 OracleParameter ParamNationalNo = new OracleParameter("indvid", NationalNo);
                 command.Parameters.Add(ParamNationalNo);

                 OracleParameter RefCurs = new OracleParameter("branch_nat_id", OracleDbType.RefCursor);
                 RefCurs.Direction = System.Data.ParameterDirection.Output;
                 command.Parameters.Add(RefCurs);

                 connection.Open();

                 using (OracleDataReader reader = command.ExecuteReader())
                 {
                     if (reader.HasRows)
                     {
                         List<comm_names> CentralRegistrationList = new List<comm_names>();
                         comm_names objCentralRegistration = new comm_names();
                         while (reader.Read())
                         {

                             CentralRegistrationList.Add(getcomm_names(reader));
                        

                         }
                         return CentralRegistrationList;

                     }
                     else
                     { return null; }
                 }
             }

         }

    }
}
        
    



