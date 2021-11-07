using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MoICT.Entities;
using MOICT.BLL;
using System.ServiceModel.Activation;
using System.Security.Permissions;

namespace MOICT.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class MITService : IMITService
    {
        List<CentralRegistration> IMITService.getRegisteryInfoByIndividualNationalNumber(string NationalNo)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getRegisteryInfoByIndividualNationalNumber(NationalNo);
        }

        CentralRegistration IMITService.getRegisteryInfoByEstablishmentNationalNumber(string NationalNo)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getRegisteryInfoByEstablishmentNationalNumber(NationalNo);
        }
        CentralRegistrationRS IMITService.getRegisteryInfoRS(string NationalNo)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getRegisteryInfoRS(NationalNo);
        }


        TradeMarksLogo IMITService.getTradeMarkLogoBy(string trdmark_no, string dist)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getTradeMarkLogoBy(trdmark_no, dist);
        }

        // old web service
        CentralRegistration IMITService.getIndividualRegistry(long registryNationalNo)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getIndividualRegistry(registryNationalNo);
        }
        List<comminfo> IMITService.getcomminfo(string regno, string code)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getcomminfo(regno,code);
        }
        List<ccd_name> IMITService.getccd_name(string NationalNo)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getccd_name(NationalNo);
        }

        List<Logo_mark> IMITService.getccd_mark(string NationalNo, string typeid)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getccd_mark(NationalNo, typeid);
        }
        public List<TradeMark> getTradeMark(String key, int keyCode)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            //return bl.getIndividualRegistry(registryNationalNo);
            return bl.getTradeMark(key, keyCode);
        }
        public List<RegisteryPurposes> GetRegistryPurposeByIndvID(decimal intIndvID)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            //return bl.getIndividualRegistry(registryNationalNo);
            return bl.GetRegistryPurposeByIndvID(intIndvID);
        }

        public InstituteInformation2 GetInstitiuteInfobyIDNumber(string ID_NUMBER)
        {
            {
                CentralRegistrationBL bl = new CentralRegistrationBL();
                return bl.GetInstitiuteInfobyIDNumber(ID_NUMBER);
            }
        }

        public List<Intended> getIntendedBySharedCode(string sharedCode)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getIntendedBySharedCode(sharedCode);
        }

        public List<Modifications> getModificationsByRegistrationNoGover(string sharedCode)
        {
            CentralRegistrationBL bl = new CentralRegistrationBL();
            return bl.getModificationsByRegistrationNoGover(sharedCode);
        }

        //******************************

        public List<InstituteInformation> GetInstitiuteInfobyTradeName(string strTradeName)
        {
            {
                CentralRegistrationBL bl = new CentralRegistrationBL();
                return bl.GetInstitiuteInfobyTradeName(strTradeName);
            }
        }
        public CentralRegistrationS getRegisteryInfoByRegNumber(string gov,string regno)
        {
            {
                CentralRegistrationBL bl = new CentralRegistrationBL();
                return bl.getRegisteryInfoByRegNumber(gov,regno);
            }
        }
        public List<CapitalHistory> getcapitalhistory(string no)
        {
            {
                CentralRegistrationBL bl = new CentralRegistrationBL();
                return bl.getcapitalhistory(no);
            }
        }
        public List<comm_names> CommNamesRS(string natno)
        {
            {
                CentralRegistrationBL bl = new CentralRegistrationBL();
                return bl.CommNamesRS(natno);
            }
        }
    }
}
