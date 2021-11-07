using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MoICT.Entities;

namespace MOICT
{
[DataContract]
public class MOICTException
{
    private string operation;
    private string problemType;
    private string errorcode;

    [DataMember]
    public string Operation
    {
        get { return operation; }
        set { operation = value; }
    }

    [DataMember]
    public string ProblemType
    {
        get { return problemType; }
        set { problemType = value; }
    }

    [DataMember]
    public string ErrorCode
    {
        get { return errorcode; }
        set { errorcode = value; }
    }
}
}