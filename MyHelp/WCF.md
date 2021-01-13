Windows Communication Foundation (WCF)

- Web services (asmx) are available on http protocol only, but wcf services are availabe on tcp (in binary format), http (message in xml format), msmq etc.
- Web services are hosted in IIS and WCF services can be hosted in IIS, Windows Activation Service, Self-Hosting, Windows Service
- In WCF, you have [ServiceContract] (attribute on class), [OperationContract] (attribute on methods to expose), [DataContract](on data class), [DataMember] (on properties).
- ABC means address, binding, contract.
- [FaultContract] is used to propagate errors to its clients.
- [MessageContract], [MessageHeader], [MessageBodyMember]
- Endpoints provide the configuration for the communication. It has Address(service loacation - URI), Binding(protocol), Contract(what message is exposed)

