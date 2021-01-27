using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCAppWithDotNetCore.Interfaces
{
    public interface ISingletonGuidNumber
    {
        Guid CreateGuidNumber();
    }
}
