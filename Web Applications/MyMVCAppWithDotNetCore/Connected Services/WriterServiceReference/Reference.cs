﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WriterServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/MyWcfServiceLibrary")]
    public partial class Book : object
    {
        
        private double PriceField;
        
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price
        {
            get
            {
                return this.PriceField;
            }
            set
            {
                this.PriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WriterServiceReference.IWriterService")]
    public interface IWriterService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWriterService/GetWriter", ReplyAction="http://tempuri.org/IWriterService/GetWriterResponse")]
        string GetWriter(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWriterService/GetWriter", ReplyAction="http://tempuri.org/IWriterService/GetWriterResponse")]
        System.Threading.Tasks.Task<string> GetWriterAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWriterService/GetBooks", ReplyAction="http://tempuri.org/IWriterService/GetBooksResponse")]
        WriterServiceReference.Book[] GetBooks(string writer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWriterService/GetBooks", ReplyAction="http://tempuri.org/IWriterService/GetBooksResponse")]
        System.Threading.Tasks.Task<WriterServiceReference.Book[]> GetBooksAsync(string writer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IWriterServiceChannel : WriterServiceReference.IWriterService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class WriterServiceClient : System.ServiceModel.ClientBase<WriterServiceReference.IWriterService>, WriterServiceReference.IWriterService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WriterServiceClient() : 
                base(WriterServiceClient.GetDefaultBinding(), WriterServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.WriterService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WriterServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(WriterServiceClient.GetBindingForEndpoint(endpointConfiguration), WriterServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WriterServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WriterServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WriterServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WriterServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WriterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string GetWriter(string name)
        {
            return base.Channel.GetWriter(name);
        }
        
        public System.Threading.Tasks.Task<string> GetWriterAsync(string name)
        {
            return base.Channel.GetWriterAsync(name);
        }
        
        public WriterServiceReference.Book[] GetBooks(string writer)
        {
            return base.Channel.GetBooks(writer);
        }
        
        public System.Threading.Tasks.Task<WriterServiceReference.Book[]> GetBooksAsync(string writer)
        {
            return base.Channel.GetBooksAsync(writer);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WriterService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WriterService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/MyWCFService/WriterService.svc/WriterService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WriterServiceClient.GetBindingForEndpoint(EndpointConfiguration.WriterService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WriterServiceClient.GetEndpointAddress(EndpointConfiguration.WriterService);
        }
        
        public enum EndpointConfiguration
        {
            
            WriterService,
        }
    }
}