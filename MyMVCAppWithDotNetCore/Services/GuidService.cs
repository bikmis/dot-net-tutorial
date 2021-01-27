using MyMVCAppWithDotNetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCAppWithDotNetCore.Services
{
    public class GuidService
    {
        public ITransientGuidNumber TransientGuidNumber { get; set; }
        public ISingletonGuidNumber SingletonGuidNumber { get; set; }
        public IScopedGuidNumber ScopedGuidNumber { get; set; }

        public GuidService(ITransientGuidNumber transientGuidNumber, ISingletonGuidNumber singletonGuidNumber, IScopedGuidNumber scopedGuidNumber) {
            TransientGuidNumber = transientGuidNumber;
            SingletonGuidNumber = singletonGuidNumber;
            ScopedGuidNumber = scopedGuidNumber;
        }
    }
}
