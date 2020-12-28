    How to creat a web (asmx) service: 
    1. Add a project (ASP.NET Web Application (.NET Framework) to a solution
    2. Rigt-click on the project and add a new item (Web Service(ASMX))
    3. Rename the service to MathService.asmx and add the following web methods: Add, Subtract etc.
    4. Right-click on the MathService.asmx and click on Open With... and select Web Service Editor (Default) to open MathService.asmx
       to view the CodeBehind and Class name: 
       <%@ WebService Language="C#" CodeBehind="MathService.asmx.cs" Class="MyWebApplicationForAsmxWebService.MathService" %>
       
    How to test a web (asmx) service:
    1. You run the site by clicking F5, and type in https://localhost:80/MathService.asmx in the browser to test web methods.

    How to publish / deploy a web (asmx) service to a folder:
    1. Build the project and right-click on the project to click on Publish...
    2. Choose Connection -> Publish method: File System and Target location: C:\inetpub\wwwroot\my_asmx_service
    3. Choose Configuration (Debug or Release). 
    4. Save
    5. The files are saved in a folder. Create an application in IIS and point to the folder containing publised files. 
    6. Right-click on the application in IIS and click on Edit Permissions..., then choose Security and add "Authenticated Users" to Group or user names.
    7. Type in http://localhost/MyAsmxService/MathService.asmx in the url of a browser to display all the web methods for you to test.
    
    How to consume a web (asmx) service:
    1. Create a .net core MVC application.
    2. Right-click on Connected Services and click on Add Connected Service
    3. Click on Microsoft WCF Web Service Reference Provider.
    4. Paste "http://localhost/MyAsmxService/MathService.asmx" in the URI and hit Go.
    5. Change Namespace to MathService and click Next and leave default values untouched and click Next and Check "Generate Synchronous Operations", then click on Finish.
    6. At Connected Services, you have MathService. MathServiceSoapClient is the client class.
    7. Go to HomeController.cs and in the Index method, write the following code:
       public IActionResult Index()
        {
            MathServiceSoapClient mathService = new MathServiceSoapClient(MathServiceSoapClient.EndpointConfiguration.MathServiceSoap);
            var sum = mathService.Add(1, 3);
            ViewBag.Sum = sum;
            return View();
        }            
      
      How to update the service reference in the client application:
      1. If you made changes to the web (asmx) service and redployed it to IIS, then you need to update the service client in the MVC application. Right-click 
         on MathService and click on Update Microsoft WCF Web Service Reference Provider...
      
      
