using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;


[ServiceContract]
public interface ITestService
{
    [OperationContract]
    string SaySomething(string something);
}