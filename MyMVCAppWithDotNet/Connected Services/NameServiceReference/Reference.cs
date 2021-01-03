﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyMVCAppWithDotNet.NameServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FullName", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class FullName : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NameServiceReference.INameService")]
    public interface INameService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INameService/GetName", ReplyAction="http://tempuri.org/INameService/GetNameResponse")]
        string GetName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INameService/GetName", ReplyAction="http://tempuri.org/INameService/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INameService/GetFullName", ReplyAction="http://tempuri.org/INameService/GetFullNameResponse")]
        MyMVCAppWithDotNet.NameServiceReference.FullName GetFullName(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INameService/GetFullName", ReplyAction="http://tempuri.org/INameService/GetFullNameResponse")]
        System.Threading.Tasks.Task<MyMVCAppWithDotNet.NameServiceReference.FullName> GetFullNameAsync(string firstName, string lastName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INameServiceChannel : MyMVCAppWithDotNet.NameServiceReference.INameService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NameServiceClient : System.ServiceModel.ClientBase<MyMVCAppWithDotNet.NameServiceReference.INameService>, MyMVCAppWithDotNet.NameServiceReference.INameService {
        
        public NameServiceClient() {
        }
        
        public NameServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NameServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetName(string name) {
            return base.Channel.GetName(name);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(string name) {
            return base.Channel.GetNameAsync(name);
        }
        
        public MyMVCAppWithDotNet.NameServiceReference.FullName GetFullName(string firstName, string lastName) {
            return base.Channel.GetFullName(firstName, lastName);
        }
        
        public System.Threading.Tasks.Task<MyMVCAppWithDotNet.NameServiceReference.FullName> GetFullNameAsync(string firstName, string lastName) {
            return base.Channel.GetFullNameAsync(firstName, lastName);
        }
    }
}
