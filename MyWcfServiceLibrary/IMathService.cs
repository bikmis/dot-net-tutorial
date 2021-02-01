using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWcfServiceLibrary
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        [FaultContract(typeof(Error))]
        decimal Divide(decimal number1, decimal number2);
    }
}
