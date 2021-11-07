
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoICT.Entities;

namespace MOICT.IDAL
{
    public interface IMITService
    {
        List<CentralRegistration> getRegisteryInfoByIndividualNationalNumber(string NationalNo);

        CentralRegistration getRegisteryInfoByEstablishmentNationalNumber(string NationalNo);

        List<ccd_name> getccd_name(string NationalNo);
        List<Logo_mark> getccd_mark(string NationalNo, string typeid);
        TradeMarksLogo getTradeMarkLogoBy(string trdmark_no, string dist);
        List<CapitalHistory> getcapitalhistory(string no);
        // old web service
        CentralRegistration GetIndividualRegistry(long registryNationalNo);
        List<TradeMark> getTradeMark(String key, int keyCode);
        List<RegisteryPurposes> GetRegistryPurposeByIndvID(decimal intIndvID);
        InstituteInformation2 GetInstitiuteInfobyIDNumber(string ID_NUMBER);
        List<comminfo> getcomminfo(string regno, string code);
        List<Intended> getIntendedBySharedCode(string sharedCode);
        List<Modifications> getModificationsByRegistrationNoGover(string sharedCode);
        CentralRegistrationS getRegisteryInfoByRegNumber(string gov, string regno);
        //**************
        CentralRegistrationRS getRegisteryInfoRS(string Natno);
        List<InstituteInformation> GetInstitiuteInfobyTradeName(string strTradeName);
        List<comm_names> CommNamesRS(string Natno);
    }
}