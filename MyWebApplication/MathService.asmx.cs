using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebApplicationForAsmxWebService
{
    /// <summary>
    /// How to creat a web service (asmx service): 
    /// 1. Add a project (ASP.NET Web Application (.NET Framework) to a solution
    /// 2. Rigt-click on the project and add a new item (Web Service(ASMX))
    /// 3. Rename the service to MathService.asmx and add the following web methods: Add, Subtract etc.
    /// 4. Right-click on the MathService.asmx and click on Open With... and select Web Service Editor (Default) to open MathService.asmx
    ///    to view the CodeBehind and Class name: 
    ///    <%@ WebService Language="C#" CodeBehind="MathService.asmx.cs" Class="MyWebApplicationForAsmxWebService.MathService" %>
    /// 5. You run the site by clicking F5, and type in https://localhost:44384/MathService.asmx in the browser to test web methods.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {
        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        [WebMethod]
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        [WebMethod]
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
