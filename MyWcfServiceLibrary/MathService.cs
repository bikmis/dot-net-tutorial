using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWcfServiceLibrary
{

    public class MathService : IMathService
    {
        public decimal Divide(decimal number1, decimal number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (Exception ex)
            {
                Error error = new Error() { ErrorCode = "no code", ErrorMessage = ex.Message };
                throw new FaultException<Error>(error);
            }
        }
    }
}
