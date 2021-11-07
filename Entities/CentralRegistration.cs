using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace MoICT.Entities
{
    [DataContract()]

    #region "Central Registration"
    public partial class CentralRegistration
    {

        #region Members
        private string _strRegistryName;  // الاسم التجاري
        private string _strRegistryOwner; // مالك السجل التجاري
        private String _decRegistryNo; // رقم السجل التجاري
        private string _dtmRegistryDate; // تاريخ التسجيل
        private string _dtmRegistryDate2; //تاريخ تسجيل الاسم التجاري
        private Nullable<decimal> _decCapitalValue; // رأس المال
        private Nullable<decimal> _decCapitalValue2;//رأس المال عند التسجيل
        private string _strGovernorateName; // المحافظة
        private string _strRegistryStatus; // حالة السجل التجاري
        private string _strRegistryNationality; // جنسية مالك السجل التجاري
        private Nullable<decimal> _decRegistryNationalNo; // الرقم الوطني للسجل التجاري
        private string _strRegistryAddress; // العنوان التجاري
        private decimal _p_indv_id;
        private string _regcn_no;
        private List<RegisteryPurposes> _strRegisteryPurposes;
        private List<TradeMark> _lstTradeMarks;
        private string _reggov;
        private string _strRegistryPurpose;
        //****************
        private Nullable<Boolean> _blnHasData = false;
        private Nullable<Int64> _intID_Number;
        private Nullable<Int64> _intIndv_ID;
        private Nullable<Int64> _intCommercialNameNo;
        private string _dtmCommercialNameDate;
        private string _strAuthorizedSignatoryForManagement;
        private string _strAuthorizedSignatoryForFinancial;
        private string _regps01;
        private string _rEGAUTZD;
        private string _strRegistryOwnerNatNo;
        #endregion

        #region "Public Properties"

        [DataMember()]
        public string strRegistryPurpose
        {
            get { return _strRegistryPurpose; }
            set { _strRegistryPurpose = value; }
        }
        [DataMember()]
        public string strRegistryOwnerNatNo
        {
            get { return _strRegistryOwnerNatNo; }
            set { _strRegistryOwnerNatNo = value; }
        }


        [DataMember()]
        public string Regps01
        {
            get { return _regps01; }
            set { _regps01 = value; }
        }
        [DataMember()]
        public string REGAUTZD
        {
            get { return _rEGAUTZD; }
            set { _rEGAUTZD = value; }
        }

        [DataMember()]
        public string strRegistryName
        {
            get { return _strRegistryName; }
            set { _strRegistryName = value; }
        }

        [DataMember()]
        public string strRegistryOwner
        {
            get { return _strRegistryOwner; }
            set { _strRegistryOwner = value; }
        }

        [DataMember()]
        public String decRegistryNo
        {
            get { return _decRegistryNo; }
            set { _decRegistryNo = value; }
        }


        [DataMember()]
        public string strGovernorateName
        {
            get { return _strGovernorateName; }
            set { _strGovernorateName = value; }
        }

        [DataMember()]
        public string strRegistryStatus
        {
            get { return _strRegistryStatus; }
            set { _strRegistryStatus = value; }
        }

        [DataMember()]
        public string dtmRegistryDate
        {
            get { return _dtmRegistryDate; }
            set { _dtmRegistryDate = value; }
        }
        [DataMember()]
        public string dtmRegistryDate2
        {
            get { return _dtmRegistryDate2; }
            set { _dtmRegistryDate2 = value; }
        }
        [DataMember()]
        public Nullable<decimal> decCapitalValue
        {
            get { return _decCapitalValue; }
            set { _decCapitalValue = value; }
        }
        [DataMember()]
        public Nullable<decimal> decCapitalValue2
        {
            get { return _decCapitalValue2; }
            set { _decCapitalValue2 = value; }
        }
        [DataMember()]
        public string strRegistryNationality
        {
            get { return _strRegistryNationality; }
            set { _strRegistryNationality = value; }
        }
        [DataMember()]
        public Nullable<decimal> decRegistryNationalNo
        {
            get { return _decRegistryNationalNo; }
            set { _decRegistryNationalNo = value; }
        }
        [DataMember()]
        public string strRegistryAddress
        {
            get { return _strRegistryAddress; }
            set { _strRegistryAddress = value; }
        }
        [DataMember()]
        public decimal p_indv_id
        {
            get { return _p_indv_id; }
            set { _p_indv_id = value; }
        }

        [DataMember()]
        public string reggov
        {
            get { return _reggov; }
            set { _reggov = value; }
        }

        [DataMember()]
        public string regcn_no
        {
            get { return _regcn_no; }
            set { _regcn_no = value; }
        }


        [DataMember()]
        public List<RegisteryPurposes> strRegisteryPurposes
        {
            get { return _strRegisteryPurposes; }
            set
            {

                _strRegisteryPurposes = value;
            }
        }
        [DataMember()]
        public List<TradeMark> lstTradeMarks
        {
            get { return _lstTradeMarks; }
            set
            {
                _lstTradeMarks = value;
            }
        }

        // from old
        [DataMember]
        public Nullable<Boolean> HasData
        {
            get { return _blnHasData; }
            set { _blnHasData = value; }
        }
        [DataMember]
        public Nullable<Int64> intID_Number
        {
            get { return _intID_Number; }
            set { _intID_Number = value; }
        }
        [DataMember]
        public Nullable<Int64> intIndv_ID
        {
            get { return _intIndv_ID; }
            set { _intIndv_ID = value; }
        }
        [DataMember]
        public Nullable<Int64> intCommercialNameNo
        {
            get { return _intCommercialNameNo; }
            set { _intCommercialNameNo = value; }
        }

        [DataMember]
        public string dtmCommercialNameDate
        {
            get { return _dtmCommercialNameDate; }
            set { _dtmCommercialNameDate = value; }
        }

        [DataMember]
        public string strAuthorizedSignatoryForManagement
        {
            get { return _strAuthorizedSignatoryForManagement; }
            set { _strAuthorizedSignatoryForManagement = value; }
        }

        [DataMember]
        public string strAuthorizedSignatoryForFinancial
        {
            get { return _strAuthorizedSignatoryForFinancial; }
            set { _strAuthorizedSignatoryForFinancial = value; }
        }
        #endregion

    }
    #endregion
    #region "Central RegistrationRS"
    public partial class CentralRegistrationRS
    {

        #region Members
        private string _REG_NAT_ID;    //الرقم الوطني للمنشأة
        private string _reg_no; //رقم السجل التجاري
        private string _reg_gov_code;//كود المحافظة
        private string _indv_reg_date; //تاريخ التسجيل
        private string _Ownername; //مالك السجل التجاري
        private string _owner_nationalid;//الرقم الوطني لمالك السجل
        private string _nat_ardesc; //جنسية مالك السجل التجاري 
        private string _comm_name; //الاسم التجاري
        private string _comm_reg_date; //تاريخ تسجيل الاسم التجاري
        private string _cn_status;//حالة الاسم التجاري 
        private string _cn_reg_no; //رقم تسجيل الاسم التجاري
        private string _address_name; //العنوان التجاري
        private string _governorate; //المحافظة
        private string _AREA; // المنطقة
        private string _REGSTREEET; //الشارع
        private string _APARTMENT; //شقة
        private string _BUILDING; //مبنى
        private string _CELLPHONE; //الهاتف  النقال 
        private string _REGFAX; //الفاكس
        private string _REGZIP;//الرمز البريدي
        private string _REGBOX;//صندوق البريد 
        private string _REGMAIL;//البريد الالكتروني
        private string _Status;//حالة السجل التجاري
        private string _reg_capital;//رأس المال عند التسجيل
        private string _current_capital;//رأس المال
        private string _REGTEL; //الأرضي  الهاتف
        private string _COUNTRY;//البلد
        private string _REGCTY; //المدينة
        private string _status_code; //رمز الحالة
        private List<RegisteryPurposes> _aims;//الغايات
        private List<Modifications> _Modifications;//Modification List
        private List<Branches> _Branches; //Branches List
        private List<Delegates> _Delegates;
        private string _nationality_code;//كود الجنسية
        #endregion

        #region "Public Properties"

        [DataMember()]
        public string status_code
        {
            get { return _status_code; }
            set { _status_code = value; }
        }
        [DataMember()]
        public string reg_gov_code
        {
            get { return _reg_gov_code; }
            set { _reg_gov_code = value; }
        }
        [DataMember()]
        public string nationality_code
        {
            get { return _nationality_code; }
            set { _nationality_code = value; }
        }
        [DataMember()]
        public string REG_NAT_ID
        {
            get { return _REG_NAT_ID; }
            set { _REG_NAT_ID = value; }
        }
        [DataMember()]
        public string REGCTY
        {
            get { return _REGCTY; }
            set { _REGCTY = value; }
        }
        [DataMember()]
        public string REGTEL
        {
            get { return _REGTEL; }
            set { _REGTEL = value; }
        }
        [DataMember()]
        public string reg_no
        {
            get { return _reg_no; }
            set { _reg_no = value; }
        }
        [DataMember()]
        public string COUNTRY
        {
            get { return _COUNTRY; }
            set { _COUNTRY = value; }
        }
        [DataMember()]
        public List<Modifications> modifications
        {
            get { return _Modifications; }
            set { _Modifications = value; }
        }
        [DataMember()]
        public List<Branches> Branches
        {
            get { return _Branches; }
            set { _Branches = value; }
        }
        [DataMember()]
        public List<Delegates> Delegates
        {
            get { return _Delegates; }
            set { _Delegates = value; }
        }
        [DataMember()]
        public List<RegisteryPurposes> aims
        {
            get { return _aims; }
            set
            {

                _aims = value;
            }
        }
        [DataMember()]
        public string indv_reg_date
        {
            get { return _indv_reg_date; }
            set { _indv_reg_date = value; }
        }
        [DataMember()]
        public string Ownername
        {
            get { return _Ownername; }
            set { _Ownername = value; }
        }

        [DataMember()]
        public string owner_nationalid
        {
            get { return _owner_nationalid; }
            set { _owner_nationalid = value; }
        }

        [DataMember()]
        public string nat_ardesc
        {
            get { return _nat_ardesc; }
            set { _nat_ardesc = value; }
        }

        [DataMember()]
        public String comm_name
        {
            get { return _comm_name; }
            set { _comm_name = value; }
        }


        [DataMember()]
        public string comm_reg_date
        {
            get { return _comm_reg_date; }
            set { _comm_reg_date = value; }
        }

        [DataMember()]
        public string cn_status
        {
            get { return _cn_status; }
            set { _cn_status = value; }
        }

        [DataMember()]
        public string cn_reg_no
        {
            get { return _cn_reg_no; }
            set { _cn_reg_no = value; }
        }
        [DataMember()]
        public string address_name
        {
            get { return _address_name; }
            set { _address_name = value; }
        }
        [DataMember()]
        public string governorate
        {
            get { return _governorate; }
            set { _governorate = value; }
        }
        [DataMember()]
        public string AREA
        {
            get { return _AREA; }
            set { _AREA = value; }
        }
        [DataMember()]
        public string REGSTREEET
        {
            get { return _REGSTREEET; }
            set { _REGSTREEET = value; }
        }
        [DataMember()]
        public string APARTMENT
        {
            get { return _APARTMENT; }
            set { _APARTMENT = value; }
        }
        [DataMember()]
        public string BUILDING
        {
            get { return _BUILDING; }
            set { _BUILDING = value; }
        }
    

        [DataMember()]
        public string CELLPHONE
        {
            get { return _CELLPHONE; }
            set { _CELLPHONE = value; }
        }

        [DataMember()]
        public string regcn_no
        {
            get { return _REGFAX; }
            set { _REGFAX = value; }
        }


        [DataMember()]
        public string REGFAX
        {
            get { return _REGFAX; }
            set
            {

                _REGFAX = value;
            }
        }
        [DataMember()]
        public string REGZIP
        {
            get { return _REGZIP; }
            set
            {
                _REGZIP = value;
            }
        }

        // from old
        [DataMember]
        public string REGBOX
        {
            get { return _REGBOX; }
            set { _REGBOX = value; }
        }
        [DataMember]
        public string REGMAIL
        {
            get { return _REGMAIL; }
            set { _REGMAIL = value; }
        }
        [DataMember]
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        [DataMember]
        public string reg_capital
        {
            get { return _reg_capital; }
            set { _reg_capital = value; }
        }

        [DataMember]
        public string current_capital
        {
            get { return _current_capital; }
            set { _current_capital = value; }
        }



        #endregion

    }
    #endregion
    #region "Central RegistrationS"
    public partial class CentralRegistrationS
    {

        #region Members
        private string _rgrn;  // رقم التسجيل
        private string _p_indv_id;
        private string _gov_desc; // المحافظة
        private decimal _decCapitalValue2; // رأس المالreg
        private string _ARMERCHANTNAME; // اسم المالك
        private string _rgrd; // تاريخ التسجيل
        private string _address_desc;
        private string _status_desc;
        //****************
        private string _regcn_no;
        private string _nat_desc;
        private string _IDNumber;
        private string _regcn;//الاسم التجاري

        #endregion

        #region "Public Properties"
        //optimiza - 20-04-2020
        [DataMember()]
        public string rgrn
        {
            get { return _rgrn; }
            set { _rgrn = value; }
        }
        //optimiza - 20-04-2020
        [DataMember()]
        public string p_indv_id
        {
            get { return _p_indv_id; }
            set { _p_indv_id = value; }
        }


        [DataMember()]
        public string gov_desc
        {
            get { return _gov_desc; }
            set { _gov_desc = value; }
        }


        [DataMember()]
        public decimal decCapitalValue2
        {
            get { return _decCapitalValue2; }
            set { _decCapitalValue2 = value; }
        }

        [DataMember()]
        public string ARMERCHANTNAME
        {
            get { return _ARMERCHANTNAME; }
            set { _ARMERCHANTNAME = value; }
        }



        [DataMember()]
        public string rgrd
        {
            get { return _rgrd; }
            set { _rgrd = value; }
        }

        [DataMember()]
        public string address_desc
        {
            get { return _address_desc; }
            set { _address_desc = value; }
        }

        [DataMember()]
        public string status_desc
        {
            get { return _status_desc; }
            set { _status_desc = value; }
        }

        [DataMember()]
        public string regcn_no
        {
            get { return _regcn_no; }
            set { _regcn_no = value; }
        }
        [DataMember()]
        public string nat_desc
        {
            get { return _nat_desc; }
            set { _nat_desc = value; }
        }
        [DataMember()]
        public string IDNumber
        {
            get { return _IDNumber; }
            set { _IDNumber = value; }
        }
        [DataMember()]
        public string regcn
        {
            get { return _regcn; }
            set { _regcn = value; }
        }

        #endregion
    }
    #endregion
    #region "comminfo"
    public partial class comminfo
    {
        #region Members
        private string _regct_code;  // الاسم التجاري
        private string _regno; // مالك السجل التجاري
        private string _Ar_regcnown;
        private string _ar_regcn;
        private string _Stat_code; // رقم السجل التجاري
        #endregion
        #region "Public Properties"
        [DataMember()]
        public string regct_code
        {
            get { return _regct_code; }
            set { _regct_code = value; }
        }
        [DataMember()]
        public string regno
        {
            get { return _regno; }
            set { _regno = value; }
        }
        [DataMember()]
        public string Ar_regcnown
        {
            get { return _Ar_regcnown; }
            set { _Ar_regcnown = value; }
        }
        [DataMember()]
        public string ar_regcn
        {
            get { return _ar_regcn; }
            set { _ar_regcn = value; }
        }
        [DataMember()]
        public string Stat_code
        {
            get { return _Stat_code; }
            set { _Stat_code = value; }
        }
        #endregion
    }

    #endregion
    #region "ccd_name"
    public partial class ccd_name
    {
        #region Members
        private string _regcn;
        private string _ARMERCHANTNAME;
        private string _ID_NUMBER;
        private string _Type;
        private string _Arname;
        #endregion

        #region "Public Properties"
        [DataMember()]
        public string Regcn
        {
            get { return _regcn; }
            set { _regcn = value; }
        }
        [DataMember()]
        public string ARMERCHANTNAME
        {
            get { return _ARMERCHANTNAME; }
            set { _ARMERCHANTNAME = value; }
        }
        [DataMember()]
        public string ID_NUMBER
        {
            get { return _ID_NUMBER; }
            set { _ID_NUMBER = value; }
        }
        [DataMember()]
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        [DataMember()]
        public string Arname
        {
            get { return _Arname; }
            set { _Arname = value; }
        }
        #endregion
    }
    #endregion
    #region "Logo_mark"
    public partial class Logo_mark
    {
        #region Members
        private string _registration_nbr;
        private string _mark_name;
        private string _mark_name_lang2;
        private DateTime _registration_date;
        private DateTime _expiration_dater;
        private string _company_name;
        private string _gral_person_id_typ;
        private string _gral_person_id_nbr;
        private byte[] _logo_data;
        private string _file_nbr;
        #endregion

        #region "Public Properties"
        [DataMember()]
        public string Registration_nbr
        {
            get { return _registration_nbr; }
            set { _registration_nbr = value; }
        }
        [DataMember()]
        public string Mark_name
        {
            get { return _mark_name; }
            set { _mark_name = value; }
        }
        [DataMember()]
        public string Mark_name_lang2
        {
            get { return _mark_name_lang2; }
            set { _mark_name_lang2 = value; }
        }
        [DataMember()]
        public DateTime Registration_date
        {
            get { return _registration_date; }
            set { _registration_date = value; }
        }
        [DataMember()]
        public DateTime Expiration_dater
        {
            get { return _expiration_dater; }
            set { _expiration_dater = value; }
        }
        [DataMember()]
        public string Company_name
        {
            get { return _company_name; }
            set { _company_name = value; }
        }
        [DataMember()]
        public string Gral_person_id_typ
        {
            get { return _gral_person_id_typ; }
            set { _gral_person_id_typ = value; }
        }
        [DataMember()]
        public string Gral_person_id_nbr
        {
            get { return _gral_person_id_nbr; }
            set { _gral_person_id_nbr = value; }
        }
        [DataMember()]
        public byte[] Logo_data
        {
            get { return _logo_data; }
            set { _logo_data = value; }
        }
        [DataMember()]
        public string File_nbr
        {
            get { return _file_nbr; }
            set { _file_nbr = value; }
        }


        #endregion
    }
    #endregion

    #region " Registery Purposes"
    public partial class RegisteryPurposes
    {
        private string _aim_desc;
        private string _aims_code;
        private string _isic_flag;
        private string _status;
        [DataMember()]
        public string aim_desc
        {
            get { return _aim_desc; }
            set { _aim_desc = value; }
        }
        [DataMember()]
        public string aims_code
        {
            get { return _aims_code; }
            set { _aims_code = value; }
        }
        [DataMember()]
        public string isic_flag
        {
            get { return _isic_flag; }
            set { _isic_flag = value; }
        }
        [DataMember()]
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
    #endregion

    #region " Trade Marks"
    public partial class TradeMark
    {
        private string _trdmark_status;
        private decimal _decTradeMarkNo;
        private string _strTradeMarkEnName;
        private string _strTradeMarkArName;
        //private byte[] _tms_pict = new byte[100];
        private Int16 _dist;

        private string _strTradeMarkOwnerCityAr;
        private string _strTradeMarkOwnerCityEn;
        private string _strTradeMarkOwnerCountry;
        private Nullable<Decimal> _decTradeMarkOwnerPOBox;
        private Nullable<Decimal> _decTradeMarkOwnerPostCode;
        private string _strTradeMarkOwnerTel;
        private Nullable<int> _intAgencyNo;
        private string _strAgencyNameAr;
        private string _strAgencyNameEn;
        private string _dtmApplicationDate;
        private Nullable<int> _intClassNo;
        private string _strClassNoAr;
        private string _strClassNoEn;
        private string _strCompanyType;
        private string _strCompanyTypeDescAr;
        private string _strCompanyTypeDescEn;
        private string _strCountryCode;
        private string _strCountryCodeDescAr;
        private string _strCountryCodeDescEn;
        private Nullable<int> _intDist;
        private string _strTradeMarkOwnerAr;
        private string _strTradeMarkOwnerEn;
        private string _strTradeMarkStatus;
        private string _strTradeMarkStatusDescAr;
        private string _strTradeMarkStatusDescEn;
        private string _strTradeMarkOwnerAddressAr;
        private string _strTradeMarkOwnerAddressEn;
        private Nullable<Decimal> _decCompanyNO;
        private Nullable<Decimal> _decTMSGOV;

        [DataMember()]
        public decimal decTradeMarkNo
        {
            get { return _decTradeMarkNo; }
            set { _decTradeMarkNo = value; }
        }
        [DataMember()]
        public string trdmark_status
        {
            get { return _trdmark_status; }
            set { _trdmark_status = value; }
        }
        [DataMember()]
        public string strTradeMarkEnName
        {
            get { return _strTradeMarkEnName; }
            set { _strTradeMarkEnName = value; }
        }
        [DataMember()]
        public string strTradeMarkArName
        {
            get { return _strTradeMarkArName; }
            set { _strTradeMarkArName = value; }
        }
        [DataMember()]
        public Int16 dist
        {
            get { return _dist; }
            set { _dist = value; }
        }

        [DataMember]
        public string strTradeMarkOwnerCityAr
        {
            get { return _strTradeMarkOwnerCityAr; }
            set { _strTradeMarkOwnerCityAr = value; }
        }

        [DataMember]
        public string strTradeMarkOwnerCityEn
        {
            get { return _strTradeMarkOwnerCityEn; }
            set { _strTradeMarkOwnerCityEn = value; }
        }

        [DataMember]
        public string strTradeMarkOwnerCountry
        {
            get { return _strTradeMarkOwnerCountry; }
            set { _strTradeMarkOwnerCountry = value; }
        }

        [DataMember]
        public Nullable<Decimal> decTradeMarkOwnerPOBox
        {
            get { return _decTradeMarkOwnerPOBox; }
            set { _decTradeMarkOwnerPOBox = value; }
        }

        [DataMember]
        public Nullable<Decimal> decTradeMarkOwnerPostCode
        {
            get { return _decTradeMarkOwnerPostCode; }
            set { _decTradeMarkOwnerPostCode = value; }
        }

        [DataMember]
        public string strTradeMarkOwnerTel
        {
            get { return _strTradeMarkOwnerTel; }
            set { _strTradeMarkOwnerTel = value; }
        }

        [DataMember]
        public Nullable<int> intAgencyNo
        {
            get { return _intAgencyNo; }
            set { _intAgencyNo = value; }
        }

        [DataMember]
        public string strAgencyNameAr
        {
            get { return _strAgencyNameAr; }
            set { _strAgencyNameAr = value; }
        }

        [DataMember]
        public string strAgencyNameEn
        {
            get { return _strAgencyNameEn; }
            set { _strAgencyNameEn = value; }
        }

        [DataMember]
        public string dtmApplicationDate
        {
            get { return _dtmApplicationDate; }
            set { _dtmApplicationDate = value; }
        }

        [DataMember]
        public Nullable<int> intClassNo
        {
            get { return _intClassNo; }
            set { _intClassNo = value; }
        }

        [DataMember]
        public string strClassNoAr
        {
            get { return _strClassNoAr; }
            set { _strClassNoAr = value; }
        }

        [DataMember]
        public string strClassNoEn
        {
            get { return _strClassNoEn; }
            set { _strClassNoEn = value; }
        }

        [DataMember]
        public string strCompanyType
        {
            get { return _strCompanyType; }
            set { _strCompanyType = value; }
        }

        [DataMember]
        public string strCompanyTypeDescAr
        {
            get { return _strCompanyTypeDescAr; }
            set { _strCompanyTypeDescAr = value; }
        }

        [DataMember]
        public string strCompanyTypeDescEn
        {
            get { return _strCompanyTypeDescEn; }
            set { _strCompanyTypeDescEn = value; }
        }

        [DataMember]
        public string strCountryCode
        {
            get { return _strCountryCode; }
            set { _strCountryCode = value; }
        }

        [DataMember]
        public string strCountryCodeDescAr
        {
            get { return _strCountryCodeDescAr; }
            set { _strCountryCodeDescAr = value; }
        }

        [DataMember]
        public string strCountryCodeDescEn
        {
            get { return _strCountryCodeDescEn; }
            set { _strCountryCodeDescEn = value; }
        }

        [DataMember]
        public Nullable<int> intDist
        {
            get { return _intDist; }
            set { _intDist = value; }
        }



        [DataMember]
        public string strTradeMarkOwnerAr
        {
            get { return _strTradeMarkOwnerAr; }
            set { _strTradeMarkOwnerAr = value; }
        }

        [DataMember]
        public string strTradeMarkOwnerEn
        {
            get { return _strTradeMarkOwnerEn; }
            set { _strTradeMarkOwnerEn = value; }
        }

        [DataMember]
        public string strTradeMarkStatus
        {
            get { return _strTradeMarkStatus; }
            set { _strTradeMarkStatus = value; }
        }

        [DataMember]
        public string strTradeMarkStatusDescAr
        {
            get { return _strTradeMarkStatusDescAr; }
            set { _strTradeMarkStatusDescAr = value; }
        }

        [DataMember]
        public string strTradeMarkStatusDescEn
        {
            get { return _strTradeMarkStatusDescEn; }
            set { _strTradeMarkStatusDescEn = value; }
        }

        [DataMember]
        public string strTradeMarkOwnerAddressAr
        {
            get { return _strTradeMarkOwnerAddressAr; }
            set { _strTradeMarkOwnerAddressAr = value; }
        }

        [DataMember]
        public string strTradeMarkOwnerAddressEn
        {
            get { return _strTradeMarkOwnerAddressEn; }
            set { _strTradeMarkOwnerAddressEn = value; }
        }

        [DataMember]
        public Nullable<Decimal> decCompanyNO
        {
            get { return _decCompanyNO; }
            set { _decCompanyNO = value; }
        }

        [DataMember]
        public Nullable<Decimal> decTMSGOV
        {
            get { return _decTMSGOV; }
            set { _decTMSGOV = value; }
        }
    }
    #endregion

    public partial class TradeMarksLogo
    {
        private byte[] _tms_pict;

        [DataMember()]
        public byte[] tms_pict
        {
            get { return _tms_pict; }
            set { _tms_pict = value; }
        }
    }

    #region "Institute Inforamtion
    public partial class InstituteInformation
    {

        #region Members
        private string _strRegistrationName; // الاسم التجاري
        private string _strOwnerName;  // اسم المالك
        private decimal _decRegNo; // رقم تسجيل الشركة
        private DateTime _dtmRegistryDate; // تاريخ التسجيل
        private decimal _decCapitalValue; // راس المال عند التسجيل
        private decimal _decCurrentCapitalValue; // راس المال الحالي
        private string _strGovernorateName; // المحافظة
        private string _strInstituteStatus; // حالة المؤسسة
        private decimal _decNationalityCode; // كود الجنسية 
        private string _strNationalityDescription; // وصف الجنسية
        private decimal _decRegistryNationalNo; // الرقم الوطني للسجل التجاري
        private decimal _IDNumber; // الرقم الوطني للمنشأة       
        private decimal _decIndivID; // الكود المشترك للغايات
        private decimal _decRegistrationNo; // رقم الاسم التجاري
        private DateTime _decRegistrationDate; // تاريخ تسجيل الاسم التجاري
        private decimal _decGoverCode; // كودالمحافظة
        private decimal _decOwnerNationalNo; // الرقم الوطني للمالك
        private string _strAuthorized1; // المفوض الأول
        private string _strAuthorized2; // المفوض الثاني
        private decimal _strInstituteStatusCode;
        #endregion

        #region "Public Properties"

        [DataMember()]
        public string strRegistrationName
        {
            get { return _strRegistrationName; }
            set { _strRegistrationName = value; }
        }

        [DataMember()]
        public string strOwnerName
        {
            get { return _strOwnerName; }
            set { _strOwnerName = value; }
        }
        //
        public decimal strInstituteStatusCode
        {
            get { return _strInstituteStatusCode; }
            set { _strInstituteStatusCode = value; }
        }
        [DataMember()]
        public decimal decRegNo
        {
            get { return _decRegNo; }
            set { _decRegNo = value; }
        }

        [DataMember()]
        public DateTime dtmRegistryDate
        {
            get { return _dtmRegistryDate; }
            set { _dtmRegistryDate = value; }
        }

        [DataMember()]
        public decimal decCapitalValue
        {
            get { return _decCapitalValue; }
            set { _decCapitalValue = value; }
        }

        [DataMember()]
        public decimal decCurrentCapitalValue
        {
            get { return _decCurrentCapitalValue; }
            set { _decCurrentCapitalValue = value; }
        }

        [DataMember()]
        public string strGovernorateName
        {
            get { return _strGovernorateName; }
            set { _strGovernorateName = value; }
        }

        [DataMember()]
        public string strInstituteStatus
        {
            get { return _strInstituteStatus; }
            set { _strInstituteStatus = value; }
        }

        [DataMember()]
        public decimal decNationalityCode
        {
            get { return _decNationalityCode; }
            set { _decNationalityCode = value; }
        }

        [DataMember()]
        public string strNationalityDescription
        {
            get { return _strNationalityDescription; }
            set { _strNationalityDescription = value; }
        }

        [DataMember()]
        public decimal decRegistryNationalNo
        {
            get { return _decRegistryNationalNo; }
            set { _decRegistryNationalNo = value; }
        }

        [DataMember()]
        public decimal IDNumber
        {
            get { return _IDNumber; }
            set { _IDNumber = value; }
        }

        [DataMember()]
        public decimal decIndivID
        {
            get { return _decIndivID; }
            set { _decIndivID = value; }
        }

        [DataMember()]
        public decimal decRegistrationNo
        {
            get { return _decRegistrationNo; }
            set { _decRegistrationNo = value; }
        }

        [DataMember()]
        public DateTime decRegistrationDate
        {
            get { return _decRegistrationDate; }
            set { _decRegistrationDate = value; }
        }

        [DataMember()]
        public decimal decGoverCode
        {
            get { return _decGoverCode; }
            set { _decGoverCode = value; }
        }

        [DataMember()]
        public decimal decOwnerNationalNo
        {
            get { return _decOwnerNationalNo; }
            set { _decOwnerNationalNo = value; }
        }

        [DataMember()]
        public string strAuthorized1
        {
            get { return _strAuthorized1; }
            set { _strAuthorized1 = value; }
        }

        [DataMember()]
        public string strAuthorized2
        {
            get { return _strAuthorized2; }
            set { _strAuthorized2 = value; }
        }

        #endregion

    }
    #endregion
    #region "Institute Inforamtion
    public partial class InstituteInformation2
    {

        #region Members
        private string _strRegistrationName; // الاسم التجاري
        private string _strOwnerName;  // اسم المالك
        private string _decRegNo; // رقم تسجيل الشركة
        private string _dtmRegistryDate; // تاريخ التسجيل
        private decimal _decCapitalValue; // راس المال عند التسجيل
        private decimal _decCurrentCapitalValue; // راس المال الحالي
        private string _strGovernorateName; // المحافظة
        private string _strInstituteStatus; // حالة المؤسسة
        private decimal _decNationalityCode; // كود الجنسية 
        private string _strNationalityDescription; // وصف الجنسية
        private decimal _decRegistryNationalNo; // الرقم الوطني للسجل التجاري
        private decimal _IDNumber; // الرقم الوطني للمنشأة  
        private string _regdist;
        private decimal _decIndivID; // الكود المشترك للغايات
        private string _decRegistrationNo; // رقم الاسم التجاري
        private string _decRegistrationDate; // تاريخ تسجيل الاسم التجاري
        private decimal _decGoverCode; // كودالمحافظة
        private decimal _decOwnerNationalNo; // الرقم الوطني للمالك
        private string _strAuthorized1; // المفوض الأول
        private string _strAuthorized2; // المفوض الثاني
        private String _strInstituteStatusCode;
        #endregion

        #region "Public Properties"

        [DataMember()]
        public string strRegistrationName
        {
            get { return _strRegistrationName; }
            set { _strRegistrationName = value; }
        }
        [DataMember()]
        public string regdist
        {
            get { return _regdist; }
            set { _regdist = value; }
        }
        [DataMember()]
        public string strOwnerName
        {
            get { return _strOwnerName; }
            set { _strOwnerName = value; }
        }
        //
        public string strInstituteStatusCode
        {
            get { return _strInstituteStatusCode; }
            set { _strInstituteStatusCode = value; }
        }
        [DataMember()]
        public string decRegNo
        {
            get { return _decRegNo; }
            set { _decRegNo = value; }
        }

        [DataMember()]
        public string dtmRegistryDate
        {
            get { return _dtmRegistryDate; }
            set { _dtmRegistryDate = value; }
        }

        [DataMember()]
        public decimal decCapitalValue
        {
            get { return _decCapitalValue; }
            set { _decCapitalValue = value; }
        }

        [DataMember()]
        public decimal decCurrentCapitalValue
        {
            get { return _decCurrentCapitalValue; }
            set { _decCurrentCapitalValue = value; }
        }

        [DataMember()]
        public string strGovernorateName
        {
            get { return _strGovernorateName; }
            set { _strGovernorateName = value; }
        }

        [DataMember()]
        public string strInstituteStatus
        {
            get { return _strInstituteStatus; }
            set { _strInstituteStatus = value; }
        }

        [DataMember()]
        public decimal decNationalityCode
        {
            get { return _decNationalityCode; }
            set { _decNationalityCode = value; }
        }

        [DataMember()]
        public string strNationalityDescription
        {
            get { return _strNationalityDescription; }
            set { _strNationalityDescription = value; }
        }

        [DataMember()]
        public decimal decRegistryNationalNo
        {
            get { return _decRegistryNationalNo; }
            set { _decRegistryNationalNo = value; }
        }

        [DataMember()]
        public decimal IDNumber
        {
            get { return _IDNumber; }
            set { _IDNumber = value; }
        }

        [DataMember()]
        public decimal decIndivID
        {
            get { return _decIndivID; }
            set { _decIndivID = value; }
        }

        [DataMember()]
        public string decRegistrationNo
        {
            get { return _decRegistrationNo; }
            set { _decRegistrationNo = value; }
        }

        [DataMember()]
        public string decRegistrationDate
        {
            get { return _decRegistrationDate; }
            set { _decRegistrationDate = value; }
        }

        [DataMember()]
        public decimal decGoverCode
        {
            get { return _decGoverCode; }
            set { _decGoverCode = value; }
        }

        [DataMember()]
        public decimal decOwnerNationalNo
        {
            get { return _decOwnerNationalNo; }
            set { _decOwnerNationalNo = value; }
        }

        [DataMember()]
        public string strAuthorized1
        {
            get { return _strAuthorized1; }
            set { _strAuthorized1 = value; }
        }

        [DataMember()]
        public string strAuthorized2
        {
            get { return _strAuthorized2; }
            set { _strAuthorized2 = value; }
        }

        #endregion

    }
    #endregion
    #region "Intended
    public partial class Intended
    {

        #region Members
        private decimal _sharedCode;  // الكود المشترك
        private decimal _intendedCode; // كود الغاية
        private string _intendedDescription; // وصف الغاية

        #endregion

        #region "Public Properties"

        [DataMember()]
        public decimal sharedCode
        {
            get { return _sharedCode; }
            set { _sharedCode = value; }
        }

        [DataMember()]
        public decimal intendedCode
        {
            get { return _intendedCode; }
            set { _intendedCode = value; }
        }

        [DataMember()]
        public string intendedDescription
        {
            get { return _intendedDescription; }
            set { _intendedDescription = value; }
        }

        #endregion

    }
    #endregion

    #region "Modifications"
    public partial class Modifications
    {

        #region Members
        private decimal _sharedCode; // الكود المشترك
        private String _decInstituteRegistrationNo;  // رقم تسجيل المؤسسة
        private decimal _decGoverCode; //  كود المحافظة
        private string _ModificationDescription; // وصف التعديل 
        private string _beforeModification; // قبل التعديل
        private string _afterModification; // بعد التعديل
        private DateTime _ModificationDate; // تاريخ التعديل
        private int _legal_modification_code;//كود نوع التغيير

        #endregion

        #region "Public Properties"

        [DataMember()]
        public decimal sharedCode
        {
            get { return _sharedCode; }
            set { _sharedCode = value; }
        }
        public int modCode
        {
            get { return _legal_modification_code; }
            set { _legal_modification_code = value; }
        }
        [DataMember()]
        public String decInstituteRegistrationNo
        {
            get { return _decInstituteRegistrationNo; }
            set { _decInstituteRegistrationNo = value; }
        }

        [DataMember()]
        public decimal decGoverCode
        {
            get { return _decGoverCode; }
            set { _decGoverCode = value; }
        }

        [DataMember()]
        public string ModificationDescription
        {
            get { return _ModificationDescription; }
            set { _ModificationDescription = value; }
        }

        [DataMember()]
        public string beforeModification
        {
            get { return _beforeModification; }
            set { _beforeModification = value; }
        }

        [DataMember()]
        public string afterModification
        {
            get { return _afterModification; }
            set { _afterModification = value; }
        }

        [DataMember()]
        public DateTime ModificationDate
        {
            get { return _ModificationDate; }
            set { _ModificationDate = value; }
        }
        #endregion

    }
    #endregion
    #region "Delegates"
    public partial class Delegates
    {

        #region Members
        private string _indv_national_id; // رقم المؤسسة الوطني
        private string _delegate_name;  // اسم المفوض
        private string _note; //  ملاحظات
        private string _DELEGATE_NAT_ID; // الرقم الوطني للمفوض 
        private string _DELEGATE_NATIONALITY_CODE; // رمز الجنسية
        private string _DELEGATE_BIRTH_DATE; // تاريخ الولادة
        private string _DELEGATE_BIRTH_PLACE; // مكان الولادة
        private string _DELEGATE_IDENT_ISSUING_DATE;//تاريخ الإصدار
        private string _DELEGATE_IDENT_ISSUING_PLACE;//مكان الإصدار
        private string _DELEGATE_IDENTIFICATION_NO;//رقم التعريف

        #endregion

        #region "Public Properties"

        [DataMember()]
        public string indv_national_id
        {
            get { return _indv_national_id; }
            set { _indv_national_id = value; }
        }
        public string delegate_name
        {
            get { return _delegate_name; }
            set { _delegate_name = value; }
        }
        [DataMember()]
        public string note
        {
            get { return _note; }
            set { _note = value; }
        }

        [DataMember()]
        public string DELEGATE_NAT_ID
        {
            get { return _DELEGATE_NAT_ID; }
            set { _DELEGATE_NAT_ID = value; }
        }

        [DataMember()]
        public string DELEGATE_NATIONALITY_CODE
        {
            get { return _DELEGATE_NATIONALITY_CODE; }
            set { _DELEGATE_NATIONALITY_CODE = value; }
        }

        [DataMember()]
        public string DELEGATE_BIRTH_DATE
        {
            get { return _DELEGATE_BIRTH_DATE; }
            set { _DELEGATE_BIRTH_DATE = value; }
        }

        [DataMember()]
        public string DELEGATE_IDENT_ISSUING_DATE
        {
            get { return _DELEGATE_IDENT_ISSUING_DATE; }
            set { _DELEGATE_IDENT_ISSUING_DATE = value; }
        }

        [DataMember()]
        public string DELEGATE_IDENT_ISSUING_PLACE
        {
            get { return _DELEGATE_IDENT_ISSUING_PLACE; }
            set { _DELEGATE_IDENT_ISSUING_PLACE = value; }
        }
        [DataMember()]
        public string DELEGATE_IDENTIFICATION_NO
        {
            get { return _DELEGATE_IDENTIFICATION_NO; }
            set { _DELEGATE_IDENTIFICATION_NO = value; }
        }
        #endregion

    }
    #endregion
    #region "Branches"
    public partial class Branches
    {
      


        #region Members
        private string _indv_national_id; //National Number
        private string _branch_no;  //Branch Number
        private string _desc_aa; //  Description in Arabic
        private string _desc_ee; // Description in English 
        private string _city_code; // City Code
        private string _tel_no; // Telephone Number
        private string _po_box; // P.O Box
        private string _email;//Email
        private string _fax_no;//Fax Number
        private string _mobile_no;//Mobile Number
        private string _street_name;//Street Number
        private string _branch_reg_gov_code;//Branch reg gov Code
        private string _country_code;//Country Code
        private string _area;//Area
        #endregion

        #region "Public Properties"

        [DataMember()]
        public string indv_national_id
        {
            get { return _indv_national_id; }
            set { _indv_national_id = value; }
        }
        public string branch_no
        {
            get { return _branch_no; }
            set { _branch_no = value; }
        }
        [DataMember()]
        public string desc_aa
        {
            get { return _desc_aa; }
            set { _desc_aa = value; }
        }

        [DataMember()]
        public string desc_ee
        {
            get { return _desc_ee; }
            set { _desc_ee = value; }
        }

        [DataMember()]
        public string city_code
        {
            get { return _city_code; }
            set { _city_code = value; }
        }

        [DataMember()]
        public string tel_no
        {
            get { return _tel_no; }
            set { _tel_no = value; }
        }

        [DataMember()]
        public string po_box
        {
            get { return _po_box; }
            set { _po_box = value; }
        }

        [DataMember()]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember()]
        public string fax_no
        {
            get { return _fax_no; }
            set { _fax_no = value; }
        }
        [DataMember()]
        public string Mobile_no
        {
            get { return _mobile_no; }
            set { _mobile_no = value; }
        }
        [DataMember()]
        public string street_name
        {
            get { return _street_name; }
            set { _street_name = value; }
        }
        [DataMember()]
        public string branch_reg_gov_code
        {
            get { return _branch_reg_gov_code; }
            set { _branch_reg_gov_code = value; }
        }
        [DataMember()]
        public string country_code
        {
            get { return _country_code; }
            set { _country_code = value; }
        }
        [DataMember()]
        public string area
        {
            get { return _area; }
            set { _area = value; }
        }
        #endregion

    }
    #endregion
    #region "Capital"
    public partial class CapitalHistory
    {

        #region Members

        private string _REGMODBEFORE; // بعد التعديل
        private string _REGMODAFTER; // تاريخ التعديل
        private string _REGDMOD;//كود نوع التغيير

        #endregion

        #region "Public Properties"


        [DataMember()]
        public string REGMODBEFORE
        {
            get { return _REGMODBEFORE; }
            set { _REGMODBEFORE = value; }
        }

        [DataMember()]
        public string REGMODAFTER
        {
            get { return _REGMODAFTER; }
            set { _REGMODAFTER = value; }
        }

        [DataMember()]
        public string REGDMOD
        {
            get { return _REGDMOD; }
            set { _REGDMOD = value; }
        }


        #endregion
    }
    #endregion
    public partial class comm_names
    {
        private string _comm_name;//الاإسم التجاري
        private string _REG_NAT_ID;//الرقم الوطني

        [DataMember()]
        public string comm_name
        {
            get { return _comm_name; }
            set { _comm_name = value; }
        }
        [DataMember()]
        public string REG_NAT_ID
        {
            get { return _REG_NAT_ID; }
            set { _REG_NAT_ID = value; }

        }
    }
}






