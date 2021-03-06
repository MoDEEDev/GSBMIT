//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAFTestClient.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmpInfo", Namespace="http://schemas.datacontract.org/2004/07/MoICT.Entities")]
    [System.SerializableAttribute()]
    public partial class EmpInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MOICTException", Namespace="http://schemas.datacontract.org/2004/07/MOICT")]
    [System.SerializableAttribute()]
    public partial class MOICTException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProblemTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operation {
            get {
                return this.OperationField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationField, value) != true)) {
                    this.OperationField = value;
                    this.RaisePropertyChanged("Operation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProblemType {
            get {
                return this.ProblemTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProblemTypeField, value) != true)) {
                    this.ProblemTypeField = value;
                    this.RaisePropertyChanged("ProblemType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IEmp")]
    public interface IEmp {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmp/GetEmps", ReplyAction="http://tempuri.org/IEmp/GetEmpsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(NAFTestClient.ServiceReference2.MOICTException), Action="http://tempuri.org/IEmp/GetEmpsMOICTExceptionFault", Name="MOICTException", Namespace="http://schemas.datacontract.org/2004/07/MOICT")]
        NAFTestClient.ServiceReference2.EmpInfo[] GetEmps();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmp/GetEmps", ReplyAction="http://tempuri.org/IEmp/GetEmpsResponse")]
        System.Threading.Tasks.Task<NAFTestClient.ServiceReference2.EmpInfo[]> GetEmpsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpChannel : NAFTestClient.ServiceReference2.IEmp, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpClient : System.ServiceModel.ClientBase<NAFTestClient.ServiceReference2.IEmp>, NAFTestClient.ServiceReference2.IEmp {
        
        public EmpClient() {
        }
        
        public EmpClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NAFTestClient.ServiceReference2.EmpInfo[] GetEmps() {
            return base.Channel.GetEmps();
        }
        
        public System.Threading.Tasks.Task<NAFTestClient.ServiceReference2.EmpInfo[]> GetEmpsAsync() {
            return base.Channel.GetEmpsAsync();
        }
    }
}
