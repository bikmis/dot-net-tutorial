using MyMVCAppWithDotNetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCAppWithDotNetCore.Implementations
{
    public class GuidNumber : ISingletonGuidNumber, IScopedGuidNumber, ITransientGuidNumber
    {
        private Guid _guidNumber;
        public GuidNumber() {
            _guidNumber = Guid.NewGuid();
        }

        public Guid CreateGuidNumber()
        {
            return _guidNumber;
        }
    }
}
