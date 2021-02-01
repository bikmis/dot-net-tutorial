How to create WCF Service Library

- Right-click on the solution and add a project of "WCF Service Library" template.
- Add an interface (with ServiceContract, DataContract, DataMember etc) and implement it. 
- Right-click on WCF Service Library project and click on "Debug->Start New Instance". This will launch a WCF Service Host and WCF Test Client.

Wcf Service Host:
- If the following is checked in the properties of the WCF Service Library, then the service is hosted and 
  is available at "http://localhost:8733/Design_Time_Addresses/MyWcfServiceLibrary/Service1/mex" whenever a project in the solution is started with debug
     "Start WCF Service Host when debugging another project in the same solution"
- Now you can consume it from a wcf test client or some client application.

Wcf Test Client:
- Once the service is hosted in IIS or Wcf Service Host during development. We can run Wcftestclient.exe from Visual Studio command prompt(PowerShell) - it opens a wcf client window.
- We then need to add service (File -> Add Service) e.g. add "http://localhost:8733/Design_Time_Addresses/MyWcfServiceLibrary/Service1/mex".

FaultException
- If you don't have fault exception (fault contract), you will have a generic exception message sent to the client like below:
  System.ServiceModel.FaultException: 'The server was unable to process the request due to an internal error.  For more information about the error, 
  either turn on IncludeExceptionDetailInFaults (either from ServiceBehaviorAttribute or from the <serviceDebug> configuration behavior) on the server in order 
  to send the exception information back to the client, or turn on tracing as per the Microsoft .NET Framework SDK documentation and inspect the server trace logs.'
- Add FaultContract and then throw FaultException
    [OperationContract]  
    [FaultContract(typeof(MathFault))]  
    int Divide(int n1, int n2);

    Throw FaultException from the service.
    catch (DivideByZeroException)  
    {  
        MathFault mf = new MathFault();  
        mf.operation = "division";  
        mf.problemType = "divide by zero";  
        throw new FaultException<MathFault>(mf);  
    } 
- Or turn on IncludeExceptionDetailInFaults in <serviceDebug> only during development to send the exception information back to the client.
  <serviceDebug includeExceptionDetailInFaults="true"/>
- In the client code, catch the fault exception:
  catch (FaultException<Error> ex)
  {
    ViewBag.error = ex.Detail.ErrorMessage;
  }

