using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWcfServiceLibrary.MathService
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        decimal Divide(decimal number1, decimal number2);
    }
}
