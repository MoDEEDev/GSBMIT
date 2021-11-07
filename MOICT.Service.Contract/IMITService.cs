using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using MoICT.Entities;

    namespace MOICT.Services
    {      

        [ServiceContract]
        public interface IMITService
        {
            [OperationContract]
            [FaultContract(typeof(MOICTException))]
            List<CentralRegistration> getRegisteryInfoByIndividualNationalNumber(string NationalNo);

            [OperationContract]
            [FaultContract(typeof(MOICTException))]
            CentralRegistration getRegisteryInfoByEstablishmentNationalNumber(string NationalNo);

            [OperationContract]
            [FaultContract(typeof(MOICTException))]
            TradeMarksLogo getTradeMarkLogoBy(string trdmark_no, string dist);

            [OperationContract]
            [FaultContract(typeof(MOICTException))]
            List<ccd_name> getccd_name(string NationalNo);

           [OperationContract]
           [FaultContract(typeof(MOICTException))]
           List<Logo_mark> getccd_mark(string NationalNo, string typeid);
            // old web service operations--------------------------------------------------------------------------------//
            [OperationContract]
            [FaultContract(typeof(MOICTException))]
            CentralRegistration getIndividualRegistry(long registryNationalNo);
            //getcomminfo

            [OperationContract]
            [FaultContract(typeof(MOICTException))]
            List <comminfo>  getcomminfo(string regno,string code);

        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        List<TradeMark> getTradeMark(String key, int keyCode);
        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        List<RegisteryPurposes> GetRegistryPurposeByIndvID(decimal intIndvID);

        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        InstituteInformation2 GetInstitiuteInfobyIDNumber(string ID_NUMBER);

        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        List<Intended> getIntendedBySharedCode(string sharedCode);

        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        List<Modifications> getModificationsByRegistrationNoGover(string sharedCode);

       //**********************************************************************//

        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        List<InstituteInformation> GetInstitiuteInfobyTradeName(string strTradeName);

        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        CentralRegistrationS getRegisteryInfoByRegNumber(string regno,string gov);
        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        List<CapitalHistory> getcapitalhistory(string no);
            //getRegisteryInfoRS
        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        CentralRegistrationRS getRegisteryInfoRS(string NationalNo);
        [OperationContract]
        [FaultContract(typeof(MOICTException))]
        List<comm_names> CommNamesRS(string NationalNo);

    }
    }

