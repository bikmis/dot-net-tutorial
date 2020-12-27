    How to creat a web (asmx) service: 
    1. Add a project (ASP.NET Web Application (.NET Framework) to a solution
    2. Rigt-click on the project and add a new item (Web Service(ASMX))
    3. Rename the service to MathService.asmx and add the following web methods: Add, Subtract etc.
    4. Right-click on the MathService.asmx and click on Open With... and select Web Service Editor (Default) to open MathService.asmx
       to view the CodeBehind and Class name: 
       <%@ WebService Language="C#" CodeBehind="MathService.asmx.cs" Class="MyWebApplicationForAsmxWebService.MathService" %>
       
    How to test a web (asmx) service:
    1. You run the site by clicking F5, and type in https://localhost:44384/MathService.asmx in the browser to test web methods.

    How to publish web (asmx) service:
    1. 
