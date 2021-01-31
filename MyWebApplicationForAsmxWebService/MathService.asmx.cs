using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebApplicationForAsmxWebService
{
    /// <summary>
    /// MyWebApplicationForAsmxWebService.MathService
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
        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
