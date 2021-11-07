using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using MoICT.Entities;
using Oracle.ManagedDataAccess.Client;
using MOICT.DataAccess.Mappers;

namespace MOICT.DataAccess
{
    public partial class CentralRegistrationRepository
    {

        private static CentralRegistration GetCentarlRegistrationHelper(OracleDataReader reader)
        {
            CentralRegistration oCentralRegistration = new CentralRegistration();               
                if (reader["comm_name"] != DBNull.Value)
                {
                    oCentralRegistration.strRegistryName = Convert.ToString(reader["comm_name"]);
                }
               
                if (reader["ownername"] != DBNull.Value)
                {
                    oCentralRegistration.strRegistryOwner = Convert.ToString(reader["ownername"]);
                }
                if (reader["reg_no"] != DBNull.Value)
                {
                    oCentralRegistration.decRegistryNo = Convert.ToString(reader["reg_no"]);
                }
                if (reader["reg_date_a"] != DBNull.Value)
                {
                    oCentralRegistration.dtmRegistryDate = Convert.ToString(reader["reg_date_a"]);
                }
                if (reader["current_capital"] != DBNull.Value)
                {
                    oCentralRegistration.decCapitalValue = Convert.ToDecimal(reader["current_capital"]);
                }
                if (reader["governorate"] != DBNull.Value)
                {
                    oCentralRegistration.strGovernorateName = Convert.ToString(reader["governorate"]);
                }
                if (reader["status"] != DBNull.Value)
                {
                    oCentralRegistration.strRegistryStatus = Convert.ToString(reader["status"]);
                }
                if (reader["nat_ardesc"] != DBNull.Value)
                {
                    oCentralRegistration.strRegistryNationality = Convert.ToString(reader["nat_ardesc"]);
                }
                if (reader["indv_national_id"] != DBNull.Value)
                {
                    oCentralRegistration.decRegistryNationalNo = Convert.ToDecimal(reader["indv_national_id"]);
                }
                if (reader["address_name"] != DBNull.Value)
                {
                    oCentralRegistration.strRegistryAddress = Convert.ToString(reader["address_name"]);
                }
                if (reader["id"] != DBNull.Value)
                {
                    oCentralRegistration.p_indv_id = Convert.ToDecimal(reader["id"]);
                }
                return oCentralRegistration;
        }
        public List<MoICT.Entities.RegisteryPurposes> GetRegistryPurposeByIndvID(decimal intIndvID)
        {
            string aim = string.Empty;
            string select = "select indv_aims_natid.* from indv_aims_natid,aims_codes where indv_aims_natid.inv_national_id=" + intIndvID + " and aims_codes.aim_code=indv_aims_natid.amis_code";
            using (OracleConnection connection = new OracleConnection(MOICT.Helper.Global.ConnectionString2))
            {
                OracleCommand command = new OracleCommand(select, connection);
                //command.CommandType = CommandType.StoredProcedure;
                // OracleParameter ParamNationalNo = new OracleParameter("indvid", intIndvID);
                //command.Parameters.Add(ParamNationalNo);

                // OracleParameter RefCurs = new OracleParameter("indv_aims_new", OracleDbType.RefCursor);
                // RefCurs.Direction = System.Data.ParameterDirection.Output;
                // command.Parameters.Add(RefCurs);

                connection.Open();

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    List<RegisteryPurposes> lstPurposes = new List<RegisteryPurposes>();
                    //  RegisteryPurposes purpose = new RegisteryPurposes();
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
        private static ccd_name GetInfoByccd_nameEstablishmentNatNoHelper(OracleDataReader reader)
        {
            ccd_name occd = new ccd_name();
            if (reader["regcn"] != DBNull.Value)
            {
                occd.Regcn = Convert.ToString(reader["regcn"]);
            }
            if (reader["ARMERCHANTNAME"] != DBNull.Value)
            {
                occd.ARMERCHANTNAME = Convert.ToString(reader["ARMERCHANTNAME"]);
            }
            if (reader["ID_NUMBER"] != DBNull.Value)
            {
                occd.ID_NUMBER = Convert.ToString(reader["ID_NUMBER"]);
            }
            if (reader["type"] != DBNull.Value)
            {
                occd.Type = Convert.ToString(reader["type"]);
            }
            if (reader["arname"] != DBNull.Value)
            {
                occd.Arname = Convert.ToString(reader["arname"]);
            }
            return occd;
        }
        private static Logo_mark GetInfoByccd_markEstablishmentNatNoHelper(OracleDataReader reader)
        {
            
            Logo_mark occd = new Logo_mark();
            if (reader["registration_nbr"] != DBNull.Value)
            {
                occd.Registration_nbr = Convert.ToString(reader["registration_nbr"]);
            }
            if (reader["mark_name"] != DBNull.Value)
            {
                occd.Mark_name = Convert.ToString(reader["mark_name"]);
            }
       
            if (reader["mark_name_lang2"] != DBNull.Value)
            {
                occd.Mark_name_lang2 = Convert.ToString(reader["mark_name_lang2"]);
            }
            if (reader["registration_date"] != DBNull.Value)
            {
                occd.Registration_date = Convert.ToDateTime(reader["registration_date"]);
            }
            if (reader["expiration_date"] != DBNull.Value)
            {
                occd.Expiration_dater = Convert.ToDateTime(reader["expiration_date"]);
            }
            if (reader["company_name"] != DBNull.Value)
            {
                occd.Company_name = Convert.ToString(reader["company_name"]);
            }
            if (reader["gral_person_id_typ"] != DBNull.Value)
            {
                occd.Gral_person_id_typ = Convert.ToString(reader["gral_person_id_typ"]);
            }
            if (reader["gral_person_id_nbr"] != DBNull.Value)
            {
                occd.Gral_person_id_nbr = Convert.ToString(reader["gral_person_id_nbr"]);
            }
            if (reader["logo_data"] != DBNull.Value)
            {
                occd.Logo_data = (byte[])reader["logo_data"];
            }
            if (reader["file_nbr"] != DBNull.Value)
            {
                occd.File_nbr = Convert.ToString(reader["file_nbr"]);
            }
            return occd;
        }
        private static CapitalHistory GetCapitalHistoryHelper(OracleDataReader reader)
        {
            CapitalHistory c = new CapitalHistory();
            if (reader["REGDMOD"] != DBNull.Value)
            {
                c.REGDMOD = Convert.ToString(reader["REGDMOD"]);
            }
            if (reader["REGMODAFTER"] != DBNull.Value)
            {
                c.REGMODAFTER = Convert.ToString(reader["REGMODAFTER"]);
            }
            if (reader["REGMODBEFORE"] != DBNull.Value)
            {
                c.REGMODBEFORE = Convert.ToString(reader["REGMODBEFORE"]);
            }
            return c;
        }
        private static CentralRegistration GetInfoByEstablishmentNatNoHelper(OracleDataReader reader)
        {

            CentralRegistration oCentralRegistration = new CentralRegistration();
            if (reader["comm_name"] != DBNull.Value)
            {
                oCentralRegistration.strRegistryName = Convert.ToString(reader["comm_name"]);
            }
            if (reader["ownername"] != DBNull.Value)
            {
                oCentralRegistration.strRegistryOwner = Convert.ToString(reader["ownername"]);
            }
            if (reader["reg_no"] != DBNull.Value)
            {
                oCentralRegistration.decRegistryNo = Convert.ToString(reader["reg_no"]);
            }
            if (reader["reg_date_a"] != DBNull.Value)
            {
                oCentralRegistration.dtmRegistryDate = Convert.ToString(reader["reg_date_a"]);
            }
            if (reader["reg_date_e"] != DBNull.Value)
            {
                oCentralRegistration.dtmRegistryDate2 = Convert.ToString(reader["reg_date_e"]);
            }
            if (reader["current_capital"] != DBNull.Value)
            {
                oCentralRegistration.decCapitalValue = Convert.ToDecimal(reader["current_capital"]);
            }
            if (reader["reg_capital"] != DBNull.Value)
            {
                oCentralRegistration.decCapitalValue2 = Convert.ToDecimal(reader["reg_capital"]);
            }
            if (reader["governorate"] != DBNull.Value)
            {
                oCentralRegistration.strGovernorateName = Convert.ToString(reader["governorate"]);
            }
            if (reader["status"] != DBNull.Value)
            {
                oCentralRegistration.strRegistryStatus = Convert.ToString(reader["status"]);
            }
            if (reader["nat_ardesc"] != DBNull.Value)
            {
                oCentralRegistration.strRegistryNationality = Convert.ToString(reader["nat_ardesc"]);
            }
            if (reader["indv_national_id"] != DBNull.Value)
            {
                oCentralRegistration.decRegistryNationalNo = Convert.ToDecimal(reader["indv_national_id"]);
            }
            if (reader["address_desc"] != DBNull.Value)
            {
                oCentralRegistration.strRegistryAddress = Convert.ToString(reader["address_desc"]);
            }
            if (reader["id"] != DBNull.Value)
            {
                oCentralRegistration.p_indv_id = Convert.ToDecimal(reader["id"]);
            }
            if (reader["cn_reg_no"] != DBNull.Value)
            {
                oCentralRegistration.regcn_no = Convert.ToString(reader["cn_reg_no"]);
            }
            if (reader["reg_gov_code"] != DBNull.Value)
            {
                oCentralRegistration.reggov = Convert.ToString(reader["reg_gov_code"]);
            }
            if (reader["DELEGATE_NAME"] != DBNull.Value)
            {
                oCentralRegistration.Regps01 = Convert.ToString(reader["DELEGATE_NAME"]);
            }
            else
            {
                oCentralRegistration.Regps01 = Convert.ToString(reader["ownername"]);
            }
            if (reader["DELEGATE_AUTHORITY"] != DBNull.Value)
            {
                oCentralRegistration.REGAUTZD = Convert.ToString(reader["DELEGATE_AUTHORITY"]);
            }
            else
            {
                oCentralRegistration.REGAUTZD = "الإداريــة,المــالية,القضــائية";
            }
            return oCentralRegistration;
        }
        public static CentralRegistrationS GetInfoByEstablishmentNatNoHelperS(OracleDataReader reader)
        {


            CentralRegistrationS oCentralRegistration2 = new CentralRegistrationS();

            if (reader["ARMERCHANTNAME"] != DBNull.Value)
            {
                oCentralRegistration2.ARMERCHANTNAME = Convert.ToString(reader["ARMERCHANTNAME"]);
            }
            if (reader["regrn"] != DBNull.Value)
            {
                oCentralRegistration2.rgrn = Convert.ToString(reader["regrn"]);
            }
            if (reader["regrd"] != DBNull.Value)
            {
                oCentralRegistration2.rgrd = Convert.ToString(reader["regrd"]);
            }
            if (reader["regcn_no"] != DBNull.Value)
            {
                oCentralRegistration2.regcn_no = Convert.ToString(reader["regcn_no"]);
            }
            if (reader["capital1"] != DBNull.Value)
            {
                oCentralRegistration2.decCapitalValue2 = Convert.ToDecimal(reader["capital1"]);
            }
            if (reader["gov_desc"] != DBNull.Value)
            {
                oCentralRegistration2.gov_desc = Convert.ToString(reader["gov_desc"]);
            }
            if (reader["status_desc"] != DBNull.Value)
            {
                oCentralRegistration2.status_desc = Convert.ToString(reader["status_desc"]);
            }
            if (reader["nat_desc"] != DBNull.Value)
            {
                oCentralRegistration2.nat_desc = Convert.ToString(reader["nat_desc"]);
            }
            if (reader["ID_NUMBER"] != DBNull.Value)
            {
                oCentralRegistration2.IDNumber = Convert.ToString(reader["ID_NUMBER"]);
            }

            if (reader["address_desc"] != DBNull.Value)
            {
                oCentralRegistration2.address_desc = Convert.ToString(reader["address_desc"]);
            }
            if (reader["p_indv_id"] != DBNull.Value)
            {
                oCentralRegistration2.p_indv_id = Convert.ToString(reader["p_indv_id"]);
            }
            if (reader["regcn"] != DBNull.Value)
            {
                oCentralRegistration2.regcn = Convert.ToString(reader["regcn"]);
            }


            return oCentralRegistration2;
        }
        public List<TradeMark> GetTradeMarkByKey(string key)
        {
            TradeMark objTradeMark;
            List<TradeMark> lstTradeMark = new List<TradeMark>();

            //OracleConnection myOracleConnection = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MIT"].ConnectionString);
            OracleConnection myOracleConnection = new OracleConnection(MOICT.Helper.Global.ConnectionString);
            DataSet ds = new DataSet();

            try
            {
                myOracleConnection.Open();
                OracleDataAdapter da = new OracleDataAdapter(string.Format("SELECT A.TRDMARK_NO, A.DIST, A.TRDMARK_NAMA1, A.TRDMARK_NAME1, A.TRDMARK_OWNA1, A.TRDMARK_OWNE1, A.TRDMARK_OWNER_ADDRESSA1, A.TRDMARK_OWNER_ADDRESSE1, A.CLASS_NO, B.CLASS_A1, B.CLASS_E1, A.COUNTRY_CODE, C.CODE_DESA COUNTRY_DESA, C.CODE_DESE COUNTRY_DESE, A.APPLICATION_DATE, A.COMPANY_TYPE, A.COMPANY_NO, A.TMSGOV, A.TRDMARK_STATUS, A.TRDMARK_OWNER_CITY_DESA, A.TRDMARK_OWNER_CITY_DESE, A.TRDMARK_OWNER_COUNTRY, A.TRDMARK_OWNER_PO_BOX, A.TRDMARK_OWNER_TEL, A.TRDMARK_OWNER_POSTCODE, A.AGENCY_NO, D.CODE_DESA STATUS_DESA, D.CODE_DESE STATUS_DESE, E.CODE_DESA COMPANY_DESA, E.CODE_DESE COMPANY_DESE, F.AGENCY_NAMA1, F.AGENCY_NAME1 FROM TRADEMARKS_MASTER_FILE A, TRADEMARKS_CLASSES_CODES B,TRADEMARKS_NATIONALITIES_CODES C, TRADEMARKS_STATUS_CODES D, TRADEMARKS_TYPES_CODES E, TRADEMARKS_AGENCIES_CODES F WHERE A.CLASS_NO = B.CLASS_CODE AND A.COUNTRY_CODE = C.SUBSECTOR AND A.TRDMARK_STATUS = D.SUBSECTOR AND A.COMPANY_TYPE = E.SUBSECTOR AND A.AGENCY_NO = F.AGENCY_NO (+) {0}", key), myOracleConnection);
                da.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objTradeMark = new TradeMark();
                    objTradeMark.strTradeMarkOwnerCityAr = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNER_CITY_DESA"));
                    objTradeMark.strTradeMarkOwnerCityEn = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNER_CITY_DESE"));
                    objTradeMark.strTradeMarkOwnerCountry = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNER_COUNTRY"));
                    objTradeMark.decTradeMarkOwnerPOBox = (Nullable<Decimal>)Util.GetValue<Decimal>(dr, "TRDMARK_OWNER_PO_BOX");
                    objTradeMark.decTradeMarkOwnerPostCode = (Nullable<Decimal>)Util.GetValue<Decimal>(dr, "TRDMARK_OWNER_POSTCODE");
                    objTradeMark.strTradeMarkOwnerTel = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNER_TEL"));
                    objTradeMark.intAgencyNo = (Nullable<int>)Util.GetValue<int>(dr, "AGENCY_NO");
                    objTradeMark.strAgencyNameAr = Convert.ToString(Util.GetValue(dr, "AGENCY_NAMA1"));
                    objTradeMark.strAgencyNameEn = Convert.ToString(Util.GetValue(dr, "AGENCY_NAME1"));
                    objTradeMark.dtmApplicationDate = Convert.ToString(Util.GetValue<DateTime>(dr, "APPLICATION_DATE"));
                    objTradeMark.intClassNo = (Nullable<int>)Util.GetValue<int>(dr, "CLASS_NO");
                    objTradeMark.strClassNoAr = Convert.ToString(Util.GetValue(dr, "CLASS_A1"));
                    objTradeMark.strClassNoEn = Convert.ToString(Util.GetValue(dr, "CLASS_E1"));
                    objTradeMark.strCompanyType = Convert.ToString(Util.GetValue(dr, "COMPANY_TYPE"));
                    objTradeMark.strCompanyTypeDescAr = Convert.ToString(Util.GetValue(dr, "COMPANY_DESA"));
                    objTradeMark.strCompanyTypeDescEn = Convert.ToString(Util.GetValue(dr, "COMPANY_DESE"));
                    objTradeMark.strCountryCode = Convert.ToString(Util.GetValue(dr, "COUNTRY_CODE"));
                    objTradeMark.strCountryCodeDescAr = Convert.ToString(Util.GetValue(dr, "COUNTRY_DESA"));
                    objTradeMark.strCountryCodeDescEn = Convert.ToString(Util.GetValue(dr, "COUNTRY_DESE"));
                    objTradeMark.intDist = (Nullable<int>)Util.GetValue<int>(dr, "DIST");
                    objTradeMark.strTradeMarkArName = Convert.ToString(Util.GetValue(dr, "TRDMARK_NAMA1"));
                    objTradeMark.strTradeMarkEnName = Convert.ToString(Util.GetValue(dr, "TRDMARK_NAME1"));
                    objTradeMark.decTradeMarkNo = Convert.ToDecimal(Util.GetValue(dr, "TRDMARK_NO"));
                    objTradeMark.strTradeMarkOwnerAr = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNA1"));
                    objTradeMark.strTradeMarkOwnerEn = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNE1"));
                    objTradeMark.strTradeMarkStatus = Convert.ToString(Util.GetValue(dr, "TRDMARK_STATUS"));
                    objTradeMark.strTradeMarkStatusDescAr = Convert.ToString(Util.GetValue(dr, "STATUS_DESA"));
                    objTradeMark.strTradeMarkStatusDescEn = Convert.ToString(Util.GetValue(dr, "STATUS_DESE"));
                    objTradeMark.strTradeMarkOwnerAddressAr = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNER_ADDRESSA1"));
                    objTradeMark.strTradeMarkOwnerAddressEn = Convert.ToString(Util.GetValue(dr, "TRDMARK_OWNER_ADDRESSE1"));
                    objTradeMark.decCompanyNO = (Nullable<Decimal>)Util.GetValue<Decimal>(dr, "COMPANY_NO");
                    objTradeMark.decTMSGOV = (Nullable<Decimal>)Util.GetValue<Decimal>(dr, "TMSGOV");

                    lstTradeMark.Add(objTradeMark);
                }
            }
            catch (Exception ex)
            {
                lstTradeMark = null;
                Logger.logError(ex);
            }
            finally
            {
                myOracleConnection.Close();
                myOracleConnection.Dispose();
            }
            return lstTradeMark;
        }
        public comminfo GetInfocomminfoHelper(OracleDataReader reader){
            comminfo c =new comminfo();
            if (reader["regno"] != DBNull.Value)
            {
                c.regno = Convert.ToString(reader["regno"]);
            }
            if (reader["Ar_regcnown"] != DBNull.Value)
            {
                c.Ar_regcnown = Convert.ToString(reader["Ar_regcnown"]);
            }
            if (reader["regct_code"] != DBNull.Value)
            {
                c.regct_code = Convert.ToString(reader["regct_code"]);
            }
            if (reader["ar_regcn"] != DBNull.Value)
            {
                c.ar_regcn = Convert.ToString(reader["ar_regcn"]);
            }
            if (reader["Stat_code"] != DBNull.Value)
            {
                c.Stat_code = Convert.ToString(reader["Stat_code"]);
            }
            return c;
        }
    
      private static InstituteInformation GetInstituteInformationHelper2(OracleDataReader reader){
                 InstituteInformation InstituteInformationObject = new InstituteInformation();
            if (reader["regcn"] != DBNull.Value)
            {
                InstituteInformationObject.strRegistrationName = (string)reader["regcn"];
            }
            if (reader["ARMERCHANTNAME"] != DBNull.Value)
            {
                InstituteInformationObject.strOwnerName = (string)reader["ARMERCHANTNAME"];
            }
            if (reader["regrn"] != DBNull.Value)
            {
                InstituteInformationObject.decRegNo = (decimal)reader["regrn"];
            }
            if (reader["regrd"] != DBNull.Value)
            {
                InstituteInformationObject.dtmRegistryDate = (DateTime)reader["regrd"];
            }
            if (reader["capital1"] != DBNull.Value)
            {
                InstituteInformationObject.decCapitalValue = (decimal)reader["capital1"];
            }
            if (reader["capital"] != DBNull.Value)
            {
                InstituteInformationObject.decCurrentCapitalValue = (decimal)reader["capital"];
            }
            if (reader["gov_desc"] != DBNull.Value)
            {
                InstituteInformationObject.strGovernorateName = (string)reader["gov_desc"];
            }
            if (reader["status_desc"] != DBNull.Value)
            {
                InstituteInformationObject.strInstituteStatus = (string)reader["status_desc"];
            }
            if (reader["nat_co"] != DBNull.Value)
            {
                InstituteInformationObject.decNationalityCode = (decimal)reader["nat_co"];
            }
            if (reader["nat_desc"] != DBNull.Value)
            {
                InstituteInformationObject.strNationalityDescription = (string)reader["nat_desc"];
            }
            if (reader["ID_NUMBER"] != DBNull.Value)
            {
                InstituteInformationObject.decRegistryNationalNo = (decimal)reader["ID_NUMBER"];
            }
            if (reader["indv_id"] != DBNull.Value)
            {
                InstituteInformationObject.decIndivID = (decimal)reader["indv_id"];
            }
            if (reader["regcn_no"] != DBNull.Value)
            {
                InstituteInformationObject.decRegistrationNo = (decimal)reader["regcn_no"];
            }
            if (reader["stat_code"] != DBNull.Value)
            {
                InstituteInformationObject.strInstituteStatusCode = (decimal)reader["stat_code"];
            }
            if (reader["Reggov"] != DBNull.Value)
            {
                InstituteInformationObject.decGoverCode = (decimal)reader["Reggov"];
            }
            if (reader["regnatno"] != DBNull.Value)
            {
                InstituteInformationObject.decOwnerNationalNo = (decimal)reader["regnatno"];
            }
            if (reader["regps01"] != DBNull.Value)
            {
                InstituteInformationObject.strAuthorized1 = (string)reader["regps01"];
            }
            if (reader["REGAUTZD"] != DBNull.Value)
            {
                InstituteInformationObject.strAuthorized2 = (string)reader["REGAUTZD"];
            }
            return InstituteInformationObject;
            }
            private static InstituteInformation2 GetInstituteInformationHelper(OracleDataReader reader)
        {
            InstituteInformation2 InstituteInformationObject = new InstituteInformation2();
            if (reader["COMM_NAME"] != DBNull.Value)
            {
                InstituteInformationObject.strRegistrationName = Convert.ToString(reader["COMM_NAME"]);
            }
            if (reader["reg_dist"] != DBNull.Value)
            {
                InstituteInformationObject.regdist = Convert.ToString(reader["reg_dist"]);
            }
            if (reader["ownername"] != DBNull.Value)
            {
                InstituteInformationObject.strOwnerName = Convert.ToString(reader["ownername"]);
            }
            if (reader["reg_no"] != DBNull.Value)
            {
                InstituteInformationObject.decRegNo = Convert.ToString(reader["reg_no"]);
            }
            if (reader["reg_date_a"] != DBNull.Value)
            {
                InstituteInformationObject.dtmRegistryDate = Convert.ToString(reader["reg_date_a"]);
            }
            if (reader["reg_capital"] != DBNull.Value)
            {
                InstituteInformationObject.decCapitalValue = Convert.ToDecimal(reader["reg_capital"]);
            }
            if (reader["current_capital"] != DBNull.Value)
            {
                InstituteInformationObject.decCurrentCapitalValue = Convert.ToDecimal(reader["current_capital"]);
            }
            if (reader["governorate"] != DBNull.Value)
            {
                InstituteInformationObject.strGovernorateName = Convert.ToString(reader["governorate"]);
            }
            if (reader["status"] != DBNull.Value)
            {
                InstituteInformationObject.strInstituteStatus = Convert.ToString(reader["status"]);
            }
            if (reader["Nationality_code"] != DBNull.Value)
            {
                InstituteInformationObject.decNationalityCode = Convert.ToDecimal(reader["Nationality_code"]);
            }
            if (reader["nat_ardesc"] != DBNull.Value)
            {
                InstituteInformationObject.strNationalityDescription = Convert.ToString(reader["nat_ardesc"]);
            }
            if (reader["indv_national_id"] != DBNull.Value)
            {
                InstituteInformationObject.decRegistryNationalNo = Convert.ToDecimal(reader["indv_national_id"]);
            }
            if (reader["id"] != DBNull.Value)
            {
                InstituteInformationObject.decIndivID = Convert.ToDecimal(reader["id"]);
            }
            if (reader["cn_reg_no"] != DBNull.Value)
            {
                InstituteInformationObject.decRegistrationNo = Convert.ToString(reader["cn_reg_no"]);
            }
            if (reader["status_code"] != DBNull.Value)
            {
                InstituteInformationObject.strInstituteStatusCode = Convert.ToString(reader["status_code"]);
            }
            if (reader["reg_gov_code"] != DBNull.Value)
            {
                InstituteInformationObject.decGoverCode = Convert.ToDecimal(reader["reg_gov_code"]);
            }
            if (reader["owner_nationalid"] != DBNull.Value)
            {
                InstituteInformationObject.decOwnerNationalNo = Convert.ToDecimal(reader["owner_nationalid"]);
            }
            if (reader["delegate_name"] != DBNull.Value)
            {
                InstituteInformationObject.strAuthorized1 = Convert.ToString(reader["delegate_name"]);
            }
            if (reader["delegate_authority"] != DBNull.Value)
            {
                InstituteInformationObject.strAuthorized2 = Convert.ToString(reader["delegate_authority"]);
            }
            return InstituteInformationObject;
        }

        private static Intended getIntendedBySharedCodeHelper(OracleDataReader reader)
        {

            Intended intendedObject = new Intended();
            if (reader["ID_NUMBER"] != DBNull.Value)
            {
                intendedObject.sharedCode = Convert.ToDecimal(reader["ID_NUMBER"]);
            }            
            if (reader["amis_code"] != DBNull.Value)
            {
                intendedObject.intendedCode = Convert.ToDecimal(reader["amis_code"]);
            }
            if (reader["aimsdesc"] != DBNull.Value)
            {
                intendedObject.intendedDescription = Convert.ToString(reader["aimsdesc"]);
            }
            return intendedObject;
        }

        private static Modifications getModificationsByRegistrationNoGoverHelper(OracleDataReader reader)
        {

            Modifications modificationsObject = new Modifications();
            if (reader["indvid"] != DBNull.Value)
            {
                modificationsObject.sharedCode = Convert.ToDecimal(reader["indvid"]);
            }
            if (reader["regrn"] != DBNull.Value)
            {
                modificationsObject.decInstituteRegistrationNo =  Convert.ToString(reader["regrn"]);
            }
            if (reader["reggov"] != DBNull.Value)
            {
                modificationsObject.decGoverCode = Convert.ToDecimal(reader["reggov"]);
            }

            if (reader["legal_modification_code"] != DBNull.Value)
            {
                modificationsObject.modCode = Convert.ToInt32(reader["legal_modification_code"]);
            }
            if (reader["aimsdesc"] != DBNull.Value)
            {
                modificationsObject.ModificationDescription = Convert.ToString(reader["aimsdesc"]);
            }
            if (reader["regmodbefor"] != DBNull.Value)
            {
                modificationsObject.beforeModification = Convert.ToString(reader["regmodbefor"]);
            }
            if (reader["regmodafter"] != DBNull.Value)
            {
                modificationsObject.afterModification = Convert.ToString(reader["regmodafter"]);
            }
            if (reader["regdmod"] != DBNull.Value)
            {
                modificationsObject.ModificationDate = Convert.ToDateTime(reader["regdmod"]);
            }
            return modificationsObject;
        }
        private static CentralRegistrationRS GetAllInfo(OracleDataReader reader)
        {

            CentralRegistrationRS oCentralRegistration = new CentralRegistrationRS();
            if (reader["reg_no"] != DBNull.Value)
            {
                oCentralRegistration.reg_no = Convert.ToString(reader["reg_no"]);
            }
            if (reader["address_name"] != DBNull.Value)
            {
                oCentralRegistration.address_name = Convert.ToString(reader["address_name"]);
            }
            if (reader["APARTMENT"] != DBNull.Value)
            {
                oCentralRegistration.APARTMENT = Convert.ToString(reader["APARTMENT"]);
            }
            if (reader["reg_gov_code"] != DBNull.Value)
            {
                oCentralRegistration.reg_gov_code = Convert.ToString(reader["reg_gov_code"]);
            }
            if (reader["AREA"] != DBNull.Value)
            {
                oCentralRegistration.AREA = Convert.ToString(reader["AREA"]);
            }
            if (reader["BUILDING"] != DBNull.Value)
            {
                oCentralRegistration.BUILDING = Convert.ToString(reader["BUILDING"]);
            }
            if (reader["nat_ardesc"] != DBNull.Value)
            {
                oCentralRegistration.nat_ardesc = Convert.ToString(reader["nat_ardesc"]);
            }
            if (reader["CELLPHONE"] != DBNull.Value)
            {
                oCentralRegistration.CELLPHONE = Convert.ToString(reader["CELLPHONE"]);
            }
            if (reader["cn_reg_no"] != DBNull.Value)
            {
                oCentralRegistration.cn_reg_no = Convert.ToString(reader["cn_reg_no"]);
            }
            if (reader["cn_status"] != DBNull.Value)
            {
                oCentralRegistration.cn_status = Convert.ToString(reader["cn_status"]);
            }
            if (reader["comm_name"] != DBNull.Value)
            {
                oCentralRegistration.comm_name = Convert.ToString(reader["comm_name"]);
            }
            if (reader["comm_reg_date"] != DBNull.Value)
            {
                oCentralRegistration.comm_reg_date = Convert.ToString(reader["comm_reg_date"]);
            }
            if (reader["current_capital"] != DBNull.Value)
            {
                oCentralRegistration.current_capital = Convert.ToString(reader["current_capital"]);
            }
            if (reader["governorate"] != DBNull.Value)
            {
                oCentralRegistration.governorate = Convert.ToString(reader["governorate"]);
            }
            if (reader["indv_reg_date"] != DBNull.Value)
            {
                oCentralRegistration.indv_reg_date = Convert.ToString(reader["indv_reg_date"]);
            }
            if (reader["nat_ardesc"] != DBNull.Value)
            {
                oCentralRegistration.nat_ardesc = Convert.ToString(reader["nat_ardesc"]);
            }
            if (reader["owner_nationalid"] != DBNull.Value)
            {
                oCentralRegistration.owner_nationalid = Convert.ToString(reader["owner_nationalid"]);
            }
            if (reader["ownername"] != DBNull.Value)
            {
                oCentralRegistration.Ownername = Convert.ToString(reader["ownername"]);
            }
            if (reader["current_capital"] != DBNull.Value)
            {
                oCentralRegistration.current_capital = Convert.ToString(reader["current_capital"]);
            }
            if (reader["cn_status"] != DBNull.Value)
            {
                oCentralRegistration.cn_status = Convert.ToString(reader["cn_status"]);
            }
            if (reader["reg_capital"] != DBNull.Value)
            {
                oCentralRegistration.reg_capital = Convert.ToString(reader["reg_capital"]);
            }
            if (reader["indv_national_id"] != DBNull.Value)
            {
                oCentralRegistration.REG_NAT_ID = Convert.ToString(reader["indv_national_id"]);
            }
            if (reader["CELLPHONE"] != DBNull.Value)
            {
                oCentralRegistration.CELLPHONE = Convert.ToString(reader["CELLPHONE"]);
            }
            if (reader["REGBOX"] != DBNull.Value)
            {
                oCentralRegistration.REGBOX = Convert.ToString(reader["REGBOX"]);
            }
            if (reader["COUNTRY"] != DBNull.Value)
            {
                oCentralRegistration.COUNTRY = Convert.ToString(reader["COUNTRY"]);
            }
            if (reader["REGCTY"] != DBNull.Value)
            {
                oCentralRegistration.REGCTY = Convert.ToString(reader["REGCTY"]);
            }
            if (reader["status_code"] != DBNull.Value)
            {
                oCentralRegistration.status_code = Convert.ToString(reader["status_code"]);
            }
            if (reader["nationality_code"] != DBNull.Value)
            {
                oCentralRegistration.nationality_code = Convert.ToString(reader["nationality_code"]);
            }
           
            if (reader["REGFAX"] != DBNull.Value)
            {
                oCentralRegistration.REGFAX = Convert.ToString(reader["REGFAX"]);
            }
            if (reader["REGEMAIL"] != DBNull.Value)
            {
                oCentralRegistration.REGMAIL = Convert.ToString(reader["REGEMAIL"]);
            }
            if (reader["REGTEL"] != DBNull.Value)
            {
                oCentralRegistration.REGTEL = Convert.ToString(reader["REGTEL"]);
            }

            if (reader["REGSTREET"] != DBNull.Value)
            {
                oCentralRegistration.REGSTREEET = Convert.ToString(reader["REGSTREET"]);
            }
            if (reader["REGZIP"] != DBNull.Value)
            {
                oCentralRegistration.REGZIP = Convert.ToString(reader["REGZIP"]);
            }
            if (reader["status"] != DBNull.Value)
            {
                oCentralRegistration.Status = Convert.ToString(reader["status"]);
            }
       
            return oCentralRegistration;
        }
        private static comm_names getcomm_names(OracleDataReader reader)
        {

            comm_names oCentralRegistration = new comm_names();
            if (reader["comm_name"] != DBNull.Value)
            {
                oCentralRegistration.comm_name = Convert.ToString(reader["comm_name"]);
            }
            if (reader["REG_NAT_ID"] != DBNull.Value)
            {
                oCentralRegistration.REG_NAT_ID = Convert.ToString(reader["REG_NAT_ID"]);
            }
         
            return oCentralRegistration;
        }
        private static Branches getBranchesByRegistrationNoGoverHelper(OracleDataReader reader)
        {

            Branches Branches = new Branches();
            if (reader["indv_national_id"] != DBNull.Value)
            {
                Branches.indv_national_id = Convert.ToString(reader["indv_national_id"]);
            }
            if (reader["area"] != DBNull.Value)
            {
                Branches.area = Convert.ToString(reader["area"]);
            }
            if (reader["branch_reg_gov_code"] != DBNull.Value)
            {
                Branches.branch_reg_gov_code = Convert.ToString(reader["branch_reg_gov_code"]);
            }

            if (reader["city_code"] != DBNull.Value)
            {
                Branches.city_code = Convert.ToString(reader["city_code"]);
            }
            if (reader["country_code"] != DBNull.Value)
            {
                Branches.country_code = Convert.ToString(reader["country_code"]);
            }
            if (reader["desc_aa"] != DBNull.Value)
            {
                Branches.desc_aa = Convert.ToString(reader["desc_aa"]);
            }
            if (reader["desc_ee"] != DBNull.Value)
            {
                Branches.desc_ee = Convert.ToString(reader["desc_ee"]);
            }
            if (reader["email"] != DBNull.Value)
            {
                Branches.email = Convert.ToString(reader["email"]);
            }
            if (reader["fax_no"] != DBNull.Value)
            {
                Branches.fax_no = Convert.ToString(reader["fax_no"]);
            }
            if (reader["mobile_no"] != DBNull.Value)
            {
                Branches.Mobile_no = Convert.ToString(reader["mobile_no"]);
            }
            if (reader["po_box"] != DBNull.Value)
            {
                Branches.po_box = Convert.ToString(reader["po_box"]);
            }
            if (reader["street_name"] != DBNull.Value)
            {
                Branches.street_name = Convert.ToString(reader["street_name"]);
            }
            if (reader["tel_no"] != DBNull.Value)
            {
                Branches.tel_no = Convert.ToString(reader["tel_no"]);
            }
            return Branches;
        }
        private static Delegates getDelegatesByRegistrationNoGoverHelper(OracleDataReader reader)
        {

            Delegates Delegates = new Delegates();
            if (reader["DELEGATE_BIRTH_DATE"] != DBNull.Value)
            {
                Delegates.DELEGATE_BIRTH_DATE = Convert.ToString(reader["DELEGATE_BIRTH_DATE"]);
            }
            if (reader["DELEGATE_IDENT_ISSUING_DATE"] != DBNull.Value)
            {
                Delegates.DELEGATE_IDENT_ISSUING_DATE = Convert.ToString(reader["DELEGATE_IDENT_ISSUING_DATE"]);
            }
            if (reader["DELEGATE_IDENT_ISSUING_PLACE"] != DBNull.Value)
            {
                Delegates.DELEGATE_IDENT_ISSUING_PLACE = Convert.ToString(reader["DELEGATE_IDENT_ISSUING_PLACE"]);
            }

            if (reader["DELEGATE_IDENTIFICATION_NO"] != DBNull.Value)
            {
                Delegates.DELEGATE_IDENTIFICATION_NO = Convert.ToString(reader["DELEGATE_IDENTIFICATION_NO"]);
            }
            if (reader["delegate_name"] != DBNull.Value)
            {
                Delegates.delegate_name = Convert.ToString(reader["delegate_name"]);
            }
            if (reader["DELEGATE_NAT_ID"] != DBNull.Value)
            {
                Delegates.DELEGATE_NAT_ID = Convert.ToString(reader["DELEGATE_NAT_ID"]);
            }
            if (reader["DELEGATE_NATIONALITY_CODE"] != DBNull.Value)
            {
                Delegates.DELEGATE_NATIONALITY_CODE = Convert.ToString(reader["DELEGATE_NATIONALITY_CODE"]);
            }
            if (reader["indv_national_id"] != DBNull.Value)
            {
                Delegates.indv_national_id = Convert.ToString(reader["indv_national_id"]);
            }
            if (reader["note"] != DBNull.Value)
            {
                Delegates.note = Convert.ToString(reader["note"]);
            }

            return Delegates;
        }
    }
}







