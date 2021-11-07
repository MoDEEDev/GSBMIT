using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoICT.Entities;
using MOICT.IDAL;
using MOICT.Factory;
using System.Diagnostics;

namespace MOICT.BLL
{
    public class CentralRegistrationBL
    {
        private static readonly IMITService dal = DataAccess.CreateInstance<IMITService>("CentralRegistrationRepository");
        public List<CentralRegistration> getRegisteryInfoByIndividualNationalNumber(string NationalNo)
        {
            return dal.getRegisteryInfoByIndividualNationalNumber(NationalNo);
        }

        public CentralRegistration getRegisteryInfoByEstablishmentNationalNumber(string NationalNo)
        {
            return dal.getRegisteryInfoByEstablishmentNationalNumber(NationalNo);         
        }

   
        public List<ccd_name> getccd_name(string NationalNo)
        {
            return dal.getccd_name(NationalNo);
        }

        public List<Logo_mark> getccd_mark(string NationalNo, string typeid)
        {
            return dal.getccd_mark(NationalNo, typeid);
        }

        public TradeMarksLogo getTradeMarkLogoBy(string trdmark_no, string dist)
        {
            return dal.getTradeMarkLogoBy(trdmark_no, dist);          
        }
        public List<comminfo> getcomminfo(string regno, string code)
        {
            return dal.getcomminfo(regno, code);
        }
        // old web service
        public CentralRegistration getIndividualRegistry(long registryNationalNo)
        {
            return dal.GetIndividualRegistry(registryNationalNo);
        }
        public List<TradeMark> getTradeMark(String key, int keyCode)
        {
            return dal.getTradeMark(key, keyCode);
        }
        public List<RegisteryPurposes> GetRegistryPurposeByIndvID(decimal intIndvID)
        {
            return dal.GetRegistryPurposeByIndvID(intIndvID);
        }

        public InstituteInformation2 GetInstitiuteInfobyIDNumber(string ID_NUMBER)
        {
            return dal.GetInstitiuteInfobyIDNumber(ID_NUMBER);
            
        }

        public List<Intended> getIntendedBySharedCode(string sharedCode)
        {
            return dal.getIntendedBySharedCode(sharedCode);
        }

        public List<Modifications> getModificationsByRegistrationNoGover(string sharedCode)
        {
            return dal.getModificationsByRegistrationNoGover(sharedCode);
        }

        //*****************************//
        public List<InstituteInformation> GetInstitiuteInfobyTradeName(string strTradeName)
        {
            return dal.GetInstitiuteInfobyTradeName(strTradeName);

        }
        public CentralRegistrationS getRegisteryInfoByRegNumber(string regno, string gov)
        {
            return dal.getRegisteryInfoByRegNumber(regno, gov);
        }
        public CentralRegistrationRS getRegisteryInfoRS(string natno)
        {
            return dal.getRegisteryInfoRS(natno);
        }
        public List<CapitalHistory> getcapitalhistory(string no)
        {
            return dal.getcapitalhistory(no);

        }
        public List<comm_names> CommNamesRS(string natno)
        {
            return dal.CommNamesRS(natno);
        }
    }
}